using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinDataAccess.Models;

namespace XamarinDataAccess.Databases
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NotesPage : ContentPage
    {
        public NotesPage()
        {
            InitializeComponent();
        }

        //Sayfa yüklendiği zaman çalışacak method.
        protected override void OnAppearing()
        {
            base.OnAppearing();
           
            var notes = new List<Note>();

            //Dosyayı arama işlemi
            var files = Directory.EnumerateFiles(App.FolderPath, "*.notes.txt");

            foreach (var file in files)
            {
                notes.Add(new Note
                {
                    Filename = file,
                    Text = File.ReadAllText(file),
                    CreatedOn = File.GetCreationTime(file)
                });
            }

            notesList.ItemsSource = notes.OrderBy(x => x.CreatedOn).ToList();
        }

        async void OnNoteAddedClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DemoFileSystem()
            {
                BindingContext = new Note()
            });
        }

        async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var note = e.SelectedItem as Note;
            
            if (note == null)
                return;

            await Navigation.PushAsync(new DemoFileSystem { BindingContext = note });
        }
    }
}