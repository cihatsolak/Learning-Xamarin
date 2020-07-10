using Course.ListYapilari.ViewModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Course.ListYapilari
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class İlkListeUygulamasi : ContentPage
    {
        public İlkListeUygulamasi()
        {
            InitializeComponent();
            BindingContext = new CityViewModel();
        }
    }
}