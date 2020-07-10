
using Course.ListYapilari.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Course.ListYapilari
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ObservableData : ContentPage
    {
        public ObservableData()
        {
            InitializeComponent();
            BindingContext = new ObservableMovieViewModel();
        }
    }
}