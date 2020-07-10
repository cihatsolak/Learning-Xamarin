
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DataBinding.DataBindings
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BasicBindings : ContentPage
    {
        public BasicBindings()
        {
            InitializeComponent();

            //Code-Behind ile label name'ine ait binding yapımı
            label.SetBinding(Label.RotationProperty, new Binding("Value", source: slider));
        }
    }
}