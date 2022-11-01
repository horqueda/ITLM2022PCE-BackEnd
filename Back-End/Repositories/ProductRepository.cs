using Back_End.Models;

namespace back_end.repositories
{
    public class ProductRepository
    {
        public List<Product> GetProducts()
        {
            List<Product> products = new List<product>();
            
            Product product1 = new product(1, "producto 1", 1000, false);
            product1.Description = "remera basica blanca";
            product1.category = new category(1, "remeras");
            product1.size = "xs";
            products.Add(product1);

            Product product2 = new product(2, "producto 2", 2000, true);
            product2.Description = "buzo canguro con capucha";
            product2.category = new category(2, "buzos");
            product2.size = "s";
            products.Add(product2);

            Product product3 = new product(3, "producto 3", 3000, false);
            product3.Description = "buzo canguro sin capucha";
            product3.category = new category(3, "buzos");
            product3.size = "m";
            products.Add(product3);

            Product product4 = new product(4, "producto 4", 4000, true);
            product4.Description = "buzo canguro con capucha 4 ";
            product4.category = new category(4, "buzos");
            product4.size = "l";
            products.Add(product4);

            Product product5 = new product(5, "producto 5", 5000, false);
            product5.Description = "remera basica blanca 5";
            product5.category = new category(5, "remeras");
            product5.size = "xl";
            products.Add(product5);

            Product product6 = new product(6, "producto 6", 6000, true);
            product6.Description = "remera basica negra 6";
            product6.category = new category(6, "remeras");
            product6.size = "xxl";
            products.Add(product6);

            return products;
        }
    }
}
