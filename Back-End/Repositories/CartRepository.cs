using Back_End.Models;

namespace Back_End.Repositories
{
    public class CartRepository
    {
        private static Cart _cart  { get; set; }  // static es para que pueda persistir en memoria. 
        public static void AddProductToCart(int idProduct, int cantidad) { 
            if (_cart==null)_cart = new Cart();
            ProductRepository repo = new ProductRepository();
            List<Product> products = new List<Product>();
            products = repo.GetProducts();
            Product product = products.Find(Prod => Prod.Id == idProduct);
            if(product != null)
            {
                _cart.Items.Add(new CartItem(product, cantidad));
            }
            throw new Exception("Producto no encontrado"); 
        }
               
    }

}
