using AcikAkademiApp.Models;
using AcikAkademiApp.Views;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace AcikAkademiApp.ViewModels
{
    public class ConferenceViewModel : INotifyPropertyChanged
    {
        #region Fields
        public event PropertyChangedEventHandler PropertyChanged;
        public ObservableCollection<Conference> conferences;
        private ICommand refreshCommand, updateCommand, deleteCommand, detailCommand;
        private int count;
        private bool isRefreshing = false;
        private string keyword;
        #endregion

        #region Properties
        public string Keyword
        {
            get
            {
                return keyword;
            }
            set
            {
                keyword = value;
                OnPropertyChanged(nameof(Keyword));
                Handle_Search(value as string);
            }
        }


        public ObservableCollection<Conference> Conferences
        {
            get
            {
                return conferences;
            }
            set
            {
                conferences = value;
                OnPropertyChanged(nameof(Conferences));
            }
        }

        public ICommand RefreshCommand
        {
            get
            {
                return refreshCommand;
            }
            set
            {
                refreshCommand = value;
            }
        }

        public ICommand DetailCommand
        {
            get
            {
                return detailCommand;
            }
            set
            {
                detailCommand = value;
            }
        }

        public ICommand DeleteCommand
        {
            get
            {
                return deleteCommand;
            }
            set
            {
                deleteCommand = value;
            }
        }

        public ICommand UpdateCommand
        {
            get
            {
                return updateCommand;
            }
            set
            {
                updateCommand = value;
            }
        }

        public bool IsRefreshing
        {
            get { return isRefreshing; }
            set
            {
                if (isRefreshing != value)
                {
                    isRefreshing = value;
                    OnPropertyChanged(nameof(IsRefreshing));
                }
            }
        }

        public int Count
        {
            get
            {
                return count;
            }
            set
            {
                count = value;
                OnPropertyChanged(nameof(Count));
            }
        }
        #endregion

        #region Ctor
        public ConferenceViewModel()
        {
            BindData();
            refreshCommand = new Command(Handle_Refresh);
            deleteCommand = new Command(Handle_Delete);
            updateCommand = new Command(Handle_Update);
            detailCommand = new Command(Handle_Detail);
        }

        async void Handle_Detail(object param)
        {
            if (param != null)
                await App.Current.MainPage.Navigation.PushModalAsync(new ConferenceDetailView(param as Conference));
        }

        void Handle_Update(object param)
        {
            if (param != null)
            {
                var conference = param as Conference;
                conference.Title = $"Güncellendi: {conference.Title}";
                //Conference modelin notifyPropertChanged 'i olmadığı için ekranda görünmez.
            }
        }
        #endregion

        #region Methods
        void Handle_Delete(object param)
        {
            if (param != null)
            {
                var conference = param as Conference;
                Conferences.Remove(conference);
            }
        }

        void Handle_Search(string key)
        {
            if (key.Length > 4)
            {
                var searchItems = Conferences.Where(x => x.Title.ToLower().StartsWith(key.ToLower())).ToList();
                Conferences.Clear();
                searchItems.ForEach(x => Conferences.Add(x));
                Count = searchItems.Count();
            }
            else
            {
                if (key.Length == 0)
                {
                    Conferences.Clear();
                    BindData();
                }
            }
        }

        async void Handle_Refresh()
        {
            IsRefreshing = true;
            await Task.Delay(3000);
            IsRefreshing = false;
            await App.Current.MainPage.DisplayAlert("Başlık", "Yenileme işlemi bitti.", "İptal");
        }

        void BindData()
        {
            Conferences = new ObservableCollection<Conference>
            {
                new Conference{Id=1,Image="https://sites.google.com/site/boteinonu/_/rsrc/1547104396820/d-ici-etkinlik/etkinlik-2/Ads%C4%B1z%20tasar%C4%B1m%20%281%29.png",Title="Güvenli Sosyal Medya", Description="Facebook, Twitter, Instagram, LinkedIn, YouTube… İnternet hayatımızın her alanında, sosyal medya platformları da..", PublishDate= DateTime.Parse("2020-04-16")},
                new Conference{Id=2,Image="https://sites.google.com/site/boteinonu/_/rsrc/1547104396820/d-ici-etkinlik/etkinlik-2/Ads%C4%B1z%20tasar%C4%B1m%20%281%29.png",Title="Her Mesajı Açmayın", Description="Mesaj kutunuza gelen sahte mesajlar veya linklerden korunmanın en basit yolu, onları açmamak!", PublishDate= DateTime.Parse("2020-05-24")},
                new Conference{Id=3,Image="https://sites.google.com/site/boteinonu/_/rsrc/1547104396820/d-ici-etkinlik/etkinlik-2/Ads%C4%B1z%20tasar%C4%B1m%20%281%29.png",Title="Beyaz Şapkalı Hacker", Description="Hesabı çalınan sosyal medya fenomenlerinin hesaplarını geri almak için de başvurduğu “beyaz şapkalı hacker'lar.", PublishDate= DateTime.Parse("2020-06-02")}
            };

            Count = Conferences.Count();
        }

        // Create the OnPropertyChanged method to raise the event
        // The calling member's name will be used as the parameter.
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        #endregion
    }
}
