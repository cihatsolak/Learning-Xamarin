using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FirstApplication.BehaviorValidations
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EntryBehaivorsPage : ContentPage
    {
        public EntryBehaivorsPage()
        {
            InitializeComponent();
            Random rnd = new Random();

            int firstNumber = rnd.Next(1, 11);
            int secondNumber = rnd.Next(1, 11);

            captchaLabel.Text = $"{firstNumber} + {secondNumber}";
        }
    }
}