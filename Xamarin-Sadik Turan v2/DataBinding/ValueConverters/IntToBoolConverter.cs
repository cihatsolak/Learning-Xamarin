using System;
using System.Globalization;
using Xamarin.Forms;

namespace Course.DataBinding.ValueConverters
{
    public class IntToBoolConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return false;

            string url = (string)value;

            if (url.Contains(".com") && url.Contains("https://"))
                return true;

            return false;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (bool)value ? 1 : 0;
        }
    }
}