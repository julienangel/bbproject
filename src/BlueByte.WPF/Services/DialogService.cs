using BlueByte.Infrastructure.Utils.Enums;
using BlueByte.Services.Interface.Interfaces;
using BlueByte.WPF.Views.Windows;

namespace BlueByte.WPF.Services
{
    public class DialogService : IDialogService
    {
        private bool _isOpened = false;
        private EComponentType? _currentComponentType = null;
        private ComponentDialog _componentDialog;

        public DialogService()
        {
            
        }

        public IComponentDialogResult ShowDialog()
        {
            _componentDialog = new ComponentDialog();
            bool? result = _componentDialog.ShowDialog();
            if (result == true)
            {
                return new ComponentDialogResult(_componentDialog.SelectedComponentType);
            }

            return null;
        }

        public void Close()
        {
            _componentDialog.Close();
        }
    }
}
