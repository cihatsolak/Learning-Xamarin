using System;
using System.Globalization;
using Xamarin.Forms;

namespace UdemyCourse.ValueConverters
{
    public class LoginPageConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            return new object();
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
