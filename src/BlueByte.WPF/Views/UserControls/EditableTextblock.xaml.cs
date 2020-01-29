using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace BlueByte.WPF.Views.UserControls
{
    public partial class EditableTextblock : UserControl
    {
        public static readonly DependencyProperty IsEditingProperty =
            DependencyProperty.Register("IsEditing", typeof(bool), typeof(EditableTextblock), new
                PropertyMetadata(false, new PropertyChangedCallback(IsEditingPropertyChange)));

        public bool IsEditing
        {
            get => (bool)GetValue(IsEditingProperty);
            set => SetValue(IsEditingProperty, value);
        }

        private static void IsEditingPropertyChange(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is EditableTextblock tb && e.NewValue is bool newValue)
            {
                tb.IsEditing = newValue;
            }
        }

        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register("Text", typeof(string), typeof(EditableTextblock), new
                PropertyMetadata(null));

        public string Text
        {
            get => (string)GetValue(TextProperty);
            set => SetValue(TextProperty, value);
        }

        public EditableTextblock()
        {
            InitializeComponent();
            LostFocus += EditableTextblock_LostFocus;
            KeyDown += OnKeyDown;
        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                IsEditing = false;
            }
        }

        private void EditableTextblock_LostFocus(object sender, RoutedEventArgs e)
        {
            IsEditing = false;
        }

        private void EditableTextblock_OnMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            IsEditing = !IsEditing;
        }
    }
}
