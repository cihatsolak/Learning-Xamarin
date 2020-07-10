using DataBinding.Models;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DataBinding.DataBindings
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NotifyPropertyChanged : ContentPage
    {
        public NotifyPropertyChanged()
        {
            InitializeComponent();

            /*
             * ListView'ımız ile ürünleri listelediğimizi düşünelim, Örneğin ürün ismi değiştiği anda,
             * aynı anda xaml üzerinde kullanıcılara yansıtmamıza yarar.
             * 
             * Örneğin benim ürünümde bir fiyat güncellemesi oldu ise, benim güncellenen ürün fiyatını
             * data binding ile bildiriyor olmam lazım.
             */

            //Binding'i xaml'da da yapabiliriz.
            //BindingContext = new NotifyViewModel();
        }
    }
}