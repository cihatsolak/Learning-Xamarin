
using DataBinding.Models;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DataBinding.DataBindings
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddContactPage : ContentPage
    {
        ContactViewModel contactViewModel;
        public AddContactPage()
        {
            InitializeComponent();

            /*
             * Burada BindingContext bilgisine ister dolu bir model veririrz (varsayılan bir değer görmek istiyoruzdur belki),
             * istersek de boş bir model veririz.
             */
            contactViewModel = new ContactViewModel
            {
                Name = "Cihat SOLAK",
                Favorite = true,
                Phone = 905061730339,
                WebSite = "cihatsolak.com"
            };

            BindingContext = contactViewModel;
        }
    }
}