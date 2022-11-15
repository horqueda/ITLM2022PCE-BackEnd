using back_end.repositories;
using Back_End.Models;

namespace Back_End.Repositories
{
    public class CartRepository
    {
        private static Cart _cart { get; set; }

        public static Cart GetCart()
        {
            return _cart;
        }
        public static void AddProductToCart(int idProduct, int cantidad)

        {
            try
            {
                if (_cart == null) _cart = new Cart();
                bool existe = false;

                foreach (var item in _cart.items)
                {
                    if (item.product.Id == idProduct)
                    {
                        existe = true;
                        item.cantidad = item.cantidad + cantidad;
                        break;
                    }
                }

                if (existe == false)
                {
                    ProductRepository repo = new ProductRepository();
                    List<Product> products = new List<Product>();
                    products = repo.GetProducts();
                    Product product = products.Find(prod => prod.Id == idProduct);
                    if (product != null)
                    {
                        _cart.items.Add(new CartItem(product, cantidad));
                    }
                    else
                    {
                        throw new Exception("Producto no encontrado");
                    }
                }

            }
            catch (Exception ex)
            {
                throw new Exception($"Error en el AddProductToCart{ex.Message}");
            }

        }
    }
}


//MiMetodo
//{
//    if (_cart == null) _cart = new Cart();
//    ProductRepository repo = new ProductRepository();
//    List<Product> products = new List<Product>();
//    products = repo.GetProducts();
//    Product product = products.Find(prod => prod.Id == idProduct);
//   if (product != null)
//    {
//        _cart.items.Add(new CartItem(product, cantidad));
//    }
//    else
//    {
//        throw new Exception("Producto no encontrado");
//    }
//}
//
//
//}
//}