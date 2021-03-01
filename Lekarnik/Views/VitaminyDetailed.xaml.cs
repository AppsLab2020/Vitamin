using System;
using System.Linq;
using Xamarin.Forms;
using Lekarnik.Data;

namespace Lekarnik.Views
{
    [QueryProperty("Nazov", "nazov")]
    public partial class VitaminyDetailed : ContentPage
    {
        public string Nazov
        {
            set
            {
                BindingContext = Zoznam.Zoznams.FirstOrDefault(m => m.Nazov == Uri.UnescapeDataString(value));
            }
        }

        public VitaminyDetailed()
        {
            InitializeComponent();
        }
    }
}