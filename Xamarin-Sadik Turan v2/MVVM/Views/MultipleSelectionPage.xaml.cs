
using Course.DataBinding.Models;
using Course.ListYapilari;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Course.MVVM.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MultipleSelectionPage : ContentPage
    {
        public MultipleSelectionPage()
        {
            InitializeComponent();
            BindingContext = new Course.MVVM.ViewModels.MovieViewModel();
        }

        private void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var currentNames = e.CurrentSelection;
            var previousNames = e.PreviousSelection;

            lblCurrent.Text = string.Empty;
            lblPrevious.Text = string.Empty;

            foreach (var name in currentNames)
                lblCurrent.Text += $"{(name as Movie)?.Name} ";

            foreach (var name in previousNames)
                lblPrevious.Text += $"{(name as Movie)?.Name} ";
        }
    }
}