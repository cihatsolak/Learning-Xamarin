
using ImageCircle.Forms.Plugin.Abstractions;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FirstApplication.IslevselNugetPackages.ImageCircle
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ImageCirclePage : ContentPage
    {
        Image Image;
        public ImageCirclePage()
        {
            InitializeComponent();

            Image = new CircleImage
            {
                BorderColor = Color.White,
                BorderThickness = 3,
                HeightRequest = 150,
                WidthRequest = 150,
                Aspect = Aspect.AspectFill,
                HorizontalOptions = LayoutOptions.Center,
                Source = UriImageSource.FromUri(new Uri("http://upload.wikimedia.org/wikipedia/commons/5/55/Tamarin_portrait.JPG"))
            };

        }
    }
}