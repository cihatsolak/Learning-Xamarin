using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Course.Kontroller
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CheckBoxControl : ContentPage
    {
        public CheckBoxControl()
        {
            InitializeComponent();
            PickerControl.ItemsSource = GetAllBrands();
        }

        List<string> GetAllBrands()
        {
            return new List<string>()
            {
               "Opel","Mazda","Hyundai","BMW","Mercedes","Peugeout"
           };
        }

        void StepperControl_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            StepperLabel.Text = $"{((int)e.NewValue)}";
        }

        void PickerControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = PickerControl.SelectedIndex;

            if (selectedIndex != -1)
            {
                lblBackEndResult.Text = $"Seçilen Marka: {PickerControl.Items[selectedIndex]}";
                lblBackEndResult.TextColor = Color.Green;
                lblBackEndResult.FontAttributes = FontAttributes.Bold;
            }
            else
            {
                lblBackEndResult.Text = "Lütfen marka seçiniz";
                lblBackEndResult.TextColor = Color.Red;
            }

        }
    }
}