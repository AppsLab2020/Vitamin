using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using Lekarnik.Data;
using Lekarnik.Views;
using Plugin.Messaging;

namespace Lekarnik
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        Random rand = new Random();
        Dictionary<string, Type> routes = new Dictionary<string, Type>();
        public Dictionary<string, Type> Routes { get { return routes; } }

        public ICommand HelpCommand => new Command<string>(async (url) => await Launcher.OpenAsync(url));
        public ICommand RandomPageCommand => new Command(async () => await NavigateToRandomPageAsync());
        public ICommand HelpCommand1 => new Command<string>(async (url) => await Launcher.OpenAsync(url));
        public ICommand RandomPageCommand1 => new Command(async () => await NavigateToRandomPageAsync1());
        public AppShell()
        {
            InitializeComponent();
            RegisterRoutes();
            BindingContext = this;
            RegisterRoutes1();
            BindingContext = this;

        }

        void RegisterRoutes()
        {
            routes.Add("vitaminydetails", typeof(VitaminyDetailed));

            foreach (var item in routes)
            {
                Routing.RegisterRoute(item.Key, item.Value);
            }
        }

        void RegisterRoutes1()
        {
            routes.Add("priznakydetails", typeof(PriznakyDetailed));

            foreach (var item in routes)
            {
                Routing.RegisterRoute(item.Key, item.Value);
            }
        }

        async Task NavigateToRandomPageAsync()
        {
            string destinationRoute = routes.ElementAt(rand.Next(0, routes.Count)).Key;
            string XXNazov = null;

            switch (destinationRoute)
            {
                case "vitaminydetails":
                    XXNazov = Zoznam.Zoznams.ElementAt(rand.Next(0, Zoznam.Zoznams.Count)).Nazov;
                    break;

               
            }

            ShellNavigationState state = Shell.Current.CurrentState;
            await Shell.Current.GoToAsync($"{state.Location}/{destinationRoute}?nazov={XXNazov}");
            Shell.Current.FlyoutIsPresented = false;
        }

        async Task NavigateToRandomPageAsync1()
        {
            string destinationRoute = routes.ElementAt(rand.Next(0, routes.Count)).Key;
            string XXNazov1 = null;

            switch (destinationRoute)
            {
                case "priznakydetails":
                    XXNazov1 = Symptom.Symps.ElementAt(rand.Next(0, Symptom.Symps.Count)).Nazov_Symptom;
                    break;


            }

            ShellNavigationState state = Shell.Current.CurrentState;
            await Shell.Current.GoToAsync($"{state.Location}/{destinationRoute}?nazov_Symptom={XXNazov1}");
            Shell.Current.FlyoutIsPresented = false;
        }
        private void EmailClick_Clicked(object sender, EventArgs e)
        {
            var emailMessenger = CrossMessaging.Current.EmailMessenger;
            if (emailMessenger.CanSendEmail)
            {
                emailMessenger.SendEmail("skuska@gmail.com", "Chyba aplikacie/navrh na vylepsenie", "");
            }
        }


    }
}
