
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinImages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EmbeddedImages : ContentPage
    {
        public EmbeddedImages()
        {
            InitializeComponent();

            //image.Source = ImageSource.FromResource("XamarinImages.Images.background.jpg");
        }
    }
}