using AM.Business.DataServices;
using AM.Business.Interfaces;
using AM.Business.Models;
using AM.Data.Interfaces;
using AM.Data.Models;
using AutoMapper;
using System.Security.Cryptography.X509Certificates;

namespace SM.Business.DataServices
{
    public class ProductServices : GenericService<ProductModel, Product> ,  IProductService
    {
        private readonly IRepository<Product> _repository;

        public ProductServices(IRepository<Product> repository, IMapper mapper) : base(repository, mapper)

        {
            _repository = repository;
        }

        public List<ProductModel> GetAllProducts(int id)
        {
            var ProductsQueryable = _repository.Get(x => x.Id ==id );
            var ProductModels = ProductsQueryable.Select(x => new ProductModel
            { Id = x.Id, Name = x.Name, Price = x.Price, Img = x.Img, Product_Description = x.Product_Description }).ToList();
            return ProductModels;
        }

        public List<ProductModel> Productsforcategories(int categoryId, string? searchterm)
        {

            var ProductsQueryable = _repository.Get(x => x.Id==categoryId);
           if(!string.IsNullOrEmpty(searchterm))
            {
                searchterm = searchterm.Trim().ToLower();
               ProductsQueryable = ProductsQueryable.Where(x => x.Name.ToLower()
              .Contains(searchterm) || x.Price.ToLower()
              .Contains(searchterm) || x.Product_Description.ToLower()
              .Contains(searchterm)) ;
            }

            var ProductModels = ProductsQueryable.Select(x => new ProductModel
            { Id = x.Id,Name = x.Name, Price = x.Price, Img = x.Img, Product_Description = x.Product_Description }).ToList();
            return ProductModels;
        }
        public List<ProductModel> Search(string searchterm)
        {
            searchterm= searchterm.Trim().ToLower();
             var allproducts = _repository.Get(x => x.Name.ToLower()
               .Contains(searchterm) || x.Price.ToLower()
               .Contains(searchterm) || x.Img.ToLower()
               .Contains(searchterm) || x.Product_Description.ToLower()
               .Contains(searchterm)).ToList();

            var ProductModels = allproducts.Select(x => new ProductModel { Id = x.Id, Name = x.Name, Price = x.Price, Img = x.Img, Product_Description = x.Product_Description }).ToList();
            return ProductModels;
        }
    }
}