using System;
using System.Globalization;
using Xamarin.Forms;

namespace UdemyCourse.ValueConverters
{
    public class LoginVerifyConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool response = false;

            if (int.Parse(value.ToString()) > 0)
            {
                if (((Switch)parameter).IsToggled)
                    response = true;
            }

            return response;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
