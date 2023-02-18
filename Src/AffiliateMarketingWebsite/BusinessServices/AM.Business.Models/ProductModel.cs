using AM.Data.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace AM.Business.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public string Img { get; set; }
        public string Product_Description { get; set; }
        public string LinkToBuy { get; set; }

        public int CategoryId { get; set; }

        public category Category { get; set; }
    }
}