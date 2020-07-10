using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

namespace Course.DataBinding.Models
{
    public class MovieViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }


        public List<string> Cities { get; set; }

        #region Properties 
        private string _firstName = string.Empty;

        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (_firstName == null)
                    return;

                _firstName = value;
                OnPropertyChanged(nameof(_firstName));
                OnPropertyChanged(nameof(FullName));
            }
        }

        private string _lastname = string.Empty;

        public string LastName
        {
            get { return _lastname; }
            set
            {
                if (_lastname == null)
                    return;

                _lastname = value;
                OnPropertyChanged(nameof(_lastname)); //her harf'te private değişkene değeri atıyor.
                OnPropertyChanged(nameof(FullName)); // değeri attıktan sonra full name'i de güncelliyor.
            }
        }

        private string _fullName = string.Empty;
        public string FullName
        {
            get { return $"{_firstName} {_lastname}"; }
            set
            {
                if (_fullName == null)
                    return;

                _fullName = value;
                OnPropertyChanged(nameof(FullName));
            }
        }

        private string _cityName = string.Empty;

        public string CityName
        {
            get { return _cityName; }
            set
            {
                if (_cityName == null)
                    return;

                _cityName = value;
                OnPropertyChanged(nameof(DisplaySelectedCityName));
            }
        }

        public string DisplaySelectedCityName => $"Seçilen Şehir: {_cityName}";

        #endregion

        public MovieViewModel()
        {
            Cities = GetCities();
        }

        List<string> GetCities()
        {
            return new List<string>
            {
                "İstanbul","Ankara","İzmir","Erzincan"
            };
        }


    }
}
