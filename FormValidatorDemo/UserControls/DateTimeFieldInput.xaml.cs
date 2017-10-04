using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace FormValidatorDemo.UserControls
{
    public sealed partial class DateTimeFieldInput : UserControl
    {
        public DateTimeFieldInput()
        {
            this.InitializeComponent();
        }

        private void control_LostFocus(object sender, RoutedEventArgs e)
        {
            ViewModel.DateTimeFieldInputViewModel viewModel = this.DataContext as ViewModel.DateTimeFieldInputViewModel;
            if (viewModel != null)
            {
                viewModel.ValidateData();
            }
        }
    }
}
