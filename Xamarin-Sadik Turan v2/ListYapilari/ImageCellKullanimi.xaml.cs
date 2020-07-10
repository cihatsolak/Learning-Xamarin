using Course.ListYapilari.ViewModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Course.ListYapilari
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ImageCellKullanimi : ContentPage
    {
        public ImageCellKullanimi()
        {
            InitializeComponent();
            BindingContext = new MovieViewModel();
        }
    }
}