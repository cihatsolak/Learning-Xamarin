using Course.ListYapilari;
using System.Collections.ObjectModel;

namespace Course.MVVM.ViewModels
{
    public class MovieViewModel
    {
        public ObservableCollection<Movie> Movies { get; set; }
        public Movie SelectedMovie { get; set; }
        public MovieViewModel()
        {
            Movies = new ObservableCollection<Movie>();
            var db = new FakeDatabase().Movies;
            db.ForEach(x => Movies.Add(x));

            SelectedMovie = Movies[2];
        }
    }
}
