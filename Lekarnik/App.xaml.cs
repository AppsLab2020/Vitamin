using Lekarnik.Controls;
using System;
using System.IO;
using Lekarnik.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lekarnik
{
    public partial class App : Application
    {
        static SQLiteHelper db;

        public static SQLiteHelper SQLiteDb
        {
            get
            {
                if (db == null)
                {
                    db = new SQLiteHelper(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "XamarinSQLite.db3"));
                }
                return db;
            }
        }
      
        public App()
        {
            InitializeComponent();
            Device.SetFlags(new []{"Brush_Experimental"});
            MainPage = new AppShell();
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
