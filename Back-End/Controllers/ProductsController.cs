using Back_End.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Back_End.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpGet("GetProductsHome")]
        public ActionResult GetProductsHome()
        {
            List<Product> products = new List<Product>();

            Product product1 = new Product(1, "Producto 1");
            product1.Description = "Camiseta Seleccion Argentina";
            product1.Price = 20000;
            product1.Category = new Category(1, "Camiseta");
            products.Add(product1);
            
            Product product2 = new Product(2, "Producto 2");
            product2.Description = " Short Seleccion Brasil";
            product2.Category = new Category(2, "Short");
            products.Add(product2);
            

            Product product3 = new Product(3, "Producto 3");
            product3.Size = "XL";
            products.Add(product3); 
            
            return Ok(products);
        }
        [HttpGet("GetProductsByCategory")]
        
        public IActionResult GetProductsByCategory(string idCategory){
            return Ok();
        }
    }

}
