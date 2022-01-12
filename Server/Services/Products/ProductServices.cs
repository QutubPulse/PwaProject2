using Microsoft.EntityFrameworkCore;
using PwaProject2.Server.Data;
using PwaProject2.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PwaProject2.Server.Services.Products
{
    public class ProductServices : IProductServices
    {
        private ApplicationDbContext moApplicationDbContext;

        public ProductServices(ApplicationDbContext foProductDbContext)
        {
            moApplicationDbContext = foProductDbContext;
        }

        public void DeleteProduct(Product product)
        {
            moApplicationDbContext.Product.Remove(product);
            moApplicationDbContext.SaveChanges();
        }

        public async Task<List<Product>> GetAllProducts()
        {
            return await moApplicationDbContext.Product.ToListAsync();


        }

        public Product GetProduct(int? id)
        {
            Product loProduct = moApplicationDbContext.Product.FirstOrDefault(e=>e.inId==id);
            return loProduct;
        }

        public void SaveProduct(Product product)
        {
            if (product.inId == null)
            {
                moApplicationDbContext.Product.Add(product);
            }
            else
            {
                moApplicationDbContext.Product.Update(product);
            }
            moApplicationDbContext.SaveChanges();
        }
    }
}