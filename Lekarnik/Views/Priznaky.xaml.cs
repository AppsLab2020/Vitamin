using Lekarnik.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Lekarnik.Views
{
    
    public partial class Priznaky : ContentPage
    {
        public Priznaky()
        {
            InitializeComponent();
        }
        async void OnCollectionViewSelectionChanged1(object sender, SelectionChangedEventArgs e)
        {
            string elephantNazov1 = (e.CurrentSelection.FirstOrDefault() as Symp).Nazov_Symptom;
            await Shell.Current.GoToAsync($"priznakydetails?nazov_Symptom={elephantNazov1}");
        }
    }
}