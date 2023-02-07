using AM.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Business.Models
{
        public class CategoryModel
    {

        //public CategoryModel()
        //{
        //    // products = new List<Product>();
        //    this.products = new HashSet<ProductModel>();

        //}

        public int Id { get; set; }
            public string Name { get; set; } = string.Empty;
            public string Img { get; set; }= string.Empty;

        public IList<Categories_Products> Category_Product { get; set; } //collection navigation property

        // public virtual ICollection<ProductModel> products { get; set; }
        //public int ProductId { get; set; }
        //public Product Products { get; set; }


    }
}
