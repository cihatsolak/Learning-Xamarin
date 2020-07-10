using System.ComponentModel;
using Xamarin.Forms;

namespace HelloWorld
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            FormSlider.Value = 0.5;
        }

        async void AfterPage_Clicked(object sender, System.EventArgs e)
        {
            //Yeni bir sayfaya gönderme.
            await Navigation.PushAsync(new NextPage());
        }
    }
}
