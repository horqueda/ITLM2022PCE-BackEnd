﻿using Back_End.Models;

namespace Back_End.Repositories
{
    public class ProductRepository
    {
        public List<Product> GetProducts()
        {
            List<Product> products = new List<Product>();

            Product product1 = new Product(1, "Producto 1", 1000, false);
            product1.Description = "Remera basica blanca";
            product1.category = new Category(1, "Remeras");
            product1.Size = "XS";
            products.Add(product1);

            Product product2 = new Product(2, "Producto 2", 2000, true);
            product2.Description = "Buzo canguro con capucha";
            product2.category = new Category(2, "Buzos");
            product2.Size = "S";
            products.Add(product2);

            Product product3 = new Product(3, "Producto 3", 3000, false);
            product3.Description = "Buzo canguro Sin capucha";
            product3.category = new Category(3, "Buzos");
            product3.Size = "M";
            products.Add(product3);

            Product product4 = new Product(4, "Producto 4", 4000, true);
            product4.Description = "Buzo canguro con capucha 4 ";
            product4.category = new Category(4, "Buzos");
            product4.Size = "L";
            products.Add(product4);

            Product product5 = new Product(5, "Producto 5", 5000, false);
            product5.Description = "Remera basica blanca 5";
            product5.category = new Category(5, "Remeras");
            product5.Size = "XL";
            products.Add(product5);

            Product product6 = new Product(6, "Producto 6", 6000, true);
            product6.Description = "Remera basica Negra 6";
            product6.category = new Category(6, "Remeras");
            product6.Size = "XXL";
            products.Add(product6);

            return products;
        }
    }
}