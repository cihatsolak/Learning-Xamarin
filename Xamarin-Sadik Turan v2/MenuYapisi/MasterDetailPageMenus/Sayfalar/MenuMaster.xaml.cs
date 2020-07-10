using Course.MenuYapisi.HiyerarsikMenuSayfalari;
using Course.MenuYapisi.MasterDetailPageMenus.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Course.MenuYapisi.MasterDetailPageMenus.Sayfalar
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuMaster : ContentPage
    {
        public MenuMaster()
        {
            InitializeComponent();

            var listOfMenuItems = new List<MasterMenu>();

            listOfMenuItems.Add(new MasterMenu
            {
                Icon = "https://img.icons8.com/cotton/64/000000/restaurant-menu.png",
                PageType = typeof(FirstPage),
                Title = "First Page"
            });

            listOfMenuItems.Add(new MasterMenu
            {
                Icon = "https://img.icons8.com/cotton/64/000000/restaurant-menu.png",
                PageType = typeof(SecondPage),
                Title = "Second Page"
            });

            listOfMenuItems.Add(new MasterMenu
            {
                Icon = "https://img.icons8.com/cotton/64/000000/restaurant-menu.png",
                PageType = typeof(ThirdPage),
                Title = "Third Page"
            });

            listView.ItemsSource = listOfMenuItems;


            var account = new Account
            {
                Title = "Yazılım Uzmanı",
                Departmant = "Bilgi Sistemleri",
                Name = "Cihat SOLAK"
            };

            BindingContext = account;
        }

        async void Handle_MenuSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MasterMenu;
            var selectedPage = (Page)Activator.CreateInstance(item.PageType);
            //(new NavigationPage(selectedPage)
        }
    }
}