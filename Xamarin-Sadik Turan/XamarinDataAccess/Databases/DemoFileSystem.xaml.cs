using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinDataAccess.Models;

namespace XamarinDataAccess.Databases
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DemoFileSystem : ContentPage
    {
        public DemoFileSystem()
        {
            InitializeComponent();
        }

        async void Handle_Save(object sender, EventArgs e)
        {
            var note = (Note)BindingContext;

            if (string.IsNullOrWhiteSpace(note.Filename))
            {
                var fileName = Path.Combine(App.FolderPath, $"{Path.GetRandomFileName()}.notes.txt");
                File.WriteAllText(fileName, note.Text);
            }
            else
            {
                File.WriteAllText(note.Filename, note.Text);
            }

            await Navigation.PopAsync();
        }

        async void Handle_Delete(object sender, EventArgs e)
        {
            var note = (Note)BindingContext;

            if (File.Exists(note.Filename))
            {
                File.Delete(note.Filename);
            }

            await Navigation.PopAsync();
        }
    }
}