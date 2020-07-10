using FirstApplication.Elements.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FirstApplication.Elements
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SampleElement : ContentPage
    {
        public SampleElement()
        {
            InitializeComponent();

            BindingContext = new PickerMVVMViewModel();
        }

        async void Handle_Show(object sender, EventArgs e)
        {
            var name = entryText.Text;

            if (string.IsNullOrEmpty(name))
                return;

            if (string.IsNullOrWhiteSpace(name))
                return;

            await DisplayAlert("Hoşgeldin", name, "Tamam");
        }

        async void Handle_Selected(object sender, EventArgs e)
        {
            string city = sender as string;
            await DisplayAlert("Şehirler", $"Seçilen Şehir: {city}", "Tamam");
        }
    }
}