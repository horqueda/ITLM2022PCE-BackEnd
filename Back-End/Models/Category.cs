namespace Back_End.Models
{
    public class Category
    {
        public int idCategory { get; set; }
        
        public string name { get; set; }

        public Category()
        {

        }
        public Category(int idCategory, string name)
        {
            this.idCategory = idCategory;
            this.name = name;
        }
    }
}
