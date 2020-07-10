
using Course.ListYapilari.Model;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Course.ListYapilari
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GrupListesiKullanimi : ContentPage
    {
        public List<MovieGrup> movies;

        public GrupListesiKullanimi()
        {
            InitializeComponent();

            movies = new List<MovieGrup>();

            movies.Add(new MovieGrup("Macere", "Araba Yarış Filmleri")
            {
                new Movie(){Id=1, Name="Hızlı ve Öfkeli 9", ImageUrl="https://lh3.googleusercontent.com/proxy/WtsK2MSKWmpiMtjirqwCskkDDCxxE9qxDcdXty88CX2ghkyvL8K2LgBAApHqoNmv1HmX4Na6xwqWwI7BNpJXE09v4S8F45hkIYAm9AF9Nzx7ibGvOg156O_Ca0gPrr9Ne4rqLYU", Director="Justin Lin"},
                new Movie(){Id=1, Name="Hızlı ve Öfkeli 9", ImageUrl="https://bit.ly/2ZhlkY0", Director="Justin Lin"},
                new Movie(){Id=1, Name="Hızlı ve Öfkeli 9", ImageUrl="https://bit.ly/2ZhlkY0", Director="Justin Lin"},
                new Movie(){Id=1, Name="Hızlı ve Öfkeli 9", ImageUrl="https://bit.ly/2ZhlkY0", Director="Justin Lin"}
            });

            movies.Add(new MovieGrup("Macere", "Araba Yarış Filmleri")
            {
                new Movie(){Id=1, Name="Hızlı ve Öfkeli 9", ImageUrl="https://bit.ly/2ZhlkY0", Director="Justin Lin"},
                new Movie(){Id=1, Name="Hızlı ve Öfkeli 9", ImageUrl="https://bit.ly/2ZhlkY0", Director="Justin Lin"},
                new Movie(){Id=1, Name="Hızlı ve Öfkeli 9", ImageUrl="https://bit.ly/2ZhlkY0", Director="Justin Lin"},
                new Movie(){Id=1, Name="Hızlı ve Öfkeli 9", ImageUrl="https://bit.ly/2ZhlkY0", Director="Justin Lin"}
            });

            movies.Add(new MovieGrup("Macere", "Araba Yarış Filmleri")
            {
                new Movie(){Id=1, Name="Hızlı ve Öfkeli 9", ImageUrl="https://bit.ly/2ZhlkY0", Director="Justin Lin"},
                new Movie(){Id=1, Name="Hızlı ve Öfkeli 9", ImageUrl="https://bit.ly/2ZhlkY0", Director="Justin Lin"},
                new Movie(){Id=1, Name="Hızlı ve Öfkeli 9", ImageUrl="https://bit.ly/2ZhlkY0", Director="Justin Lin"},
                new Movie(){Id=1, Name="Hızlı ve Öfkeli 9", ImageUrl="https://bit.ly/2ZhlkY0", Director="Justin Lin"}
            });

            listView.ItemsSource = movies;
        }

        async void TappedItem(object sender, ItemTappedEventArgs e)
        {
            var movie = e.Item as Movie;

            await DisplayAlert(movie.Director, movie.Name, "Item Tapped");
        }

        async void SelectedItem(object sender, SelectedItemChangedEventArgs e)
        {
            var movie = e.SelectedItem as Movie;
            await DisplayAlert(movie.Director, movie.Name, "Item Selected");
        }
    }
}