using System;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Course.DataBinding.Models
{
    public class ContactViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        [Obsolete]
        public ICommand WebCommand => new Command<string>(GetWebSite);

        [Obsolete]
        public ICommand InternalWebCommand => new Command<string>(GetInternalWebSite);

        void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        private string _name;
        private string _phone;
        private string _webSite;
        private bool _favorite;
        private bool _isBusy;

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }
        public string Phone
        {
            get { return _phone; }
            set
            {
                _phone = value;
                OnPropertyChanged(nameof(Phone));
            }
        }
        public string WebSite
        {
            get { return _webSite; }
            set
            {
                _webSite = value;
                OnPropertyChanged(nameof(WebSite));
            }
        }
        public bool Favorite
        {
            get { return _favorite; }
            set
            {
                _favorite = value;
                OnPropertyChanged(nameof(Favorite));
                OnPropertyChanged(nameof(DisplayMessage));
            }
        }
        public bool IsBusy
        {
            get { return _isBusy; }
            set
            {
                _isBusy = value;
                OnPropertyChanged(nameof(IsBusy));
            }
        }

        public string DisplayMessage => Favorite == true ? "Favorilere Eklendi." : "Favoride Değil";

        [Obsolete]
        void GetWebSite(string url)
        {
            Device.OpenUri(new Uri(url));
        }

        [Obsolete]
        async void GetInternalWebSite(string url)
        {
            IsBusy = true;
            await Task.Delay(5000);
            await Application.Current.MainPage.DisplayAlert("Title", "Message", "Cancel");
            IsBusy = false;
        }
    }
}
