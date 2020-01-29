using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace BlueByte.WPF.Views.UserControls
{
    public partial class BaseComponentControl : UserControl
    {

        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register("Title", typeof(string), typeof(BaseComponentControl), new
                PropertyMetadata(null));

        public string Title
        {
            get => (string)GetValue(TitleProperty);
            set => SetValue(TitleProperty, value);
        }

        public static readonly DependencyProperty RemoveCommandProperty =
            DependencyProperty.Register(
                "RemoveCommand",
                typeof(ICommand),
                typeof(BaseComponentControl), new UIPropertyMetadata(null));

        public ICommand RemoveCommand
        {
            get => (ICommand)GetValue(RemoveCommandProperty);
            set => SetValue(RemoveCommandProperty, value);
        }

        public static readonly DependencyProperty RemoveCommandParameterProperty =
            DependencyProperty.Register("RemoveCommandParameter", typeof(object), typeof(BaseComponentControl), new
                PropertyMetadata());

        public object RemoveCommandParameter
        {
            get => (object)GetValue(RemoveCommandParameterProperty);
            set => SetValue(RemoveCommandParameterProperty, value);
        }

        public BaseComponentControl()
        {
            InitializeComponent();
        }
    }
}
