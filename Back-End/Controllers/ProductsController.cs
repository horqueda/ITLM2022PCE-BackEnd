using Back_End.Models;
using Microsoft.AspNetCore.Mvc;
using Back_End.Repositories;

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
                ProductRepository repo = new ProductRepository();
                products = repo.GetProducts();
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
                ProductRepository repo = new ProductRepository();
                products = repo.GetProducts();
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
        public IActionResult GetProductsByDestacados()
        {
            List<Product> productsDestacados = new List<Product>();
            List<Product> productsAux = new List<Product>();
            try
            {
                ProductRepository repo = new ProductRepository();
                productsAux = repo.GetProducts();
                foreach (var product in productsAux)
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

        [HttpGet("GetProductsByDestacadosForEach")]
        public IActionResult GetProductsByDestacadosForEach()
        {
            List<Product> productsDestacados = new List<Product>();
            try
            {
                ProductRepository repo = new ProductRepository();
                foreach (var product in repo.GetProducts()) { if (product.Destacado) productsDestacados.Add(product); }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok(productsDestacados);
        }
        [HttpGet("GetProductsByDestacadosFindAll")]
        public IActionResult GetProductsByDestacadosFindAll()
        {
            try
            {
                ProductRepository repo = new ProductRepository();
                return Ok(repo.GetProducts().FindAll(product => product.Destacado));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("AddProductToCart")] //Crear
        public IActionResult AddProductToCart(int idProducto, int cantidad)
        {
            try
            {
                CartRepository.AddProductToCart(idProducto, cantidad);
                return Ok("El producto se agrego con exito");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetCart")]
        public IActionResult GetCart()
        {
            try
            {
                return Ok(CartRepository.GetCart().items);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }


    }
}
//using Back_End.Models;
//using Microsoft.AspNetCore.Mvc;
//using Back_End.Repositories;

//namespace Back_End.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class ProductsController : ControllerBase
//    {

//        [HttpGet("GetErrorExample")]
//        public IActionResult GetErrorExample()
//        {
//            try
//            {
//                Product product = new Product(1, "fshbsfbnh", 100, false);
//                product.SetNewPrice(50);
//            }
//            catch (Exception ex)
//            {
//                return BadRequest(ex.Message);
//            }
//            return Ok();
//        }
//        [HttpGet("GetProductsHome")]
//        public ActionResult GetProductsHome()
//        {
//            List<Product> products = new List<Product>();
//            try
//            {
//                ProductRepository repo = new ProductRepository();
//                products = repo.GetProducts();
//            }
//            catch (Exception ex)
//            {
//                return BadRequest(ex.Message);
//            }
//            return Ok(products);
//        }

//        [HttpGet("GetProductsByCategory")]
//        public IActionResult GetProductsByCategory(int idCategory)
//        {
//            List<Product> products = new List<Product>();
//            List<Product> productsByCategory = new List<Product>();
//            try
//            {
//                List<Product> productsByCategory = new List<Product>()
//                products = repo.GetProducts();
//                foreach (var product in products)
//                {
//                    if (product.category.idCategory == idCategory)
//                    {
//                        productsByCategory.Add(product);
//                    }
//                }
//            }
//            catch (Exception ex)
//            {
//                return BadRequest(ex.Message);
//            }
//            return Ok(productsByCategory);
//        }
//        [HttpGet("GetProductsByDestacados")]
//        public IActionResult GetProductsByDestacados()
//        {
//            List<Product> productsDestacados = new List<Product>();
//            List<Product> productstmp = new List<Product>();
//            try
//            {
//                ProductRepository repo = new ProductRepository();
//                productstmp = repo.GetProducts();
//                foreach (var product in productstmp)
//                {
//                    if (product.Destacado == true) productsDestacados.Add(product);
//                }


//            catch (Exception ex)
//            {
//                return BadRequest(ex.Message);
//            }
//        }

//        [HttpPost("AddProductToCar")] //CREAR

//        public IActionResult AddProductToCart(int idProducto, int cantidad )
//        {
//            CartRepository.AddProductToCart(idProducto, cantidad);
//            return Ok();
//        }

//    }
//}