using FirstApplication.NavigationPages.Pages;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FirstApplication.NavigationPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SampleNavigationPage : ContentPage
    {
        public SampleNavigationPage()
        {
            InitializeComponent();
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PageOne());
        }
    }
}