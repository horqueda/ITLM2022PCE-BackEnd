using Back_End.Models;
using Microsoft.AspNetCore.Mvc;

namespace Back_End.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        [HttpGet("GetErrorExample")]
        public IActionResult GetErrorExample()
        {
            try
            {
                Product product = new Product(1, "fshbsfbnh", 100, false);
                product.SetNewPrice(50);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok();
        }
        [HttpGet("GetProductsHome")]
        public ActionResult GetProductsHome()
        {
            List<Product> products = new List<Product>();
            try
            {
                products = GetProducts();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok(products);
        }

        [HttpGet("GetProductsByCategory")]
        public IActionResult GetProductsByCategory(int idCategory)
        {
            List<Product> products = new List<Product>();
            List<Product> productsByCategory = new List<Product>();
            try
            {
                products = GetProducts();
                foreach (var product in products)
                {
                    if (product.category.idCategory == idCategory)
                    {
                        productsByCategory.Add(product);
                    }
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok(productsByCategory);
        }
        [HttpGet("GetProductsByDestacados")]
        public IActionResult GetProductsByDestacados(int idCategory)
        {
            List<Product> productsDestacados= new List<Product>();
            List<Product> productstmp = new List<Product>();
            try
            {
                productstmp = GetProducts();
                foreach (var product in productstmp)
                {
                    if (product.Destacado) productsDestacados.Add(product);
                }
            }

            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok(productsDestacados);
        }

        private List<Product> GetProducts()
        {
            List<Product> products = new List<Product>();

            Product product1 = new Product(1, "Producto 1", 3000, false);
            product1.Description = "Remera basica blanca";
            product1.category = new Category(1, "Remeras");
            products.Add(product1);

            Product product2 = new Product(2, "Producto 2", 500, true);
            product2.Description = "Buzo canguro con capucha";
            product2.category = new Category(2, "Buzos");
            products.Add(product2);

            Product product3 = new Product(3, "Producto 3", 1000, false);
            product3.Size = "XXXL";
            products.Add(product3);

            Product product4 = new Product(2, "Producto 4", 1000, true);
            product4.Description = "Buzo canguro con capucha 4 ";
            product4.category = new Category(2, "Buzos");
            products.Add(product4);

            Product product5 = new Product(1, "Producto 5", 1000, false);
            product5.Description = "Remera basica blanca 5";
            product5.category = new Category(1, "Remeras");
            products.Add(product5);

            return products;
        }
    }
}
