using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lekarnik.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Tabulka : ContentPage
    {
        public Tabulka()
        {
            InitializeComponent();
        }
        
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            
            
            //Get All Persons
            var personList = await App.SQLiteDb.GetItemsAsync();
            if(personList!=null)
            {
                
                lstPersons.ItemsSource = personList;
            }
        }
    }
}