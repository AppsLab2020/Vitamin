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
