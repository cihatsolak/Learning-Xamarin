using Course.MenuYapisi.HiyerarsikMenuSayfalari;
using Course.MenuYapisi.Models;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Course.MenuYapisi.ListViewMenu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewMenu : ContentPage
    {
        public ListViewMenu()
        {
            InitializeComponent();

            itemList.ItemsSource = new ListItemPage[]
            {
                new ListItemPage{Title="First Page", PageType=typeof(FirstPage)},
                new ListItemPage{Title="Second Page", PageType=typeof(SecondPage)},
                new ListItemPage{Title="Third Page", PageType=typeof(ThirdPage)}
            };
        }

        async void Handle_Tapped(object sender, ItemTappedEventArgs e)
        {
            var item = e.Item as ListItemPage;
            var currentPage = (Page)Activator.CreateInstance(item.PageType);
            await Navigation.PushAsync(currentPage);
        }
    }
}