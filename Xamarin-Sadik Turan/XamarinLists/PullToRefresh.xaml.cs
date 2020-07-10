
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinLists.Models;

namespace XamarinLists
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PullToRefresh : ContentPage
    {
        ObservableCollection<MovieGroupObservable> groupMovies = new ObservableCollection<MovieGroupObservable>();

        public PullToRefresh()
        {
            InitializeComponent();

            groupMovies.Add(
             new MovieGroupObservable("Komedi", "K") {
              new Movie{Id=1,Name="Hababam Sınıfı",Director="Lars Von Trier",ImageUrl="https://bit.ly/3brZOlH",CreatedOn=DateTime.Now, Description="Film açıklaması"},
              new Movie{Id=2,Name="Esaretin Bedeli",Director="Quentin Tarantino",ImageUrl="https://bit.ly/3brZOlH",CreatedOn=DateTime.Now.AddDays(-379), Description="Film açıklaması"},
              new Movie{Id=3,Name="Cep Herkülü: Naim Süleymanoğlu",Director="Andrei Tarkovsky",ImageUrl="https://bit.ly/3brZOlH",CreatedOn=DateTime.Now.AddDays(250), Description="Film açıklaması"},
              new Movie{Id=4,Name="Cesuryürek",Director="Jacques Tati",ImageUrl="https://bit.ly/3brZOlH",CreatedOn=DateTime.Now.AddDays(-679), Description="Film açıklaması"},
              new Movie{Id=5,Name="Yeşil Yol",Director="Bertrand Tavernier",ImageUrl="https://bit.ly/3brZOlH",CreatedOn=DateTime.Now.AddDays(23), Description="Film açıklaması"}}
           );

            groupMovies.Add(
              new MovieGroupObservable("Dram", "D") {
              new Movie{Id=6,Name="Hababam Sınıfı",Director="Lars Von Trier",ImageUrl="https://bit.ly/3brZOlH",CreatedOn=DateTime.Now, Description="Film açıklaması"},
              new Movie{Id=7,Name="Esaretin Bedeli",Director="Quentin Tarantino",ImageUrl="https://bit.ly/3brZOlH",CreatedOn=DateTime.Now.AddDays(-379), Description="Film açıklaması"},
              new Movie{Id=8,Name="Cep Herkülü: Naim Süleymanoğlu",Director="Andrei Tarkovsky",ImageUrl="https://bit.ly/3brZOlH",CreatedOn=DateTime.Now.AddDays(250), Description="Film açıklaması"},
              new Movie{Id=9,Name="Cesuryürek",Director="Jacques Tati",ImageUrl="https://bit.ly/3brZOlH",CreatedOn=DateTime.Now.AddDays(-679), Description="Film açıklaması"},
              new Movie{Id=10,Name="Yeşil Yol",Director="Bertrand Tavernier",ImageUrl="https://bit.ly/3brZOlH",CreatedOn=DateTime.Now.AddDays(23), Description="Film açıklaması"}}
            );

            groupMovies.Add(
              new MovieGroupObservable("Macera", "M") {
              new Movie{Id=11,Name="Hababam Sınıfı",Director="Lars Von Trier",ImageUrl="https://bit.ly/3brZOlH",CreatedOn=DateTime.Now, Description="Film açıklaması"},
              new Movie{Id=12,Name="Esaretin Bedeli",Director="Quentin Tarantino",ImageUrl="https://bit.ly/3brZOlH",CreatedOn=DateTime.Now.AddDays(-379), Description="Film açıklaması"},
              new Movie{Id=13,Name="Cep Herkülü: Naim Süleymanoğlu",Director="Andrei Tarkovsky",ImageUrl="https://bit.ly/3brZOlH",CreatedOn=DateTime.Now.AddDays(250), Description="Film açıklaması"},
              new Movie{Id=14,Name="Cesuryürek",Director="Jacques Tati",ImageUrl="https://bit.ly/3brZOlH",CreatedOn=DateTime.Now.AddDays(-679), Description="Film açıklaması"},
              new Movie{Id=15,Name="Yeşil Yol",Director="Bertrand Tavernier",ImageUrl="https://bit.ly/3brZOlH",CreatedOn=DateTime.Now.AddDays(23), Description="Film açıklaması"}}
            );

            groupMovies.Add(
              new MovieGroupObservable("Belgesel", "B") {
              new Movie{Id=16,Name="Hababam Sınıfı",Director="Lars Von Trier",ImageUrl="https://bit.ly/3brZOlH",CreatedOn=DateTime.Now, Description="Film açıklaması"},
              new Movie{Id=17,Name="Esaretin Bedeli",Director="Quentin Tarantino",ImageUrl="https://bit.ly/3brZOlH",CreatedOn=DateTime.Now.AddDays(-379), Description="Film açıklaması"},
              new Movie{Id=18,Name="Cep Herkülü: Naim Süleymanoğlu",Director="Andrei Tarkovsky",ImageUrl="https://bit.ly/3brZOlH",CreatedOn=DateTime.Now.AddDays(250), Description="Film açıklaması"},
              new Movie{Id=19,Name="Cesuryürek",Director="Jacques Tati",ImageUrl="https://bit.ly/3brZOlH",CreatedOn=DateTime.Now.AddDays(-679), Description="Film açıklaması"},
              new Movie{Id=20,Name="Yeşil Yol",Director="Bertrand Tavernier",ImageUrl="https://bit.ly/3brZOlH",CreatedOn=DateTime.Now.AddDays(23), Description="Film açıklaması"}}
            );

            listView.ItemsSource = groupMovies;
        }

        async void ListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var movie = e.SelectedItem as Movie;
            int movieIndex = e.SelectedItemIndex;

            var message = $"Seçilen Film \n Id: {movieIndex} \n Ad: {movie.Name}";
            await DisplayAlert("Selected Event", message, "Tamam");
        }

        async void ListViewItemTapped(object sender, ItemTappedEventArgs e)
        {
            var movie = e.Item as Movie;
            int movieIndex = e.ItemIndex;
            var group = e.Group as MovieGroup;

            var message = $"Seçilen Film Hakkında \n Id:{movieIndex} \n Ad: {movie.Name} \n Grup Adı: {group.GroupName}";

            //Hem label'da hem pop-up la gösterdim.
            lblResult.Text = message;
            await DisplayAlert("Tapped Event", message, "Tamam");
        }

        async void DisplayMovieDetails(object sender, EventArgs e)
        {
            var button = sender as Button;

            //Button'da saklı bir movie geliyor. Xaml tarafında button'a binding ile movie attık.
            var movie = button.CommandParameter as Movie;

            var detailsMessage = $"{movie.Description} \n\n Vizyon Tarihi: {movie.CreatedOn}";

            await DisplayAlert(movie.Name, detailsMessage, "Tamam");
        }

        async void Details_Click(object sender, EventArgs e)
        {
            /*
             * sender'da gelen Menu Item'i cast ediyorum.
             * Menu Item içerisinde ki command parameter'i da movie 'ye çeviriyorum.
             */

            var menuItem = sender as MenuItem;
            var movie = menuItem.CommandParameter as Movie;

            var detailsMessage = $"{movie.Description} \n\n Vizyon Tarihi: {movie.CreatedOn}";

            await DisplayAlert(movie.Name, detailsMessage, "Tamam");
        }

        void Deleted_Click(object sender, EventArgs e)
        {
            var selectedMovie = (sender as MenuItem).CommandParameter as Movie;

            foreach (var group in groupMovies)
            {
                if (group.Any(x => x.Id == selectedMovie.Id))
                {
                    group.Remove(selectedMovie);
                    break;
                }
            }
        }

        void ListViewRefreshing(object sender, EventArgs e)
        {
            Task.Delay(2000); //2 saniye bekletmek için.
            groupMovies[0].Add( new Movie
                                {  Id = 16, Name = "Güncelle ile gelen", 
                                   Director = "Updated", ImageUrl = "https://bit.ly/3brZOlH", 
                                   CreatedOn = DateTime.Now, Description = "Film açıklaması" }
                                );
            listView.IsRefreshing = false;
        }
    }
}