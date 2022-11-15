namespace Back_End.Models
{
    public class Product
    {
        private double _originalPrice;
        public int Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }
        public string UrlImage { get; set; }
        public double Price { get; }
        public string Size { get; set; }
        public Category category { get; set; }
        public bool Destacado { get; set; }

        public bool mostrarEnBanner { get; set; }

        public Product (int id, string name, double price, bool destacado, bool banner)
        {
            this._originalPrice = price;
            this.Price = price;
            this.Id = id;
            this.Name = name;
            this.Size = "No Size";
            this.category = new Category();
            this.Destacado = destacado;
            this.mostrarEnBanner = banner;
        }

        public Product()
        {
            this.category = new Category();
        }

        public void SetNewPrice(double newPrice)
        {
            if (newPrice < (_originalPrice * 0.90))
            {
                throw new Exception("No se puede hacer mas de un 10% de descuento");
            }
            _originalPrice = newPrice;
        }

    }
}