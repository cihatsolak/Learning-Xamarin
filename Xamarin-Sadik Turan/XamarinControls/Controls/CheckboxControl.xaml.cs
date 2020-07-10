
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinControls.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CheckboxControl : ContentPage
    {
        public CheckboxControl()
        {
            InitializeComponent();
        }

        void CheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            CheckedResult.Text = e.Value ? "Cheched" : "Not Checked";
        }
    }
}