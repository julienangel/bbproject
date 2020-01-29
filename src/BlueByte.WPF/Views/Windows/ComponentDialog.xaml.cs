using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using BlueByte.Infrastructure.Utils.Enums;
using BlueByte.Services.Interface.Interfaces;

namespace BlueByte.WPF.Views.Windows
{
    /// <summary>
    /// Interaction logic for ComponentDialog.xaml
    /// </summary>
    public partial class ComponentDialog : Window, IComponentDialog
    {
        #region Dependency Properties

        public static readonly DependencyProperty SelectedComponentProperty =
            DependencyProperty.Register("SelectedComponentType", typeof(EComponentType), typeof(ComponentDialog), new
                PropertyMetadata(null));

        public EComponentType SelectedComponentType
        {
            get => (EComponentType)GetValue(SelectedComponentProperty);
            set => SetValue(SelectedComponentProperty, value);
        }

        public IEnumerable<EComponentType> ComponentTypes => Enum.GetValues(typeof(EComponentType)).Cast<EComponentType>();

        #endregion

        #region Constructors

        public ComponentDialog()
        {
            InitializeComponent();
            this.Owner = Application.Current.MainWindow;
        }

        #endregion

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            //this.Close();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            //this.Close();
        }
    }
}
