namespace Back_End.Models
{
    public class Cart
    {
        public List<CartItem> items;
        public Cart()
        {
            this.items = new List<CartItem>();
        }
    }

    public class CartItem
    {
        public Product product { get; set; }
        public int cantidad { get; set; }
        public int _newCantidad;


        public CartItem(Product product, int cantidad)
        {
            this.product = product;
            this.cantidad = cantidad;
            this._newCantidad = cantidad;
        }
    }
}