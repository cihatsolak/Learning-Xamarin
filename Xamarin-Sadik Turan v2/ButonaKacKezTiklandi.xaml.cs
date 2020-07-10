using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Course
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ButonaKacKezTiklandi : ContentPage
    {
        public ButonaKacKezTiklandi()
        {
            InitializeComponent();

            Content = new Label
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                Text="Hello Code-Behid Label"
            };
        }
    }
}