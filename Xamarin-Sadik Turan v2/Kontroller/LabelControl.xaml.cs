using Course.Kontroller.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Course.Kontroller
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LabelControl : ContentPage
    {
        public LabelControl()
        {
            InitializeComponent();
            BindingContext = new LabelViewModel();
        }
    }
}