using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinCollectionView.CollectionViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SimpleCollectionView : ContentPage
    {
        public SimpleCollectionView()
        {
            InitializeComponent();

            products.ItemsSource = new string[]
            {
                "Iphone 5",
                "Iphone 6",
                "Iphone 7",
                "Iphone 8",
                "Iphone 9"
            };
        }
    }
}