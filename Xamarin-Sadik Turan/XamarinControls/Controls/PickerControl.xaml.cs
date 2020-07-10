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
    public partial class PickerControl : ContentPage
    {
        public PickerControl()
        {
            InitializeComponent();

            //Select inputunu kod tarafından doldurma.
            LoadModels();
        }

        private void Handle_Selected(object sender, EventArgs e)
        {
            int selectedIndex = CarModelCodeBehind.SelectedIndex;

            if (selectedIndex != -1)
                lblResult.Text = $"Model: {CarModelCodeBehind.Items[selectedIndex]} Item Id: {selectedIndex}";
            else
                lblResult.Text = "Lütfen model seçiniz";
        }

        void LoadModels()
        {
            string[] carModels = { "Opel", "Peugeot", "Mazda", "Mercedes", "Hyundai" };

            foreach (var model in carModels)
            {
                CarModelCodeBehind.Items.Add(model);
            }
        }
    }
}