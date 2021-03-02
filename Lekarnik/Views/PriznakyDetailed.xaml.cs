using Lekarnik.Data;
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