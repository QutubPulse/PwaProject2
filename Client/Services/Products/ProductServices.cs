using PwaProject2.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace PwaProject2.Client.Services.Products
{
    public class ProductServices : IProductServices
    {
        private readonly HttpClient _http;
        //public List<Product> Products { get; set; } = new List<Product>();

        public event Action OnChange;
        public ProductServices(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<Product>> LoadProducts(string categoryUrl = null)
        {
            List<Product> loProducts = new List<Product>();
            loProducts = await _http.GetFromJsonAsync<List<Product>>("api/Product");
            return loProducts;
        }

        public async Task<Product> UpdateProduct(Product product)
        {
            var result = await _http.PostAsJsonAsync("api/Product", product);
            return await result.Content.ReadFromJsonAsync<Product>();
        }
        public async Task<Product> DeleteProduct(int id)
        {
            var result = await _http.DeleteAsync($"api/Product/Delete/{id}");
            return await result.Content.ReadFromJsonAsync<Product>();
        }
    }
}
