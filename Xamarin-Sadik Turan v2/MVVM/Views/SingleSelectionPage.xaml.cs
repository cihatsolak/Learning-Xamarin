using Course.ListYapilari;
using Course.MVVM.ViewModels;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Course.MVVM.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SingleSelectionPage : ContentPage
    {
        public SingleSelectionPage()
        {
            InitializeComponent();

            BindingContext = new MovieViewModel();
        }

        private void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var currentName = e.CurrentSelection.FirstOrDefault() as Movie;
            var previousName = e.PreviousSelection.FirstOrDefault() as Movie;

            lblCurrent.Text = currentName?.Name;
            lblPrevious.Text = previousName?.Name;
        }
    }
}