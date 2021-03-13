using System.Linq;
using Xamarin.Forms;
using Lekarnik.Models;

namespace Lekarnik.Views
{
    public partial class Vitaminy : ContentPage
    {
        public Vitaminy()
        {
            InitializeComponent();
        }

        async void OnCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string XNazov = (e.CurrentSelection.FirstOrDefault() as Vita).Nazov;
            await Shell.Current.GoToAsync($"vitaminydetails?nazov={XNazov}");
        }
        protected override bool OnBackButtonPressed()
        {
            Device.BeginInvokeOnMainThread(async () =>

            {
                var exit = await this.DisplayAlert("Potvrdiť ukončenie", "Naozaj chcete ukončiť aplikáciu?", "Áno", "Nie").ConfigureAwait(false);
                if (exit)
                    System.Diagnostics.Process.GetCurrentProcess().CloseMainWindow();
            });
            return true;
        }
    }
}