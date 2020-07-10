using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinNavigations.Navigations
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ThirdPage : ContentPage
    {
        public ThirdPage()
        {
            InitializeComponent();
        }

        async void ReturnToSecondPage(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        async void ReturnToMainPage(object sender, EventArgs e)
        {   
            //Yığının ilk sayfasına, yani anasayfa ya gitmek için de diyebiliriz.
            await Navigation.PopToRootAsync();
        }
    }
}