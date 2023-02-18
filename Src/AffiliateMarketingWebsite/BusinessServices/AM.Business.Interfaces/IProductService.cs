using AM.Business.Models;
using AM.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Business.Interfaces
{
    public interface IProductService : IGenericService<ProductModel>
    {
      public List<ProductModel> Productsforcategories(int categoryId);
        public List<ProductModel> GetAllProducts(int id);

    }
}
