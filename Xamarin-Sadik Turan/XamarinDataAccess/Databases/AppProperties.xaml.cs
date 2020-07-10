using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinDataAccess.Databases
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppProperties : ContentPage
    {
        public AppProperties()
        {
            InitializeComponent();

            var app = Application.Current as App;

            app.Theme = theme.Text;
            app.Notifications = notification.On;
        }

        void OnChanged(object sender, System.EventArgs e)
        {
            var app = Application.Current as App;

            app.Theme = theme.Text;
            app.Notifications = notification.On;
        }

        //İlgili xaml sayfası kapatıldığı anda, ilgili sayfadan farklı bir sayfaya geçtiğimiz anda.
        protected override void OnDisappearing()
        {
            base.OnDisappearing();
        }
    }
}