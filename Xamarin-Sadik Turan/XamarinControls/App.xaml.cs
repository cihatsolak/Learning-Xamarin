using Xamarin.Forms;
using XamarinControls.Controls;

namespace XamarinControls
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new TableViewControl();
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
