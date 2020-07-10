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
    public partial class MasterDetailPageMenu : MasterDetailPage
    {
        List<MasterDetailItem> menuList;
        public MasterDetailPageMenu()
        {
            InitializeComponent();
            
            menuList = new List<MasterDetailItem>();
            
            menuList.Add(new MasterDetailItem
            {
                Title = "First Page",
                Icon = "https://img.icons8.com/ios/50/000000/plus.png",
                PageType = typeof(FirstPage)
            });

            menuList.Add(new MasterDetailItem
            {
                Title = "Second Page",
                Icon = "https://img.icons8.com/ios/50/000000/plus.png",
                PageType = typeof(SecondPage)
            });

            menuList.Add(new MasterDetailItem
            {
                Title = "Third Page",
                Icon = "https://img.icons8.com/ios/50/000000/plus.png",
                PageType = typeof(ThirdPage)
            });

            listView.ItemsSource = menuList;

            var page = Activator.CreateInstance(typeof(FirstPage)) as Page;
            Detail = new NavigationPage(page);
        }

        async void Handle_Selected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MasterDetailItem; // Hangi liste elemanına bastı?

            if (item == null)
                return;

            var page = Activator.CreateInstance(item.PageType) as Page; //liste elemanını page'e çevir.
            Detail = new NavigationPage(page);
            IsPresented = false; //Master detail görüntüsü oluşturabilmek için
        }
    }
}