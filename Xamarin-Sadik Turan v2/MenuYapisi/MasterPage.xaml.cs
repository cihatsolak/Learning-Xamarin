using Course.MenuYapisi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Course.MenuYapisi
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterPage : ContentPage
    {
        public MasterPage()
        {
            InitializeComponent();

            itemList.ItemsSource = new ListItem[]
            {
                new ListItem{Title="First",Description="First Description"},
                new ListItem{Title="Second",Description="Second Description"},
                new ListItem{Title="Third",Description="Third Description"},
            };
        }

        async void Handle_Tapped(object sender, ItemTappedEventArgs e)
        {
            var item = e.Item as ListItem;
            if (item == null)
                return;

            await Navigation.PushAsync(new DetailsPage(item));
            itemList.SelectedItem = null;
        }
    }
}