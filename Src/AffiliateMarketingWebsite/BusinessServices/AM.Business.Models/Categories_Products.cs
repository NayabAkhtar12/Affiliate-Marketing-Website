using AM.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Business.Models
{
    public class Categories_Products
    {
        public int CategoryId { get; set; } //foreign key property
        public category Category { get; set; } //Reference navigation property

        public int ProductId { get; set; } //foreign key property
        public Product Product { get; set; } //Reference navigation property
    }
}
