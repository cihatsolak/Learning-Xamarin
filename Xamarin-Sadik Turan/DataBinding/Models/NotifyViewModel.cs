using System.ComponentModel;

namespace DataBinding.Models
{
    //NotifyPropertyChanged.xaml sayfası için bir model oluşturduk.
    public class NotifyViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string _name = string.Empty;

        public string Name
        {
            get { return _name; }
            set
            {
                if (_name == value)
                    return;

                _name = value;
               
                OnPropertyChanged(nameof(_name));
                OnPropertyChanged(nameof(DisplayName));
            }
        }

        public string DisplayName => $"Name Entered:{Name}";
        void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
