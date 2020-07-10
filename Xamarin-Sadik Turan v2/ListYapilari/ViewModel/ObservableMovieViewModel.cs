using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace Course.ListYapilari.ViewModel
{
    public class ObservableMovieViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public ObservableCollection<Movie> Movies { get; set; }
        public Movie MovieModel;

        [Obsolete]
        public ICommand AddCommand => new Command<Movie>(AddMovie);

        [Obsolete]
        public ICommand DeleteCommand => new Command<int>(DeleteMovie);

        public ObservableMovieViewModel()
        {
            Movies = GetAllMovies();
            MovieModel = new Movie();
        }

        ObservableCollection<Movie> GetAllMovies()
        {
            var observableCollectionMovie = new ObservableCollection<Movie>();

            new FakeDatabase().Movies.ForEach(x => observableCollectionMovie.Add(x));

            return observableCollectionMovie;
        }

        [Obsolete]
        void AddMovie(Movie movie)
        {
            if (movie == null)
                return;

            Movies.Add(movie);
        }

        [Obsolete]
        void DeleteMovie(int id)
        {
            if (id == 0)
                return;

            Movies.RemoveAt(id);
        }
    }
}
