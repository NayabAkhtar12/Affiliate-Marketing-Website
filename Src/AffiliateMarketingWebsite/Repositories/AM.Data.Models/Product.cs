using System.ComponentModel.DataAnnotations.Schema;

namespace AM.Data.Models
{
    public class Product : BaseEntity
    {
        //public Product()
        //{
        //   // Category = new category();
        //    this.Categories = new HashSet<category>();

        //}
        public int Id { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public string Img { get; set; }
        public string Product_Description { get; set; }

        public IList<PDetails> PDetails { get; set; } //collection navigation property


        //one to one with PDetails
        //  public virtual PDetails Detail { get; set; }


        // public int CategoryId { get; set; }
        //[ForeignKey("CategoryId")]

        //  public virtual ICollection category Categories { get; set; }
        //    public virtual ICollection<category> Categories { get; set; }



    }
}