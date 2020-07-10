using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinLists.Models;

namespace XamarinLists
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewEvents : ContentPage
    {
        List<MovieGroup> movies = new List<MovieGroup>();
        public ListViewEvents()
        {
            InitializeComponent();

            movies.Add(
              new MovieGroup("Komedi", "K") {
              new Movie{Id=1,Name="Hababam Sınıfı",Director="Lars Von Trier",ImageUrl="https://bit.ly/3brZOlH",CreatedOn=DateTime.Now},
              new Movie{Id=2,Name="Esaretin Bedeli",Director="Quentin Tarantino",ImageUrl="https://bit.ly/3brZOlH",CreatedOn=DateTime.Now.AddDays(-379)},
              new Movie{Id=3,Name="Cep Herkülü: Naim Süleymanoğlu",Director="Andrei Tarkovsky",ImageUrl="https://bit.ly/3brZOlH",CreatedOn=DateTime.Now.AddDays(250)},
              new Movie{Id=4,Name="Cesuryürek",Director="Jacques Tati",ImageUrl="https://bit.ly/3brZOlH",CreatedOn=DateTime.Now.AddDays(-679)},
              new Movie{Id=5,Name="Yeşil Yol",Director="Bertrand Tavernier",ImageUrl="https://bit.ly/3brZOlH",CreatedOn=DateTime.Now.AddDays(23)}}
            );

            movies.Add(
              new MovieGroup("Dram", "D") {
              new Movie{Id=1,Name="Hababam Sınıfı",Director="Lars Von Trier",ImageUrl="https://bit.ly/3brZOlH",CreatedOn=DateTime.Now},
              new Movie{Id=2,Name="Esaretin Bedeli",Director="Quentin Tarantino",ImageUrl="https://bit.ly/3brZOlH",CreatedOn=DateTime.Now.AddDays(-379)},
              new Movie{Id=3,Name="Cep Herkülü: Naim Süleymanoğlu",Director="Andrei Tarkovsky",ImageUrl="https://bit.ly/3brZOlH",CreatedOn=DateTime.Now.AddDays(250)},
              new Movie{Id=4,Name="Cesuryürek",Director="Jacques Tati",ImageUrl="https://bit.ly/3brZOlH",CreatedOn=DateTime.Now.AddDays(-679)},
              new Movie{Id=5,Name="Yeşil Yol",Director="Bertrand Tavernier",ImageUrl="https://bit.ly/3brZOlH",CreatedOn=DateTime.Now.AddDays(23)}}
            );

            movies.Add(
              new MovieGroup("Macera", "M") {
              new Movie{Id=1,Name="Hababam Sınıfı",Director="Lars Von Trier",ImageUrl="https://bit.ly/3brZOlH",CreatedOn=DateTime.Now},
              new Movie{Id=2,Name="Esaretin Bedeli",Director="Quentin Tarantino",ImageUrl="https://bit.ly/3brZOlH",CreatedOn=DateTime.Now.AddDays(-379)},
              new Movie{Id=3,Name="Cep Herkülü: Naim Süleymanoğlu",Director="Andrei Tarkovsky",ImageUrl="https://bit.ly/3brZOlH",CreatedOn=DateTime.Now.AddDays(250)},
              new Movie{Id=4,Name="Cesuryürek",Director="Jacques Tati",ImageUrl="https://bit.ly/3brZOlH",CreatedOn=DateTime.Now.AddDays(-679)},
              new Movie{Id=5,Name="Yeşil Yol",Director="Bertrand Tavernier",ImageUrl="https://bit.ly/3brZOlH",CreatedOn=DateTime.Now.AddDays(23)}}
            );

            movies.Add(
              new MovieGroup("Belgesel", "B") {
              new Movie{Id=1,Name="Hababam Sınıfı",Director="Lars Von Trier",ImageUrl="https://bit.ly/3brZOlH",CreatedOn=DateTime.Now},
              new Movie{Id=2,Name="Esaretin Bedeli",Director="Quentin Tarantino",ImageUrl="https://bit.ly/3brZOlH",CreatedOn=DateTime.Now.AddDays(-379)},
              new Movie{Id=3,Name="Cep Herkülü: Naim Süleymanoğlu",Director="Andrei Tarkovsky",ImageUrl="https://bit.ly/3brZOlH",CreatedOn=DateTime.Now.AddDays(250)},
              new Movie{Id=4,Name="Cesuryürek",Director="Jacques Tati",ImageUrl="https://bit.ly/3brZOlH",CreatedOn=DateTime.Now.AddDays(-679)},
              new Movie{Id=5,Name="Yeşil Yol",Director="Bertrand Tavernier",ImageUrl="https://bit.ly/3brZOlH",CreatedOn=DateTime.Now.AddDays(23)}}
            );

            listView.ItemsSource = movies;
        }

        //Tapped ın hemen ardından çalışır.
        async void ListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var movie = e.SelectedItem as Movie;
            int movieIndex = e.SelectedItemIndex;

            var message = $"Seçilen Film \n Id: {movieIndex} \n Ad: {movie.Name}";
            await DisplayAlert("Selected Event", message, "Tamam");
        }

        //İlk Tıklandığında
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
    }
}