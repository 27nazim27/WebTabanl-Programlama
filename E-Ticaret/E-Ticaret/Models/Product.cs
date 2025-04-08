using E_Ticaret.Models;

namespace E_Ticaret.Models
{
    public class Product
    {
        public Product()
        {
            Id = new Guid().ToString();
        }
        public string Id { get; set; }
        public string Name { get; set; }
        public string Decription { get; set; }
        public decimal Price { get; set; }
       
    }
}
