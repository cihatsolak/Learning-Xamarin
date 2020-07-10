using FirstApplication.DependencyServices.Helper;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FirstApplication.DependencyServices
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DependencyServicePage : ContentPage
    {
        public DependencyServicePage()
        {
            InitializeComponent();
        }

        private void KillMe_Clicked(object sender, EventArgs e)
        {
            var appCloser = DependencyService.Get<ICloseApplication>();
            appCloser.CloseApplication();
        }
    }
}