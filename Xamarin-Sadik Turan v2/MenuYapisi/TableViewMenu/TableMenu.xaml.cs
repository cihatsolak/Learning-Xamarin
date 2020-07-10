using Course.MenuYapisi.Models;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Course.MenuYapisi.TableViewMenu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TableMenu : ContentPage
    {
        public TableMenu()
        {
            InitializeComponent();
            var tableMenu = new List<TableMenuItem>();
            tableMenu.Add(new TableMenuItem()
            {
                Title = "Anasayfalar",
                Items = new List<Models.MenuItem>
                {
                    new Models.MenuItem{MenuName="First Page", MenuDescription="First Page Description"},
                    new Models.MenuItem{MenuName="Second Page", MenuDescription="Second Page Description"},
                    new Models.MenuItem{MenuName="Third Page", MenuDescription="Third Page Description"},
                }
            });

            BindingContext = tableMenu;
        }
    }
}