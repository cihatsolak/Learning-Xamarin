using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FirstApplication.IslevselNugetPackages.SampleCalendar
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CalendarSample : ContentPage
    {
        public CalendarSample()
        {
            InitializeComponent();
        }

        private void showDate_Clicked(object sender, EventArgs e)
        {
            lblDate.Text = calendar.SelectedDate.ToString();
        }
    }
}