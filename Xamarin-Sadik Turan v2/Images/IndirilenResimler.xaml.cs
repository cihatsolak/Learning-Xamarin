using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Course.Images
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IndirilenResimler : ContentPage
    {
        public IndirilenResimler()
        {
            InitializeComponent();
            lblSlider.SetBinding(Label.RotationProperty, new Binding("Value", source: SliderControl));
        }
    }
}