using System;
using Windows.UI.Xaml.Data;

namespace FormValidatorDemo.Converters
{
    internal class BoolToVisibility : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            bool isError = (bool)value;
            if (isError)
                return Windows.UI.Xaml.Visibility.Visible;
            return Windows.UI.Xaml.Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
