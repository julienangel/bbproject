using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Input;
using BlueByte.Infrastructure.Utils.Enums;
using BlueByte.Infrastructure.Utils.Helpers;
using BlueByte.Services.Interface.Interfaces;
using BlueByte.ViewModel.Models;
using BlueByte.ViewModel.Models.Interfaces;
using BlueByte.ViewModel.Models.Mappers;
using BlueByte.ViewModel.Models.XML;
using BlueByte.ViewModel.ViewModels.Base;
using GalaSoft.MvvmLight.CommandWpf;

namespace BlueByte.ViewModel.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        #region Properties

        private Entity _selectedEntity = null;
        public Entity SelectedEntity
        {
            get => _selectedEntity;
            set
            {
                Set(ref _selectedEntity, value);
                LoadComponents(value);
            }
        }

        private ObservableCollection<Entity> _entities = new ObservableCollection<Entity>();
        public ObservableCollection<Entity> Entities
        {
            get => _entities;
            set => Set(ref _entities, value);
        }

        private ObservableCollection<IComponent> _components = new ObservableCollection<IComponent>();
        public ObservableCollection<IComponent> Components
        {
            get => _components;
            set => Set(ref _components, value);
        }

        private List<IComponent> _selectedComponents = new List<IComponent>();

        #endregion

        #region Commands

        public ICommand AddEntityCommand => new RelayCommand(AddEntity);
        public ICommand RemoveEntityCommand => new RelayCommand(RemoveEntity, canExecute: () => SelectedEntity != null);
        public ICommand ClearEntitiesCommand => new RelayCommand(ClearEntities, canExecute: () => Entities.Any());
        public ICommand LoadCommand => new RelayCommand(LoadXML);
        public ICommand SaveCommand => new RelayCommand(SaveXML, canExecute: () => Entities.Any());
        public ICommand BrowseFileCommand => new RelayCommand<IComponent>(BrowseFile);
        public ICommand AddComponentCommand => new RelayCommand(AddComponent, canExecute: () => SelectedEntity != null);
        public ICommand RemoveSingleComponentCommand => new RelayCommand<IComponent>(RemoveSingleComponent, canExecute: (component => SelectedEntity != null));
        public ICommand RemoveMultipleComponentsCommand => new RelayCommand(RemoveMultipleComponents, canExecute: (() => SelectedEntity != null && _selectedComponents.Any()));
        public ICommand ClearComponentsCommand => new RelayCommand(ClearComponents, canExecute: (() => Components.Any()));
        public ICommand SelectedItemsCommand => new RelayCommand<object>(SelectedItemsChanged, canExecute: ((s) => SelectedEntity != null));

        #endregion

        #region Constructors

        public MainViewModel(IDialogService dialogService) : base(dialogService)
        {

        }

        #endregion

        #region Methods

        private void AddEntity()
        {
            Entities.Add(new Entity());
        }

        private void RemoveEntity()
        {
            if (_selectedEntity != null)
                Entities.Remove(SelectedEntity);
        }

        private void ClearEntities()
        {
            if (MessageBox.Show("Are you sure?", "Clear all entities", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Entities = new ObservableCollection<Entity>();
            }
        }

        private void LoadXML()
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    Multiselect = false,
                    Filter = "XML files (*.xml)|*.xml"
                };

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    string xmlString = File.ReadAllText(filePath);
                    var entities = XmlManager.Deserialize<EntitiesXml>(xmlString).ToViewModel();

                    Entities = new ObservableCollection<Entity>(entities);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Some error occured when trying to parse this XML File!");
            }
        }

        private void SaveXML()
        {
            if (!Entities.Any())
                return;

            BlueByte.ViewModel.Models.Entities entities = new Entities();
            var entitiesXml = Entities.ToList().ToXml();
            string xmlParsed = XmlManager.Serialize(entitiesXml);

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "XML Files (*.xml)|*.xml";
                saveFileDialog.DefaultExt = "xml";
                saveFileDialog.AddExtension = true;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog.FileName, xmlParsed);
                }
            }
        }

        private void AddComponent()
        {
            var result = DialogService.ShowDialog();
            if (result == null) return;

            EComponentType type = result.Type;
            var component = Components.FirstOrDefault(x => x.ComponentType == type);

            if (component != null)
            {
                MessageBox.Show("Some error when adding a Component!");
                return;
            }

            switch (type)
            {
                case EComponentType.Asset:
                    component = new Asset();
                    SelectedEntity.Asset = (Asset)component;
                    Components.Add(component);
                    break;
                case EComponentType.Position:
                    component = new Position();
                    SelectedEntity.Position = (Position)component;
                    Components.Add(component);
                    break;
                case EComponentType.Behavior:
                    component = new Behavior();
                    SelectedEntity.Behavior = (Behavior)component;
                    Components.Add(component);
                    break;
            }
        }

        private void LoadComponents(Entity selectedEntity)
        {
            if (selectedEntity == null)
            {
                Components = new ObservableCollection<IComponent>();
                return;
            }

            List<IComponent> components = new List<IComponent>();

            if (selectedEntity.Asset != null)
                components.Add(selectedEntity.Asset);

            if (selectedEntity.Position != null)
                components.Add(selectedEntity.Position);

            if (selectedEntity.Behavior != null)
                components.Add(selectedEntity.Behavior);

            Components = new ObservableCollection<IComponent>(components);
        }

        private void RemoveSingleComponent(IComponent component)
        {
            switch (component.ComponentType)
            {
                case EComponentType.Asset:
                    SelectedEntity.Asset = null;
                    break;
                case EComponentType.Position:
                    SelectedEntity.Position = null;
                    break;
                case EComponentType.Behavior:
                    SelectedEntity.Behavior = null;
                    break;
            }

            Components.Remove(component);
        }

        private void RemoveMultipleComponents()
        {
            _selectedComponents.ToList().ForEach(RemoveSingleComponent);
        }

        private void ClearComponents()
        {
            Components.ToList().ForEach(RemoveSingleComponent);
        }

        private void SelectedItemsChanged(object obj)
        {
            _selectedComponents = (obj as IList<object>)?.OfType<IComponent>().ToList();
        }

        private void BrowseFile(IComponent component)
        {
            Asset asset = (Asset)component;
            if (asset != null)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    Multiselect = false
                };

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    asset.Filename = openFileDialog.SafeFileName;
                }
            }
        }

        #endregion
    }
}
