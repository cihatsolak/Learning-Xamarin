using AcikAkadamiHaftaDort.Models;
using AcikAkadamiHaftaDort.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;

namespace AcikAkadamiHaftaDort.ViewModels
{
    public class NoteViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string text;
        private ICommand insertCommand, deleteCommand, insertPageCommand;
        private List<Note> notes;

        public List<Note> Notes
        {
            get
            {
                if (notes == null)
                    notes = new List<Note>();

                return notes;
            }
            private set
            {
                if (value != null)
                {
                    Notes = value;
                    OnPropertyChanged(nameof(Notes));
                }
            }
        }

        public ICommand InsertPageCommand
        {
            get
            {
                if (insertPageCommand == null)
                    insertPageCommand = new Command(NavInsertPage);

                return insertPageCommand;
            }
            private set
            {
                if (value != null)
                    insertPageCommand = value;
            }
        }
        public ICommand InsertCommand
        {
            get
            {
                if (insertCommand == null)
                    insertCommand = new Command(InsertNote);

                return insertCommand;
            }
            private set
            {
                if (value != null)
                    insertCommand = value;
            }
        }
        public ICommand DeleteCommand
        {
            get
            {
                if (deleteCommand == null)
                    deleteCommand = new Command(DeleteNote);

                return deleteCommand;
            }
            private set
            {
                if (value != null)
                    deleteCommand = value;
            }
        }
        public string Text
        {
            get { return text; }
            set
            {
                text = value;
                OnPropertyChanged(nameof(Text));
            }
        }

        public NoteViewModel()
        {
            BindData();
        }

        async void BindData()
        {
            Notes = await App.Database.GetNotesAsync();
        }

        async void NavInsertPage()
        {
            await App.Current.MainPage.Navigation.PushAsync(new NoteEntryPage());
        }

        async void InsertNote(object note)
        {
            Note _note = note as Note;
            _note.Date = DateTime.Now;
            await App.Database.SaveNoteAsync(_note);

        }
        async void DeleteNote(object note)
        {
            Note _note = note as Note;
            await App.Database.DeleteNoteAsync(_note);
        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
