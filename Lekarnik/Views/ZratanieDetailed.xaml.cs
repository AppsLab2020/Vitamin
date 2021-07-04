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
    public partial class ZratanieDetailed : ContentPage
    {

        public string NameOfHodnota
        {
            set
            {
                BindingContext = Value.Values.FirstOrDefault(m => m.NameOfHodnota == Uri.UnescapeDataString(value));
            }
        }
        public ZratanieDetailed()
        {
            InitializeComponent();
        }
    }
}