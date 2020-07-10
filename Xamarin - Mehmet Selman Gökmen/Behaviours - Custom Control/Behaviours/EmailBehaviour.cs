using System.Text.RegularExpressions;
using Xamarin.Forms;

namespace App2.Behaviours
{
    public class EmailBehaviour : Behavior<Entry>
    {
        public static BindableProperty IsValidProperty = BindableProperty.Create(
            propertyName: "IsValid",
            defaultValue: false,
            returnType: typeof(bool),
            declaringType: typeof(EmailBehaviour),
            defaultBindingMode: BindingMode.OneWay);

        public static BindableProperty IsEmailAlertProperty = BindableProperty.Create(
            propertyName: "IsEmailAlert",
            defaultValue: false,
            returnType: typeof(bool),
            declaringType: typeof(EmailBehaviour),
            defaultBindingMode: BindingMode.OneWay);

        public bool IsValid
        {
            get
            {
                return (bool)GetValue(IsValidProperty);
            }
            set
            {
                SetValue(IsValidProperty, value);
            }
        }

        public bool IsEmailAlert
        {
            get
            {
                return (bool)GetValue(IsEmailAlertProperty);
            }
            set
            {
                SetValue(IsEmailAlertProperty, value);
            }
        }

        private const string emailRegex = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
        protected override void OnAttachedTo(Entry entry)
        {
            entry.TextChanged += OnEntryTextChanged;
            base.OnAttachedTo(entry);
        }

        protected override void OnDetachingFrom(Entry entry)
        {
            entry.TextChanged += OnEntryTextChanged;
            base.OnDetachingFrom(entry);
        }

        //Asıl Olay
        private void OnEntryTextChanged(object sender, TextChangedEventArgs args)
        {
            IsValid = Regex.IsMatch(args.NewTextValue, emailRegex);

            if (IsValid)
            {
                ((Entry)sender).TextColor = Xamarin.Forms.Color.Default;
            }
            else
            {
                ((Entry)sender).TextColor = Xamarin.Forms.Color.Red;
            }

            if (args.NewTextValue.Length > 0)
            {
                IsEmailAlert = IsValid ? false : true;
            }
            else
            {
                IsEmailAlert = false;
            }
        }
    }
}
