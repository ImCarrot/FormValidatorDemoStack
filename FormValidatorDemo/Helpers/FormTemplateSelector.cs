using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace FormValidatorDemo.Helpers
{
    internal class FormTemplateSelector : DataTemplateSelector
    {
        public DataTemplate TemplateWithDate { get; set; }
        public DataTemplate TemplateWithText { get; set; }

        protected override DataTemplate SelectTemplateCore(object item, DependencyObject container)
        {
            if (item is ViewModel.DateTimeFieldInputViewModel)
                return TemplateWithDate;
            if (item is ViewModel.TextFieldInputControlViewModel)
                return TemplateWithText;

            return base.SelectTemplateCore(item, container);
        }
    }
}
