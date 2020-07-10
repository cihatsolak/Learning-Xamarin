
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ResourcesAndStyles
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StaticResources : ContentPage
    {
        public StaticResources()
        {
            InitializeComponent();

            Subject.Text = (string)Application.Current.Resources["SubjectPlaceHolder"];
            Subject.TextColor = (Color)Application.Current.Resources["PlaceHolderColor"];
        }

        private void HandleSubject(object sender, FocusEventArgs e)
        {
            string placeHolderText = (string)Application.Current.Resources["SubjectPlaceHolder"];

            if (string.Equals(Subject.Text, placeHolderText))
            {
                Subject.Text = string.Empty;
                Subject.TextColor = (Color)Application.Current.Resources["InputTextColor"];
                return;
            }

            if (Subject.Text == string.Empty)
            {
                Subject.Text = placeHolderText;
                Subject.TextColor = (Color)Application.Current.Resources["PlaceHolderColor"];
                return;
            }
        }
    }
}