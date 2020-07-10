using System;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace DataBinding.Models
{
    public class ContactViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public ICommand LaunchWebSiteCommand { get; set; }
        public ICommand SaveContactCommand { get; set; }

        public ContactViewModel()
        {
            LaunchWebSiteCommand = new Command(async () => await LaunchWebSite());
            SaveContactCommand = new Command(async () => await SaveContact());
        }

        async Task SaveContact()
        {
            IsBusy = true;

            try
            {
                await Task.Delay(2000);
                IsBusy = false;
                await Application.Current.MainPage.DisplayAlert("Save Contact", "Kayıt Eklendi", "Cancel");
            }
            catch (Exception)
            {

                throw;
            }
        }

        async Task LaunchWebSite()
        {
            try
            {
                await Browser.OpenAsync(_webSite);
            }
            catch (Exception)
            {
            }
        }

        void OnPropertyChanged(string name) //Herhangi bir yede bir property'yi set ettiğimde bu method çalışacak.
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        private string _name;
        private long _phone;
        private string _webSite;
        private bool _favorite;
        private bool isBusy; //Bu property bize uygulamanın bloklanıp bloklanmadığı hakkında bilgi verecektir.
        public DateTime DateAdded { get; set; } = DateTime.Now;

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));  //Bu alan değiştiğinde Xaml'a haber ver. 
                OnPropertyChanged(nameof(DisplayMessage));
            }
        }

        public long Phone
        {
            get { return _phone; }
            set
            {
                _phone = value;
                OnPropertyChanged(nameof(Phone)); //Bu alan değiştiğinde Xaml'a haber ver.
            }
        }

        public string WebSite
        {
            get { return _webSite; }
            set
            {
                _webSite = value;
                OnPropertyChanged(nameof(WebSite));  //Bu alan değiştiğinde Xaml'a haber ver.
            }
        }

        public bool Favorite
        {
            get { return _favorite; }
            set
            {
                _favorite = value;
                OnPropertyChanged(nameof(Favorite)); //Bu alan değiştiğinde Xaml'a haber ver.
                OnPropertyChanged(nameof(DisplayMessage));
            }
        }

        public bool IsBusy
        {
            get { return isBusy; }
            set
            {
                isBusy = value;
                OnPropertyChanged(nameof(IsBusy)); //Bu alan değiştiğinde Xaml'a haber ver.
            }
        }

        public string DisplayMessage => $"{Name} senin arkadaşın{(Favorite ? "." : " değil.")}";
    }
}
