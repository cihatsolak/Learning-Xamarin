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
    public partial class StepperControl : ContentPage
    {
        public StepperControl()
        {
            InitializeComponent();
        }

        private void Handle_Changed(object sender, ValueChangedEventArgs e)
        {
            StepperCodeBehindControl.Text = $"{e.NewValue}";
        }
    }
}