using final.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace final.Controllers
{
    [Route("api/Product")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Product> GetProducts()
        {
            var products = new List<Product> {
                new Product { Id = 1, Name = "mobile" },
                new Product { Id=  2,Name="computer"}};


            return products;
        }
    }
} 