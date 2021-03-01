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
            string elephantNazov = (e.CurrentSelection.FirstOrDefault() as Vita).Nazov;
            await Shell.Current.GoToAsync($"vitaminydetails?nazov={elephantNazov}");
        }
    }
}