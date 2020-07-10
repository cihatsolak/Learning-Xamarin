using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinDataAccess.Models;

namespace XamarinDataAccess.Databases
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NoteEntryDbPage : ContentPage
    {
        public NoteEntryDbPage()
        {
            InitializeComponent();
        }

        async void Handle_Save(object sender, EventArgs e)
        {
            var noteSqlModel = BindingContext as NoteSqlModel;
            noteSqlModel.Date = DateTime.Now;

            await App.Database.SaveNoteAsync(noteSqlModel);
            await Navigation.PopAsync();
        }

        async void Handle_Delete(object sender, EventArgs e)
        {
            var noteSqlModel = BindingContext as NoteSqlModel;
            await App.Database.DeleteNoteAsync(noteSqlModel);
            await Navigation.PopAsync();
        }
    }
}