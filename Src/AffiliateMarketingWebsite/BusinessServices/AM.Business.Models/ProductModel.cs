using AM.Data.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace AM.Business.Models
{
    public class ProductModel
    {
        //public ProductModel()
        //{
        //    this.Categories = new HashSet<category>();
        //}
        public int Id { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public string Img { get; set; }
        public string Product_Description { get; set; }
        public IList<PDetails> PDetails { get; set; } //collection navigation property


        //one to one with PDetails
        //public virtual PDetails Detail { get; set; }

        // public virtual ICollection<category> Categories { get; set; }


    }
}