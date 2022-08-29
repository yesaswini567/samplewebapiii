using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WebApplication122.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public List<MockProduct> GetProductList()
        {
            List<MockProduct> mockProducts = new List<MockProduct>();
            MockProduct mp = new MockProduct();
            mp.ID = 1;
            mp.ProductName = "Product1";
            mockProducts.Add(mp);
            return mockProducts;
        }

        [HttpPost]
        public IActionResult UpdateProductList([FromBody] MockProduct mockProduct)
        {
            //Do Logic
            return Ok();

        }
    }
    public class MockProduct
    {
        public int ID { get; set; }
        public string ProductName { get; set; }
    }
}
