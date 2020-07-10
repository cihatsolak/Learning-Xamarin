using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FirstApplication.CustomRenderers
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ButtonTestPage : ContentPage
    {
        public ButtonTestPage()
        {
            InitializeComponent();
        }
    }
}