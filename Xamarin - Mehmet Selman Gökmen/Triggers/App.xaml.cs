using UdemyCourse.Views;
using Xamarin.Forms;

namespace UdemyCourse
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ResourcePage();
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
