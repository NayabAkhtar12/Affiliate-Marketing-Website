using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Data.Models
{
    public class PDetails : BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Price { get; set; } = string.Empty;
        public string Product_Description { get; set; } = string.Empty;
        public string Link { get; set; } = string.Empty;
       // [ForeignKey("Id")]//Gender Primary key
       // public Product Products { get; set; } //collection navigation property

        //one to one with PDetails
        // public virtual Product Products { get; set; }
    }
}
