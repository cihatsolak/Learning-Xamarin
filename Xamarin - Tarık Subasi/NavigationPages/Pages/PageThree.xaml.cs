using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FirstApplication.NavigationPages.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageThree : ContentPage
    {
        public PageThree()
        {
            InitializeComponent();
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Uyarı", "3. Sayfadan bildirim aldın. \n 2. sayfaya gönderiyorum seni", "Yönlendir.");
            await Navigation.PopAsync();
        }

        async void Main_Return(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }
    }
}