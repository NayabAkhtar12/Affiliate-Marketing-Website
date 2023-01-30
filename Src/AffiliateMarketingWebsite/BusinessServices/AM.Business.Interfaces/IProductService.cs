using AM.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Business.Interfaces
{
    public interface IProductService
    {
        public List<ProductModel> GetAll();
        public List<ProductModel> Search(string searchterm);

        public void Add(ProductModel model);
        public void Update(ProductModel model);
        public void Delete(int id);
    }
}
