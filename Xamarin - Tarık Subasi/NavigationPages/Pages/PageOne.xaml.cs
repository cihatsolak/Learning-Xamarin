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
    public partial class PageOne : ContentPage
    {
        public PageOne()
        {
            InitializeComponent();
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PageTwo());
        }
    }
}