using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;

namespace FirstApplication.Elements.ViewModels
{
    public class PickerMVVMViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public List<City> Cities { get; set; }
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        private string _selectedCity;

        public string SelectedCity
        {
            get { return _selectedCity; }
            set
            {
                if (_selectedCity != value)
                {
                    _selectedCity = value;
                    OnPropertyChanged(SelectedCity);

                    MyCity = $"Seçilen Şehir: {SelectedCity}";
                }
            }
        }

        private string _myCity;

        public string MyCity
        {
            get { return _myCity; }
            set 
            {
                if (_myCity != value)
                {
                    _myCity = value;
                    OnPropertyChanged(MyCity);
                }
            }
        }

        public PickerMVVMViewModel()
        {
            Cities = GetCities();
        }

        List<City> GetCities()
        {
            var cities = new List<City>()
            {
                new City(){Id = 1, Name="Eskişehir"},
                new City(){Id = 2, Name="İstanbul"},
                new City(){Id = 3, Name="Ankara"},
                new City(){Id = 4, Name="İzmir"},
                new City(){Id = 5, Name="Kayseri"}
            };

            return cities.OrderBy(x => x.Name).ToList();
        }
    }
}
