﻿using Xamarin.Forms;

namespace XamarinImages
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new LoadingScreen();
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
