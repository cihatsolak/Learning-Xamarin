using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinNavigations.Models;

namespace XamarinNavigations.Navigations
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SecondPage : ContentPage
    {
        public SecondPage(CustomerModel customerModel)
        {
            InitializeComponent();
            BindingContext = customerModel;
        }

        async void GotoThirdPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ThirdPage());
        }

        async void ReturnToFirstPage(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}