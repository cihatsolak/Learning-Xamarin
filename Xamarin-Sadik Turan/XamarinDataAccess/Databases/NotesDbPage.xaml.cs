
using System.Runtime.CompilerServices;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinDataAccess.Models;

namespace XamarinDataAccess.Databases
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NotesDbPage : ContentPage
    {
        public NotesDbPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            notesList.ItemsSource = await App.Database.GetNotesAsync();
            base.OnAppearing();
        }

        async void OnNoteAddedClicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new NoteEntryDbPage()
            {
                BindingContext = new NoteSqlModel()
            });
        }

        async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var note = e.SelectedItem as Note;

            if (note == null)
                return;

            await Navigation.PushAsync(new NoteEntryDbPage { BindingContext = note });
        }
    }
}