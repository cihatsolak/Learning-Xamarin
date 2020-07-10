using FirstApplication.DependencyServices;
using FirstApplication.LocalizationYapısı;
using Xamarin.Forms;

namespace FirstApplication
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new LocalizationSamplePage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
