
using Course.DataBinding.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Course.DataBinding
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class INotifyPropertyChangedPage : ContentPage
    {
        public INotifyPropertyChangedPage()
        {
            InitializeComponent();
            BindingContext = new MovieViewModel();
        }
    }
}