
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinMvvm.Models;
using XamarinMvvm.ViewModels;

namespace XamarinMvvm.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MultipleSelectionPage : ContentPage
    {
        public MultipleSelectionPage()
        {
            InitializeComponent();
            BindingContext = new MovieViewModel();
        }

        void Movies_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var previosSelectionList = e.PreviousSelection;
            var currentSelectionList = e.CurrentSelection;

            foreach (var movie in previosSelectionList)
                lblPrevious.Text += $"{(movie as Movie)?.Name} ";

            foreach (var movie in currentSelectionList)
                lblCurrent.Text += $"{(movie as Movie)?.Name} ";
        }
    }
}