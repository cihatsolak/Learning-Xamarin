using Course.MenuYapisi.Models;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Course.MenuYapisi
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailsPage : ContentPage
    {
        public DetailsPage(ListItem listItem)
        {
            InitializeComponent();
            BindingContext = listItem;
        }
    }
}