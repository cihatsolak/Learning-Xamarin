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
    public partial class DatePickerControl : ContentPage
    {
        public DatePickerControl()
        {
            InitializeComponent();
        }

        void Handle_Date(object sender, DateChangedEventArgs e)
        {
            TimeSpan timeSpan = endDate.Date - startDate.Date;
            lblResult.Text = string.Format("İki tarih arasında ki gün {0}: {1}", timeSpan.Days == 1 ? string.Empty : "sayısı", timeSpan.Days);
        }
    }
}