using AcikAkademiApp.Models;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AcikAkademiApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ConferenceDetailView : ContentPage
    {
        public ConferenceDetailView(Conference conference)
        {
            InitializeComponent();
            Title.Text = conference.Title;
            Description.Text = conference.Description;
            PublishDate.Text = conference.PublishDate.ToShortDateString();
            Image.Source = conference.Image;
        }
    }
}