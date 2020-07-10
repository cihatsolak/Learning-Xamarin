
using Course.MVVM.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Course.MVVM.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MovieList : ContentPage
    {
        public MovieList()
        {
            InitializeComponent();
            BindingContext = new MovieViewModel();
        }
    }
}