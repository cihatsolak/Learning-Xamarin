using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;

namespace App2
{
    public class CarsViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private ObservableCollection<Car> cars;

        public ObservableCollection<Car> Cars
        {
            get
            {
                if (cars == null)
                    cars = new ObservableCollection<Car>();

                return cars;
            }

            set { cars = value; }
        }

        public CarsViewModel()
        {
            BindData();
        }

        void BindData()
        {
            Cars.Add(new Car()
            {
                Id = 1,
                Name = "Hyundai",
                Detail = "Accent Blue"
            });

            Cars.Add(new Car()
            {
                Id = 1,
                Name = "Opel",
                Detail = "Astra"
            });
        }

        public ICommand DeleteCar
        {
            get
            {
                return new Command((paramater) =>
                {
                    if (paramater != null)
                    {
                        var car = paramater as Car;
                        Cars.Remove(car);
                    }
                });
            }
        }

        public ICommand SendCar
        {
            get
            {
                return new Command((parameter) =>
                {
                    if (parameter != null)
                    {
                        var car = parameter as Car;
                      
                    }
                });
            }
        }

        public void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
