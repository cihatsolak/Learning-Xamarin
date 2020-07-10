using System;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinMvvm.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public ICommand NavigateCommand { get; private set; }
        public MainPage()
        {
            InitializeComponent();

            NavigateCommand = new Command<Type>(
            async (Type pageType) =>
            {
                Page page = Activator.CreateInstance(pageType) as Page;
                await Navigation.PushAsync(page);
            });

            BindingContext = this;
        }
    }
}