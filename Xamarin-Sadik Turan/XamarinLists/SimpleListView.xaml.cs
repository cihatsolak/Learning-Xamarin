
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinLists
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SimpleListView : ContentPage
    {
        public SimpleListView()
        {
            InitializeComponent();

            //simpleListView.ItemsSource = new string[]
            //{
            //    "Item 1",
            //    "Item 2",
            //    "Item 3"
            //};

            headerAndFooterExample.ItemsSource = new string[]
            {
                "Item 1",
                "Item 2",
                "Item 3"
            };
        }
    }
}