using Xamarin.Forms;
using XamarinNavigations.Navigations;

namespace XamarinNavigations
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new CarouselPageSample();
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
