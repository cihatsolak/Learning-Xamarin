using Rg.Plugins.Popup.Extensions;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FirstApplication.IslevselNugetPackages.PopUpPlugins
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SampePopUpRootPage : ContentPage
    {
        public SampePopUpRootPage()
        {
            InitializeComponent();
        }

        async void PopUp_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushPopupAsync(new PopUpRealPage());
        }
    }
}