using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinNavigations.Models;

namespace XamarinNavigations.Navigations
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterPage : ContentPage
    {
        public MasterPage()
        {
            InitializeComponent();

            itemList.ItemsSource = new ListItemModel[]{
                new ListItemModel{Title="First", Description="First Description"},
                new ListItemModel{Title="Second", Description="Second Description"},
                new ListItemModel{Title="Third", Description="Third Description"}
             };
        }

        async void SelectedMenuItem(object sender, SelectedItemChangedEventArgs e)
        {
            var listItemModel = e.SelectedItem as ListItemModel;

            if (listItemModel == null)
                return;

            await Navigation.PushAsync(new DetailsPage(listItemModel));
        }
    }
}