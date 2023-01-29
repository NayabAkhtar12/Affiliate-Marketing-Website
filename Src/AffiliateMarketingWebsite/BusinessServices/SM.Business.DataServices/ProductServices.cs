using AM.Business.Interfaces;
using AM.Business.Models;

namespace SM.Business.DataServices
{
    public class IProductServices : IProductService
    {
        private List<ProductModel> products = new List<ProductModel>();
        public List<ProductModel> GetAll()
        {
            products.Add(new ProductModel { id = 1, Name = "Product 1" });
            products.Add(new ProductModel { id = 2, Name = "Product 2" });
            products.Add(new ProductModel { id = 3, Name = "Product 3" });
            return products;
        }
        public void Add(ProductModel model)
        {
            products.Add(model);
        }
        public void Delete(int id)
        {
            var productstodelete = products.Where(x => x.id == id).FirstOrDefault();
            if (productstodelete != null)
            {
                products.Remove(productstodelete);

            }
        }
    }
}