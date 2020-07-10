using AcikAkademiApp.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace AcikAkademiApp.ViewModels
{
    public class PersonViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public IList<Person> Persons { get; set; }
        private Person person;

        public Person Person
        {
            get
            {
                return person;
            }
            set
            {
                if (person != value)
                {
                    person = value;
                    Handle_SelectedPerson();
                }

            }
        }

        public PersonViewModel()
        {
            Persons = new ObservableCollection<Person>()
            {
                new Person{Id=1,Name="Cihat"},
                new Person{Id=2,Name="Sevgi"},
                new Person{Id=3,Name="Yılmaz"}
            };
        }

        async void Handle_SelectedPerson()
        {
            if (Person == null)
                return;

            bool result = await App.Current.MainPage.DisplayAlert("Seçilen Kişi", Person.Name, "Sil", "Vazgeç");

            if (result)
            {
                Persons.Remove(Person);
                await App.Current.MainPage.DisplayAlert("Başarılı", $"{Person.Name} adlı kişi silindi.", "OK");
            }
            else
                await App.Current.MainPage.DisplayAlert("İptal Edidi.", $"{Person.Name} silinmedi.", "OK");
        }

        // Create the OnPropertyChanged method to raise the event
        // The calling member's name will be used as the parameter.
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
