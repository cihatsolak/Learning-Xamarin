
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinMvvm.ViewModels;

namespace XamarinMvvm.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SinglePreSelection : ContentPage
    {
        public SinglePreSelection()
        {
            InitializeComponent();
            BindingContext = new MovieViewModel();
        }
    }
}