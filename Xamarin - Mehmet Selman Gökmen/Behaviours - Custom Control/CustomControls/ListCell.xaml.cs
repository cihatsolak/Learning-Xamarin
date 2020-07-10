using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2.CustomControls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListCell : ContentView
    {
        public static BindableProperty TitleProperty = BindableProperty.Create(
            propertyName: "Title",
            defaultValue: string.Empty,
            returnType: typeof(string),
            declaringType: typeof(ListCell),
            defaultBindingMode: BindingMode.TwoWay,
            propertyChanged: TitlePropertyChanged
            );

        public static BindableProperty DescriptionProperty = BindableProperty.Create(
           propertyName: "Description",
           defaultValue: string.Empty,
           returnType: typeof(string),
           declaringType: typeof(ListCell),
           defaultBindingMode: BindingMode.TwoWay,
           propertyChanged: DescriptionPropertyChanged
           );

        private static void DescriptionPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (ListCell)bindable;
            control.CarDescriptionLabel.Text = newValue.ToString();
        }

        public string Title
        {
            get
            {
                return GetValue(TitleProperty).ToString();
            }
            set
            {
                SetValue(TitleProperty, value);
            }
        }

        public string Description
        {
            get
            {
                return GetValue(DescriptionProperty).ToString();
            }
            set
            {
                SetValue(DescriptionProperty, value);
            }
        }

        private static void TitlePropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (ListCell)bindable;
            control.CarTitleLabel.Text = newValue.ToString();
        }

        public ListCell()
        {
            InitializeComponent();
        }
    }
}