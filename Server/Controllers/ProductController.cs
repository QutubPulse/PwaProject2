using Microsoft.AspNetCore.Mvc;
using PwaProject2.Server.Services.Products;
using PwaProject2.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PwaProject2.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : Controller
    {
        private readonly IProductServices _productService;

        public ProductController(IProductServices productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetAllProducts()
        {
            return Ok(await _productService.GetAllProducts());
        }
        [HttpPost]
        public async Task<ActionResult<Product>> CreateNew(Product foProduct)
        { 
            _productService.SaveProduct(foProduct);
            return Json(new {data=foProduct });
        }
        [HttpDelete("Delete/{id}")]
        public async Task<ActionResult<Product>> DeleteProduct(int id)
        {
          Product product =   _productService.GetProduct(id);
            _productService.DeleteProduct(product);
            return Json(new { data = product });
        }

    }
}
