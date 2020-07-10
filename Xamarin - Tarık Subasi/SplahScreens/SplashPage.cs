using System.Threading.Tasks;
using Xamarin.Forms;

namespace FirstApplication.SplahScreens
{
    public class SplashPage : ContentPage
    {
        Image splashImage;
        public SplashPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            var sub = new AbsoluteLayout();
            splashImage = new Image
            {
                Source = ImageSource.FromFile("excelicon.png"),
                WidthRequest = 300,
                HeightRequest = 300
            };

            AbsoluteLayout.SetLayoutFlags(splashImage,
               AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(splashImage,
             new Rectangle(0.5, 0.5, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));

            sub.Children.Add(splashImage);

            //this.BackgroundColor = Color.FromHex("#429de3"0);
            this.BackgroundColor = Color.White;
            this.Content = sub;
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await Task.Delay(4000);

            NavigationPage navPage = new NavigationPage(new AfterSplashPage())
            {
                BarBackgroundColor = Color.FromHex("#003a67"),
                BarTextColor = Color.White

            };
            Application.Current.MainPage = navPage;
        }
    }
}
