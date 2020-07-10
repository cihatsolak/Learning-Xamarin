using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Course
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SliderControl : ContentPage
    {
        public SliderControl()
        {
            InitializeComponent();

           
        }

        void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            
        }
    }
}