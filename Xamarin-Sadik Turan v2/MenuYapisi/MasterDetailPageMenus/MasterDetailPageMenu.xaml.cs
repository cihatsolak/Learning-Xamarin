using Course.MenuYapisi.HiyerarsikMenuSayfalari;
using Course.MenuYapisi.MasterDetailPageMenus.Models;
using Course.MenuYapisi.MasterDetailPageMenus.Sayfalar;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Course.MenuYapisi.MasterDetailPageMenus
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDetailPageMenu : MasterDetailPage
    {
        MenuMaster masterMenu;
        public MasterDetailPageMenu()
        {
            InitializeComponent();

            masterMenu = new MenuMaster();
            Master = masterMenu;           
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(FirstPage)));
            IsPresented = false;
        }
    }
}