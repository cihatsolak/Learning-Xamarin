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
    public partial class FirstPage : ContentPage
    {
        public FirstPage()
        {
            InitializeComponent();
        }

        async void GotoSecondPage(object sender, EventArgs e)
        {
            // Sayfalar arası model taşıma işlemi

            var customerModel = new CustomerModel
            {
                Name = "Cihat",
                Surname = "Solak",
                Age = 25
            };

            await Navigation.PushAsync(new SecondPage(customerModel));
        }
    }
}