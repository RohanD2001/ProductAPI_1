using ProductAPI.Models;
using System.Net.Http.Json;

namespace ProductAPI.Policies;

    public class ProductService
    {
        private readonly HttpClient _httpClient;

        public ProductService(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient("MyClient");
        }

        public async Task<IEnumerable<Product>> GetProductsAsync()
        {
            var response = await _httpClient.GetAsync("https://api.example.com/products");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsAsync<IEnumerable<Product>>();
        }
    }


