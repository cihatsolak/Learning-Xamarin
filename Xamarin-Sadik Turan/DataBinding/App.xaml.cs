using DataBinding.DataBindings;
using Xamarin.Forms;

namespace DataBinding
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AddContactPage();
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
