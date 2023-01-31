using AM.Business.Interfaces;
using AM.Business.Models;
using AM.Data;
using AM.Data.Interfaces;
using AM.Data.Models;

namespace SM.Business.DataServices
{
    public class ProductServices : IProductService
    {
        private readonly IRepository<Product> _dbContext;

        public ProductServices(IRepository<Product> dbContext)

        { 
            _dbContext = dbContext;
        }

        public List<ProductModel> GetAll()
        {

            var allproducts = _dbContext.GetAll();
            var ProductModels = allproducts.Select(x => new ProductModel { Id = x.Id, Name = x.Name, Price = x.Price, Img = x.Img, Product_Description = x.Product_Description }).ToList();
            return ProductModels;
        }

        public List<ProductModel> Search(string searchterm)
        {
            searchterm= searchterm.Trim().ToLower();
             var allproducts = _dbContext.Get(x => x.Name.ToLower()
               .Contains(searchterm.Trim().ToLower()) || x.Price.ToLower()
               .Contains(searchterm.Trim().ToLower()) || x.Img.ToLower()
               .Contains(searchterm.Trim().ToLower()) || x.Product_Description.ToLower()
               .Contains(searchterm.Trim().ToLower())).ToList();

            var ProductModels = allproducts.Select(x => new ProductModel { Id = x.Id, Name = x.Name, Price = x.Price, Img = x.Img, Product_Description = x.Product_Description }).ToList();
            return ProductModels;
        }
        public void Add(ProductModel model)
        {
            _dbContext.save(new Product { Id = model.Id, Name = model.Name, Price = model.Price, Img = model.Img, Product_Description = model.Product_Description });
            //_dbContext.SaveChanges();
        }
        public void Update(ProductModel model)
        {
            _dbContext.save(new Product { Id = model.Id, Name = model.Name, Price = model.Price, Img = model.Img, Product_Description = model.Product_Description });
        }

        public void Delete(int id)
        {
            var productstodelete = _dbContext.Get(x => x.Id == id).FirstOrDefault();
            if (productstodelete != null)
            {
                _dbContext.Delete(productstodelete);
            }
        }

     
    }
}