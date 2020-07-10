using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinDataAccess.Models;

namespace XamarinDataAccess.Api
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RestApi : ContentPage
    {
        const string apiUrl = "https://jsonplaceholder.typicode.com/posts";
        private HttpClient _client = new HttpClient();
        public RestApi()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            var result = await _client.GetStringAsync(apiUrl);
            listView.ItemsSource = JsonConvert.DeserializeObject<List<Post>>(result);
        }
    }
}