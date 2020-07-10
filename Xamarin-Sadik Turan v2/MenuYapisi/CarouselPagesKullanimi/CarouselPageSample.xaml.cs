
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Course.MenuYapisi.CarouselPagesKullanimi
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CarouselPageSample : CarouselPage
    {
        public CarouselPageSample()
        {
            InitializeComponent();

            ContentPage _contentPage = null;

            for (int i = 1; i < 6; i++)
            {
                _contentPage = new ContentPage();
                _contentPage.Content = new Label()
                {
                    Text = $"Sayfa {i}",
                    VerticalOptions = LayoutOptions.Center,
                    HorizontalOptions = LayoutOptions.Center
                };
                this.Children.Add(_contentPage);
            }
        }
    }
}