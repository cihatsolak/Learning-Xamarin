using System;
using System.IO;
using Xamarin.Forms;
using XamarinDataAccess.Api;
using XamarinDataAccess.Databases;
using XamarinDataAccess.FileSystems;
using XamarinDataAccess.Models;
using XamarinDataAccess.SqlLiteDatabase;

namespace XamarinDataAccess
{
    public partial class App : Application
    {
        private const string ThemeKey = "Theme";
        private const string NotificationsKey = "Notifications";

        public static string FolderPath { get; private set; }

        private static NoteDatabase database;

        public static NoteDatabase Database
        {
            get
            {
                if (database == null)
                {
                    var dbPath = Path.Combine(App.FolderPath, "NotesDb.db3");
                    database = new NoteDatabase(dbPath);
                    return database;
                }

                return database;
            }
        }



        public string Theme
        {
            get
            {
                if (Properties.ContainsKey("Theme"))
                    return Properties[ThemeKey].ToString();

                return string.Empty;
            }
            set { Properties[ThemeKey] = value; }
        }
        public bool Notifications
        {
            get
            {
                if (Properties.ContainsKey("Notifications"))
                    return (bool)Properties[NotificationsKey];

                return false;
            }
            set { Properties[NotificationsKey] = value; }
        }


        public App()
        {
            InitializeComponent();

            FolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData));

            MainPage = new NavigationPage(new RestApi());
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
