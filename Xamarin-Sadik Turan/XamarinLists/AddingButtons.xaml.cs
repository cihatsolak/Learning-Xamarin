using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinLists.Models;

namespace XamarinLists
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddingButtons : ContentPage
    {
        List<MovieGroup> movies = new List<MovieGroup>();

        public AddingButtons()
        {
            InitializeComponent();

            movies.Add(
              new MovieGroup("Komedi", "K") {
              new Movie{Id=1,Name="Hababam Sınıfı",Director="Lars Von Trier",ImageUrl="https://bit.ly/3brZOlH",CreatedOn=DateTime.Now, Description="Film açıklaması"},
              new Movie{Id=2,Name="Esaretin Bedeli",Director="Quentin Tarantino",ImageUrl="https://bit.ly/3brZOlH",CreatedOn=DateTime.Now.AddDays(-379), Description="Film açıklaması"},
              new Movie{Id=3,Name="Cep Herkülü: Naim Süleymanoğlu",Director="Andrei Tarkovsky",ImageUrl="https://bit.ly/3brZOlH",CreatedOn=DateTime.Now.AddDays(250), Description="Film açıklaması"},
              new Movie{Id=4,Name="Cesuryürek",Director="Jacques Tati",ImageUrl="https://bit.ly/3brZOlH",CreatedOn=DateTime.Now.AddDays(-679), Description="Film açıklaması"},
              new Movie{Id=5,Name="Yeşil Yol",Director="Bertrand Tavernier",ImageUrl="https://bit.ly/3brZOlH",CreatedOn=DateTime.Now.AddDays(23), Description="Film açıklaması"}}
            );

            movies.Add(
              new MovieGroup("Dram", "D") {
              new Movie{Id=1,Name="Hababam Sınıfı",Director="Lars Von Trier",ImageUrl="https://bit.ly/3brZOlH",CreatedOn=DateTime.Now, Description="Film açıklaması"},
              new Movie{Id=2,Name="Esaretin Bedeli",Director="Quentin Tarantino",ImageUrl="https://bit.ly/3brZOlH",CreatedOn=DateTime.Now.AddDays(-379), Description="Film açıklaması"},
              new Movie{Id=3,Name="Cep Herkülü: Naim Süleymanoğlu",Director="Andrei Tarkovsky",ImageUrl="https://bit.ly/3brZOlH",CreatedOn=DateTime.Now.AddDays(250), Description="Film açıklaması"},
              new Movie{Id=4,Name="Cesuryürek",Director="Jacques Tati",ImageUrl="https://bit.ly/3brZOlH",CreatedOn=DateTime.Now.AddDays(-679), Description="Film açıklaması"},
              new Movie{Id=5,Name="Yeşil Yol",Director="Bertrand Tavernier",ImageUrl="https://bit.ly/3brZOlH",CreatedOn=DateTime.Now.AddDays(23), Description="Film açıklaması"}}
            );

            movies.Add(
              new MovieGroup("Macera", "M") {
              new Movie{Id=1,Name="Hababam Sınıfı",Director="Lars Von Trier",ImageUrl="https://bit.ly/3brZOlH",CreatedOn=DateTime.Now, Description="Film açıklaması"},
              new Movie{Id=2,Name="Esaretin Bedeli",Director="Quentin Tarantino",ImageUrl="https://bit.ly/3brZOlH",CreatedOn=DateTime.Now.AddDays(-379), Description="Film açıklaması"},
              new Movie{Id=3,Name="Cep Herkülü: Naim Süleymanoğlu",Director="Andrei Tarkovsky",ImageUrl="https://bit.ly/3brZOlH",CreatedOn=DateTime.Now.AddDays(250), Description="Film açıklaması"},
              new Movie{Id=4,Name="Cesuryürek",Director="Jacques Tati",ImageUrl="https://bit.ly/3brZOlH",CreatedOn=DateTime.Now.AddDays(-679), Description="Film açıklaması"},
              new Movie{Id=5,Name="Yeşil Yol",Director="Bertrand Tavernier",ImageUrl="https://bit.ly/3brZOlH",CreatedOn=DateTime.Now.AddDays(23), Description="Film açıklaması"}}
            );

            movies.Add(
              new MovieGroup("Belgesel", "B") {
              new Movie{Id=1,Name="Hababam Sınıfı",Director="Lars Von Trier",ImageUrl="https://bit.ly/3brZOlH",CreatedOn=DateTime.Now, Description="Film açıklaması"},
              new Movie{Id=2,Name="Esaretin Bedeli",Director="Quentin Tarantino",ImageUrl="https://bit.ly/3brZOlH",CreatedOn=DateTime.Now.AddDays(-379), Description="Film açıklaması"},
              new Movie{Id=3,Name="Cep Herkülü: Naim Süleymanoğlu",Director="Andrei Tarkovsky",ImageUrl="https://bit.ly/3brZOlH",CreatedOn=DateTime.Now.AddDays(250), Description="Film açıklaması"},
              new Movie{Id=4,Name="Cesuryürek",Director="Jacques Tati",ImageUrl="https://bit.ly/3brZOlH",CreatedOn=DateTime.Now.AddDays(-679), Description="Film açıklaması"},
              new Movie{Id=5,Name="Yeşil Yol",Director="Bertrand Tavernier",ImageUrl="https://bit.ly/3brZOlH",CreatedOn=DateTime.Now.AddDays(23), Description="Film açıklaması"}}
            );

            listView.ItemsSource = movies;
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
    }
}