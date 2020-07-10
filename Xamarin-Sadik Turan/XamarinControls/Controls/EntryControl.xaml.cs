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
    public partial class EntryControl : ContentPage
    {
        public EntryControl()
        {
            InitializeComponent();
        }

        void Handle_Text_Changed(object sender, TextChangedEventArgs e)
        {
            string newTextValue = e.NewTextValue;
            string oldTextValue = e.OldTextValue;

            resultLabel.Text = $"Önceki: {oldTextValue} Şimdiki: {newTextValue}";
        }

        private void Handle_Completed(object sender, EventArgs e)
        {
        }
    }
}