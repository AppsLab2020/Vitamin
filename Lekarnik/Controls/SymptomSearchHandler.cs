using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;
using Lekarnik.Models;


namespace Lekarnik.Controls
{
    class SymptomSearchHandler : SearchHandler
    {

        public IList<Symp> Nieco { get; set; }
        public Type SelectedItemNavigationTarget1 { get; set; }

        protected override void OnQueryChanged(string oldValue, string newValue)
        {
            base.OnQueryChanged(oldValue, newValue);

            if (string.IsNullOrWhiteSpace(newValue))
            {
                ItemsSource = null;
            }
            else
            {
                ItemsSource = Nieco
                    .Where(symp => symp.Nazov_Symptom.ToLower().Contains(newValue.ToLower()))
                    .ToList<Symp>();
            }
        }

        protected override async void OnItemSelected(object item)
        {
            base.OnItemSelected(item);
            await Task.Delay(1000);

            ShellNavigationState state = (App.Current.MainPage as Shell).CurrentState;
            await Shell.Current.GoToAsync($"{GetNavigationTarget()}?nazov_Symptom={((Symp)item).Nazov_Symptom}");
        }

        string GetNavigationTarget()
        {
            return (Shell.Current as AppShell).Routes.FirstOrDefault(route => route.Value.Equals(SelectedItemNavigationTarget1)).Key;
        }

    }
}
