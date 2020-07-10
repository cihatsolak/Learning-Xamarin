using System;
using System.Globalization;
using Xamarin.Forms;

namespace FirstApplication.IValueConverters.Converter
{
    public class TeamImageConverter : IValueConverter
    {
        public string fenerbahce { get; set; }
        public string galatasaray { get; set; }
        public string trabzonspor { get; set; }
        public string besiktas { get; set; }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string teamName = (string)value;

            if (teamName == "Fenerbahçe")
                return fenerbahce;
            else if (teamName == "Galatasaray")
                return galatasaray;
            else if (teamName == "Beşiktaş")
                return besiktas;
            else if (teamName == "Trabzonspor")
                return trabzonspor;
            else
                return string.Empty;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
