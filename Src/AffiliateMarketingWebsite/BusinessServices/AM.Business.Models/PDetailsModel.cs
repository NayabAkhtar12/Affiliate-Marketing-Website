using AM.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Business.Models
{
    public class PDetailsModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Price { get; set; } = string.Empty;
        public string Product_Description { get; set; } = string.Empty;
        public string Link { get; set; } = string.Empty;
        [ForeignKey("ProductId")]//Gender Primary key
        public Product Products { get; set; } //collection navigation property

        //   public virtual Product Products { get; set; }

    }
}
