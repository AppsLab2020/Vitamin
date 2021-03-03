using Lekarnik.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace Lekarnik.Views
{
    [QueryProperty("Nazov_Symptom", "nazov_Symptom")]
    public partial class PriznakyDetailed : ContentPage
    {

        public string Nazov_Symptom
        {
            set
            {
                BindingContext = Symptom.Symps.FirstOrDefault(m => m.Nazov_Symptom == Uri.UnescapeDataString(value));
            }
        }
        public PriznakyDetailed()
        {
            InitializeComponent();
        }
    }
}