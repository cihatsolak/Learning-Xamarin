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
    public partial class ViewCells : ContentPage
    {
        public ViewCells()
        {
            InitializeComponent();

            var movies = new List<Movie>()
            {
                new Movie{Id=1,Name="Hababam Sınıfı",Director="Lars Von Trier",ImageUrl="https://bit.ly/2YTkpg8",CreatedOn=DateTime.Now},
                new Movie{Id=2,Name="Esaretin Bedeli",Director="Quentin Tarantino",ImageUrl="https://bit.ly/2WlLOFP",CreatedOn=DateTime.Now.AddDays(-379)},
                new Movie{Id=3,Name="Cep Herkülü: Naim Süleymanoğlu",Director="Andrei Tarkovsky",ImageUrl="https://bit.ly/2WOMHWH",CreatedOn=DateTime.Now.AddDays(250)},
                new Movie{Id=4,Name="Cesuryürek",Director="Jacques Tati",ImageUrl="https://bit.ly/2LljAEV",CreatedOn=DateTime.Now.AddDays(-679)},
                new Movie{Id=5,Name="Yeşil Yol",Director="Bertrand Tavernier",ImageUrl="https://bit.ly/2SYivHA",CreatedOn=DateTime.Now.AddDays(23)}
            };

            movieList.ItemsSource = movies;
        }
    }
}