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

        public CartItem(Product product, int cantidad)
        {
            this.product = product;
            this.cantidad = cantidad;
        }
    }
}


//namespace Back_End.Models
//{
//    public class Cart
//    {
//        public List<CartItem> Items;
//        public Cart()
//        {
//            this.Items = new List<CartItem>(); // Las listas tienen que estar inicializadas. Para esto es este contructor.
//        }
//     }

//    public class CartItem
//    {
//        public Product Product { get; set; }
//        public int cantidad { get; set; }

//        public CartItem(Product product, int cantidad)
//        {
//            this.Product = new Product();
//            this.cantidad = 0;
//        }

//    }
//}
