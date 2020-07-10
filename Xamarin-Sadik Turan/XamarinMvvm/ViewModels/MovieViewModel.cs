using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinMvvm.Models;

namespace XamarinMvvm.ViewModels
{
    public class MovieViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public ICommand MovieSelectionChangedCommand => new Command(MovieSelectionChanged);

        public ObservableCollection<object> SelectedMovies { get; set; }
        public ObservableCollection<Movie> Movies { get; set; }
        public Movie SelectedMovie { get; set; }
        public string SelectedMovieName { get; set; }

        public MovieViewModel()
        {
            Movies = FakeDatabase();
            SelectedMovie = Movies[2];
            MovieSelectionChanged();

            SelectedMovies = new ObservableCollection<object>
            {
                Movies[0], Movies[1]
            };
        }

        ObservableCollection<Movie> FakeDatabase()
        {
            var movies = new ObservableCollection<Movie>();

            movies.Add(new Movie
            {
                Id = 1,
                Name = "Hababam Sınıfı",
                Description = "Öğrencilik hayatları haylazlık ve tembellik üzerine kurulu olan bir sınıf dolusu matrak öğrencinin, " +
                                "Özel Çamlıca Lisesi’nde yaşadığı yer yer",
                Director = "Ertem Eğilmez",
                ImageUrl = "http://tr.web.img3.acsta.net/cx_120_160/b_1_d6d6d6/pictures/bzp/01/186607.jpg",
                Rating = 5.2
            });

            movies.Add(new Movie
            {
                Id = 2,
                Name = "Forrest Gump",
                Description = "Forrest Gump, düşük I.Q. sahibi genç bir adamdır. Jenny ile tanıştığında ona aşık olur. " +
                               "Gump aralarında Elvis Presley, Kennedy, Nixon’ın da olduğu",
                Director = "Robert Zemeckis",
                ImageUrl = "http://tr.web.img1.acsta.net/cx_120_160/b_1_d6d6d6/pictures/bzp/01/10568.jpg",
                Rating = 3.6
            });

            movies.Add(new Movie
            {
                Id = 3,
                Name = "Geleceğe Dönüş",
                Description = "Geleceğe Dönüş'te, deli dolu bilimadamı Dr. Brown zamanda yolculuğu mümkün kılan bir araba geliştirir. " +
                              "Bu makineyi ilk kullanan genç Marty ufak bir",
                Director = "Robert Zemeckis",
                ImageUrl = "http://tr.web.img3.acsta.net/cx_120_160/b_1_d6d6d6/pictures/bzp/01/448.jpg",
                Rating = 8.2
            });

            movies.Add(new Movie
            {
                Id = 4,
                Name = "Hababam Sınıfı Uyanıyor",
                Description = "Haylazlığına tam gaz devam eden Hababam Sınıfı, çok sevilen serinin bu filminde de pek farklı davranmıyor. Sınıflarına gelen yeni öğrenci Ahmet",
                Director = "Ertem Eğilmez",
                ImageUrl = "http://tr.web.img1.acsta.net/cx_120_160/b_1_d6d6d6/medias/nmedia/18/80/47/86/19548076.jpg",
                Rating = 6.8
            });

            movies.Add(new Movie
            {
                Id = 5,
                Name = "Sevginin Gücü",
                Description = "Sevginin Gücü, masum bir kız ve bir katilin hikayesini anlatıyor. Onların birbirlerinden başka kaybedecek hiçbir şeyleri yok. Erkek duygusuzca",
                Director = "Luc Besson",
                ImageUrl = "http://tr.web.img1.acsta.net/cx_120_160/b_1_d6d6d6/medias/nmedia/18/80/20/26/19544797.jpg",
                Rating = 9.5
            });

            return movies;
        }

        void MovieSelectionChanged()
        {
            SelectedMovieName = $"Seçilen Film: {SelectedMovie.Name}";
            OnPropertyChanged("SelectedMovieName");
        }

        void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
