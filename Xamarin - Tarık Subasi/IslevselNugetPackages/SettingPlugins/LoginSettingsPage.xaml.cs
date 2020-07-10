using Plugin.Connectivity;
using System;
using System.Net.Http.Headers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FirstApplication.IslevselNugetPackages.SettingPlugins
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginSettingsPage : ContentPage
    {
        public LoginSettingsPage()
        {
            InitializeComponent();

            Username.Text = Settings.GeneralSettings;
            Password.Text = Settings.GeneralSettingsPass;

            if (string.IsNullOrEmpty(Settings.GeneralSettingsRemember))
            {
                isRememberMe.IsToggled = false;
            }
            else
            {
                isRememberMe.IsToggled = bool.Parse(Settings.GeneralSettingsRemember);
            }
             
        }

        async void Login_Clicked(object sender, EventArgs e)
        {
            //internet bağlantısı var mı?
            if (CrossConnectivity.Current.IsConnected) //Nuget Package :  Xam.Plugin.Connectivity 
            {
                //Beni hatırla derse hafızaya username ve password ü atıyorum
                if (isRememberMe.IsToggled)
                {
                    Settings.GeneralSettings = Username.Text;
                    Settings.GeneralSettingsPass = Password.Text;
                    Settings.GeneralSettingsRemember = "true";
                }
                //Beni hatırla demezse hafızaya username ve password ü boş olarak atıyorum.
                else
                {
                    Settings.GeneralSettings = string.Empty;
                    Settings.GeneralSettingsPass = string.Empty;
                    Settings.GeneralSettingsRemember = "false";
                }

                await Navigation.PushAsync(new HomePage());
            }
            else
            {
                await DisplayAlert("Title", "İnternet bağlantınızı aktifleştiriniz", "Tamam");
            }
        }
    }
}