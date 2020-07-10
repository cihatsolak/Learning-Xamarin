using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinNavigations.Navigations
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TableViewMenu : ContentPage
    {
        public TableViewMenu()
        {
            InitializeComponent();
        }

        async void navigateToPage(object sender, EventArgs e)
        {
            string pageName = (sender as TextCell).CommandParameter as string;

            Type pageType = Type.GetType($"XamarinNavigations.Navigations.{pageName},XamarinNavigations");

            var createdPage = (Page)Activator.CreateInstance(pageType);

            await Navigation.PushAsync(createdPage);
        }
    }
}