using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using Lekarnik.Data;
using Lekarnik.Views;

namespace Lekarnik
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        Random rand = new Random();
        Dictionary<string, Type> routes = new Dictionary<string, Type>();
        public Dictionary<string, Type> Routes { get { return routes; } }

        public ICommand HelpCommand => new Command<string>(async (url) => await Launcher.OpenAsync(url));
        public ICommand RandomPageCommand => new Command(async () => await NavigateToRandomPageAsync());
        public AppShell()
        {
            InitializeComponent();
            RegisterRoutes();
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
            string animalNazov = null;

            switch (destinationRoute)
            {
                case "vitaminydetails":
                    animalNazov = Zoznam.Zoznams.ElementAt(rand.Next(0, Zoznam.Zoznams.Count)).Nazov;
                    break;

                case "priznakydetails":
                    animalNazov = Symptom.Symps.ElementAt(rand.Next(0, Symptom.Symps.Count)).Nazov_Symptom;
                    break;
            }

            ShellNavigationState state = Shell.Current.CurrentState;
            await Shell.Current.GoToAsync($"{state.Location}/{destinationRoute}?nazov={animalNazov}");
            Shell.Current.FlyoutIsPresented = false;
        }
    }
}
