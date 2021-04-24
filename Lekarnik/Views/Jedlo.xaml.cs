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
    public partial class Jedlo : ContentPage
    {
        public Jedlo()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            collectionView.ItemsSource = await App.Database.GetPeopleAsync();
        }

        async void OnButtonClicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(nameEntry.Text) && !string.IsNullOrWhiteSpace(pieceEntry.Text))
            {
                await App.Database.SavePersonAsync(new Models.Food
                {
                    Name = nameEntry.Text,
                    Piece = int.Parse(pieceEntry.Text)
                });

                nameEntry.Text = pieceEntry.Text = string.Empty;
                collectionView.ItemsSource = await App.Database.GetPeopleAsync();
            }
        }
    }
}