namespace Back_End.Models
{
    public class Product {           
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string UrlImage { get; set; }
        public double Price { get; set; }
        public string Size { get; set; }
        public Category Category { get; set; }


        public Product(int id, string name)
        {
            Id = id;
            Name = name;
            this.Size = "No Size";
            this.Category = new Category();
        }
    }
}
