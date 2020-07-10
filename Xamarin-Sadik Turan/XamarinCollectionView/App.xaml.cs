using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinCollectionView.CollectionViews;

namespace XamarinCollectionView
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new DataBindingCollectionView();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
