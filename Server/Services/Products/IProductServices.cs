using PwaProject2.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PwaProject2.Server.Services.Products
{
    public interface IProductServices
    {
        Task<List<Product>> GetAllProducts();
        void SaveProduct(Product product);
        void DeleteProduct(Product product);
        Product GetProduct(int? id);
    }
}
