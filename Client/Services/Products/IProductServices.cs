using PwaProject2.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PwaProject2.Client.Services.Products
{
    public interface IProductServices
    {
        event Action OnChange;
        Task<List<Product>> LoadProducts(string categoryUrl = null);
        Task<Product> UpdateProduct(Product product);
        Task<Product> DeleteProduct(int id);
    }
}
