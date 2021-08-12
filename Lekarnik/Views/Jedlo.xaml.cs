using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lekarnik.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lekarnik.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Jedlo : ContentPage
    {
        public Jedlo()
        {
            InitializeComponent();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();

            //Get All Persons
            var personList = await App.SQLiteDb.GetItemsAsync();
            if (personList != null)
            {
                lstPersons.ItemsSource = personList;
            }
        }
        private async void BtnAdd_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtName.Text) && !string.IsNullOrWhiteSpace(pieceEntry.Text))
            {
                Person person = new Person()
                {
                    Name = txtName.Text,
                    Piece = int.Parse(pieceEntry.Text) 
                };

                //Add New Person
                await App.SQLiteDb.SaveItemAsync(person);
                txtName.Text = pieceEntry.Text = string.Empty;
                await DisplayAlert("Success", "Person added Successfully", "OK");
                //Get All Persons
                var personList = await App.SQLiteDb.GetItemsAsync();
                if (personList != null)
                {
                    lstPersons.ItemsSource = personList;
                }
            }
            else
            {
                await DisplayAlert("Required", "Please Enter name!", "OK");
            }
        }

        

        private async void BtnDelete_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPersonId.Text))
            {
                //Get Person
                var person = await App.SQLiteDb.GetItemAsync(Convert.ToInt32(txtPersonId.Text));
                if (person != null)
                {
                    //Delete Person
                    await App.SQLiteDb.DeleteItemAsync(person);
                    txtPersonId.Text = string.Empty;
                    await DisplayAlert("Success", "Person Deleted", "OK");

                    //Get All Persons
                    var personList = await App.SQLiteDb.GetItemsAsync();
                    if (personList != null)
                    {
                        lstPersons.ItemsSource = personList;
                    }
                }
            }
            else
            {
                await DisplayAlert("Required", "Please Enter PersonID", "OK");
            }
        }
    }
}