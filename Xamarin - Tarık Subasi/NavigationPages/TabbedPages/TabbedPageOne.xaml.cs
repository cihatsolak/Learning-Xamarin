using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FirstApplication.NavigationPages.TabbedPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabbedPageOne : ContentPage
    {
        public TabbedPageOne()
        {
            InitializeComponent();
        }
    }
}