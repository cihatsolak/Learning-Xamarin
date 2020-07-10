using Plugin.ExternalMaps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FirstApplication.IslevselNugetPackages.ExternalMaps
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NavigasyonPages : ContentPage
    {
        public NavigasyonPages()
        {
            InitializeComponent();

            
        }

        private void navigateLatLong(object sender, EventArgs e)
        {
            CrossExternalMaps.Current.NavigateTo("Space Needle", 47.6204, -122.3491);
        }

        private void navigateAddress(object sender, EventArgs e)
        {
            CrossExternalMaps.Current.NavigateTo("Xamarin", "394 pacific ave.", "San Francisco", "CA", "94111", "USA", "USA");
        }
    }
}