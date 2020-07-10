
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Course.DataBinding
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BasicBindings : ContentPage
    {
        public BasicBindings()
        {
            InitializeComponent();
            lblSlider.SetBinding(Label.RotationProperty, new Binding("Value", source: SliderControl));
        }
    }
}