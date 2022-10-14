using IdentityServer.API1.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace IdentityServer.API1.Controllers
{

    [Route("api/[controller]/[action]")]
    [ApiController]

    public class ProductsController : Controller
    {
        [Authorize(Policy = "ReadProduct")]
        [HttpGet]
        public IActionResult GetProducts()
        {
            var ProductList = new List<Product>()
            {
                new Product{Id=1,Name="Kalem",Stock=100,Price=10},
                new Product{Id=2,Name="Silgi",Stock=100,Price=5},
                new Product{Id=3,Name="Defter",Stock=100,Price=20},
                new Product{Id=4,Name="Kitap",Stock=100,Price=100}
            
            };
            return Ok(ProductList);
        }

        [Authorize(Policy= "UpdateorCreate")]
        public IActionResult UpdateProduct(int id)
        {
            return Ok($"id si {id} olan ürün güncellendi.");
        }

        [Authorize(Policy = "UpdateorCreate")]
        public IActionResult CreateProduct(Product product)
        {
            return Ok(product);
        }

        [Authorize(Policy = "DeleteProduct")]
        public IActionResult DeleteProduct(int id)
        {
            return Ok($"id si {id} olan ürün silindi.");
        }
    }
}
