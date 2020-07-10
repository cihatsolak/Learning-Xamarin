
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinNavigations.Navigations
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CarouselPageSample : CarouselPage
    {
        public CarouselPageSample()
        {
            InitializeComponent();

            //Carousel page'in içine 10 adet content page eklicem.
            for (int i = 0; i < 10; i++)
            {
                var page = new ContentPage();
                page.Content = new Label() { Text = $"Page{i}", 
                                             HorizontalOptions = LayoutOptions.Center, 
                                             VerticalOptions = LayoutOptions.Center };

                this.Children.Add(page); //Carousel page içerisine for'un her dönmesinde content page ekliyoruz.
            }
        }
    }
}