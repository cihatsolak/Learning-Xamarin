using FirstApplication.ListViewDataBinding.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FirstApplication.ListViewDataBinding
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SampleListView : ContentPage
    {
        public List<Game> DataList { get; set; }
        public SampleListView()
        {
            InitializeComponent();

            GetGames();

            GameList.ItemsSource = DataList;
        }

        void GetGames()
        {
            DataList = new List<Game>()
            {
                new Game(){ Id=1, Name ="Call Of Duty", Price=57, ImageUrl="https://bit.ly/2LTeQ9R"},
                new Game(){ Id=2, Name ="Counter Strike", Price=57, ImageUrl="https://bit.ly/2LTeQ9R"},
                new Game(){ Id=3, Name ="Gta V", Price=57, ImageUrl="https://bit.ly/2LTeQ9R"},
                new Game(){ Id=4, Name ="Metin 2", Price=57, ImageUrl="https://bit.ly/2LTeQ9R"},
            };
        }

        void Handle_MenuEkle(object sender, EventArgs e)
        {
            var game = new Game() { Id = 5, Name = "Pubg Lite", Price = 57, ImageUrl = "https://bit.ly/2A7oSkZ" };
            GameList.ItemsSource = null;
            DataList.Add(game);
            GameList.ItemsSource = DataList;
        }

        void Handle_MenuSil(object sender, EventArgs e)
        {
            var game = (MenuItem)sender;
            var gameId = (int)game.CommandParameter;
            DataList.RemoveAll(x => x.Id == gameId);
            GameList.ItemsSource = null;
            GameList.ItemsSource = DataList;
        }

        async void GameList_Refreshing(object sender, EventArgs e)
        {
            GameList.IsRefreshing = true;
            await Task.Delay(4000);
            GameList.IsRefreshing = false;
        }
    }
}