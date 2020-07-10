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
    public partial class ListViewMenu : ContentPage
    {
        public ListViewMenu()
        {
            InitializeComponent();

            itemList.ItemsSource = new ListViewMenuModel[]
            {
                new ListViewMenuModel(){Title="First",PageType=typeof(FirstPage)},
                new ListViewMenuModel(){Title="Second",PageType=typeof(SecondPage)},
                new ListViewMenuModel(){Title="Third",PageType=typeof(ThirdPage)}
            };
        }

        async void Handle_Tapped(object sender, ItemTappedEventArgs e)
        {
            var item = e.Item as ListViewMenuModel;

            if (item == null)
                return;

            Page page = Activator.CreateInstance(item.PageType) as Page;
            await Navigation.PushAsync(page);
        }
    }
}