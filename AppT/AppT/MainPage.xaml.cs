using System.Text.Json;
using Xamarin.Forms;

namespace AppT
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent(); 
        }

        protected override void OnAppearing() => ShowItems();

        private void ShowItems() => ItemCollection.ItemsSource = App.Catalog.shop.offers.offer;

        private async void ItemCollection_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var stringJson = JsonSerializer.Serialize(e.CurrentSelection); // json serilize
            await DisplayAlert("json", stringJson, "cloze");
        }
    }
    
}
