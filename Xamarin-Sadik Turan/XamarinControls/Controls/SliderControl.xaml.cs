using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinControls.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SliderControl : ContentPage
    {
        public SliderControl()
        {
            InitializeComponent();
        }

        private void SliderValue(object sender, ValueChangedEventArgs e)
        {
            SliderValueChange.Text = $"{(int)e.NewValue}";
        }
    }
}