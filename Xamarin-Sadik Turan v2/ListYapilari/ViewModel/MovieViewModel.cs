using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace Course.ListYapilari.ViewModel
{
    public class MovieViewModel : INotifyPropertyChanged
    {
        public List<Movie> _movies { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand ItemTappedCommand => new Command<Movie>(GetMovie);

        void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        private List<Movie> _selectedItem;

        public List<Movie> Movies
        {
            get { return _movies; }
            set
            {
                if (_movies != value)
                {
                    _movies = value;
                    OnPropertyChanged(nameof(Movies));
                }
            }
        }

        void GetMovie(Movie movie)
        {
            Application.Current.MainPage.DisplayAlert("Title", "Message", "Cancel");
        }


        public MovieViewModel()
        {
            Movies = new FakeDatabase().Movies;
        }
    }
}
