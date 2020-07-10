using Course.DataBinding.Models;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Course.DataBinding
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DemoContactPage : ContentPage
    {
        public DemoContactPage()
        {
            InitializeComponent();
            BindingContext = new ContactViewModel
            {
                Name = "Cihat SOLAK",
                WebSite = "https://www.cihatsolak.com.tr",
                Favorite = true,
                Phone = "905061730339"
            };
        }
    }
}