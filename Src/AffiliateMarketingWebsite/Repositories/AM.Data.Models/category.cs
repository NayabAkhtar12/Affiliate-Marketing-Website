using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Data.Models
{
    public class category : BaseEntity
    {
        //public category() 
        //{
        //   // products = new List<Product>();
        //    this.products = new HashSet<Product>();

        //}
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Img { get; set; } = string.Empty;
        public IList<Product> Product { get; set; } //collection navigation property


        //  public virtual ICollection<Product> products { get; set; }
    }
}
