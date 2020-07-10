using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinImages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoadingScreen : ContentPage
    {
        public LoadingScreen()
        {
            InitializeComponent();

            var imageSource = new UriImageSource
            {
                Uri = new Uri("https://images.pexels.com/photos/4171211/pexels-photo-4171211.jpeg"),
                CachingEnabled = false
            };

            image.Source = imageSource;
        }
    }
}