
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinMvvm.ViewModels;

namespace XamarinMvvm.Views
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