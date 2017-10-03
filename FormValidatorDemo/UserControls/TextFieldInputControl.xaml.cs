using Windows.UI.Xaml.Controls;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace FormValidatorDemo.UserControls
{
    public sealed partial class TextFieldInputControl : UserControl
    {
        public TextFieldInputControl()
        {
            this.InitializeComponent();
        }

        private void control_LostFocus(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            if (this.DataContext is ViewModel.TextFieldInputControlViewModel viewModel)
            {
                viewModel.ValidateData();
            }
        }
    }
}
