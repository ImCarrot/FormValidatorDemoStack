using System;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media;

namespace FormValidatorDemo.Converters
{
    internal class BorderBrushOnErrorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            bool isError = (bool)value;
            if (isError)
                return new SolidColorBrush(Windows.UI.Colors.Red);
            return new SolidColorBrush(Windows.UI.Colors.Gray);
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
