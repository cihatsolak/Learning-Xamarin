using Course.DataAccess.ApplicationStorage;
using Xamarin.Forms;

namespace Course
{
    public partial class App : Application
    {
        const string ThemeKey = "Theme";
        const string NotificationKey = "Notifications";

        public string Theme
        {
            get
            {
                if (Application.Current.Properties.ContainsKey("Theme"))
                {
                    return Application.Current.Properties["Theme"].ToString();
                }

                return string.Empty;
            }
            set
            {
                Properties[ThemeKey] = value;
            }
        }
        public bool Notification
        {
            get
            {
                if (Application.Current.Properties.ContainsKey("Notifications"))
                {
                    return (bool)Application.Current.Properties["Notifications"];
                }

                return false;
            }
            set
            {
                Properties[NotificationKey] = value;
            }
        }


        public App()
        {
            InitializeComponent();

            MainPage = new AppProperties();
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
