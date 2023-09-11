using System.Net.Http;
using System;
using System.Text.Json;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Linq;

namespace AppT
{
    public partial class MainPage : ContentPage
    {
        private readonly IHttpClientService _httpClientService;
        public MainPage(IHttpClientService httpClientService)
        {
            InitializeComponent();
            _httpClientService = httpClientService;
        }

        protected override async void OnAppearing()
        {
           base.OnAppearing();
           await OnDataLoaded();
        }

        private async Task OnDataLoaded()
        {
            var listId = await _httpClientService.LoadOffersIdAsync();
            if (listId is null)
            {
                await DisplayAlert("Ошибка", "Произошла ошибка при загрузке данных.", "OK");
                return;
            }
            ItemCollection.ItemsSource = listId;
        }

        private async void ItemCollection_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {            
            var item = await _httpClientService.LoadfferByIdAsync((int)e.CurrentSelection.First());           
            var stringJson = JsonSerializer.Serialize(item); // json serilize
            await DisplayAlert("json", stringJson, "Закрыть");
        }
    }
    
}
