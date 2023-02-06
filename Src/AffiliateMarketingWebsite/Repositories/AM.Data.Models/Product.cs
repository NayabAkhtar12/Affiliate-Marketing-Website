using System.ComponentModel.DataAnnotations.Schema;

namespace AM.Data.Models
{
    public class Product : BaseEntity
    {
        public Product()
        {
            Category = new category();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public string Img { get; set; }
        public string Product_Description { get; set; }

        public int CategoryId { get; set; }
        [ForeignKey ("CategoryId")]

        public category Category { get; set; }

    }
}