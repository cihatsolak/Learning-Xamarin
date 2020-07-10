
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WeatherApp : ContentPage
    {
        public WeatherApp()
        {
            InitializeComponent();
        }
    }
}