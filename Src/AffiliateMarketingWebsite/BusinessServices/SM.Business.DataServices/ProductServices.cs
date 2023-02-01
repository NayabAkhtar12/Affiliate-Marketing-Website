using AM.Business.DataServices;
using AM.Business.Interfaces;
using AM.Business.Models;
using AM.Data;
using AM.Data.Interfaces;
using AM.Data.Models;
using AutoMapper;

namespace SM.Business.DataServices
{
    public class ProductServices : GenericService<ProductModel, Product> ,  IProductService
    {
        private readonly IRepository<Product> _repository;

        public ProductServices(IRepository<Product> repository, IMapper mapper) : base(repository, mapper)

        {
            _repository = repository;
        }

        public List<ProductModel> Search(string searchterm)
        {
            searchterm= searchterm.Trim().ToLower();
             var allproducts = _repository.Get(x => x.Name.ToLower()
               .Contains(searchterm.Trim().ToLower()) || x.Price.ToLower()
               .Contains(searchterm.Trim().ToLower()) || x.Img.ToLower()
               .Contains(searchterm.Trim().ToLower()) || x.Product_Description.ToLower()
               .Contains(searchterm.Trim().ToLower())).ToList();

            var ProductModels = allproducts.Select(x => new ProductModel { Id = x.Id, Name = x.Name, Price = x.Price, Img = x.Img, Product_Description = x.Product_Description }).ToList();
            return ProductModels;
        }
    }
}