using System.ComponentModel.DataAnnotations.Schema;

namespace la_mia_pizzeria_static.Models
{
    public class Pizza
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [Column(TypeName = "text")]
        public string Description { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }

        public Pizza()
        {

        }
        public Pizza(string name, string description, string image, decimal price)
        {
            //Id = new Random().Next(1, 999999);
            Name = name;
            Description = description;
            Image = image;
            Price = price;
        }
    }
}
