
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Course.DataAccess.ApplicationStorage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppProperties : ContentPage
    {
        public AppProperties()
        {
            InitializeComponent();

            var app = Application.Current as App;
            BindingContext = app;
        }

        void OnChanged(object sender, EventArgs e)
        {
            var app = Application.Current as App;
            app.Theme = theme.Text;
            app.Notification = notifications.On;
        }
    }
}