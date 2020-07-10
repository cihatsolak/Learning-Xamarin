using Xamarin.Forms;
using XamarinDataBinding.Views;

namespace XamarinDataBinding
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new CustomerMainPage();
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
