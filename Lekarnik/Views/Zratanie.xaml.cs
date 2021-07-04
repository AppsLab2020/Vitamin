using Lekarnik.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lekarnik.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Zratanie : ContentPage
    {
        public Zratanie()
        {
            InitializeComponent();
        }
        async void OnCollectionViewSelectionChanged2(object sender, SelectionChangedEventArgs e)
        {
            var view = sender as CollectionView;

            if (view.SelectedItem != null)
            {
                string XNazov2 = (e.CurrentSelection.FirstOrDefault() as Hodnota).NameOfHodnota;
                await Shell.Current.GoToAsync($"hodnotadetails?nameOfHodnota={XNazov2}");
                view.SelectedItem = null;
            }
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