using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinControls.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TimePickerControl : ContentPage
    {
        DateTime _triggerTime;
        public TimePickerControl()
        {
            InitializeComponent();

            //1 dakika da 1 OnTimesTick() method'unu kontrol et.
            Device.StartTimer(TimeSpan.FromSeconds(1), OnTimesTick);
        }

        bool OnTimesTick()
        {
            //toggle açık ve seçilen zaman suan dan büyük ise
            if (_switch.IsToggled
                && DateTime.Now >= _triggerTime)
            {
                _switch.IsToggled = false;
                DisplayAlert("Alarm", _entry.Text, "Ah! Hatırladım.");
            }
            return true;
        }

        void SetTriggerTime()
        {
            if (_switch.IsToggled)
            {
                //Burada timespan döndüğü için timespan'a gün ekliyoruz ki ileri tarihli kuralım diye.
                _triggerTime = DateTime.Today + timePicker.Time;

                if (_triggerTime < DateTime.Now)
                {
                    _triggerTime += TimeSpan.FromDays(1);
                }
            }
        }
        void Handle_Changed(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == TimePicker.TimeProperty.PropertyName)
            {
                SetTriggerTime();
            }
        }

        void Handle_Switch(object sender, ToggledEventArgs e)
        {
            SetTriggerTime();
        }
    }
}