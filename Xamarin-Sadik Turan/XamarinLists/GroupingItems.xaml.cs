using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinLists.Models;

namespace XamarinLists
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GroupingItems : ContentPage
    {
        List<MovieGroup> movies = new List<MovieGroup>();
        public GroupingItems()
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
    }
}