
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinMvvm.Models;
using XamarinMvvm.ViewModels;

namespace XamarinMvvm.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SingleSelectionPage : ContentPage
    {
        public SingleSelectionPage()
        {
            InitializeComponent();

            BindingContext = new MovieViewModel();
        }

        void Movies_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string previousSelectionMovieName = (e.PreviousSelection.FirstOrDefault() as Movie)?.Name;
            string currentSelectionMovieName = (e.CurrentSelection.FirstOrDefault() as Movie)?.Name;

            lblCurrent.Text = currentSelectionMovieName;
            lblPrevious.Text = previousSelectionMovieName;
        }
    }
}