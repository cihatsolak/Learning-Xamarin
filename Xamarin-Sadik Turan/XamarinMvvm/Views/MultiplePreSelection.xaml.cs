
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinMvvm.ViewModels;

namespace XamarinMvvm.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MultiplePreSelection : ContentPage
    {
        public MultiplePreSelection()
        {
            InitializeComponent();
            BindingContext = new MovieViewModel();
        }
    }
}