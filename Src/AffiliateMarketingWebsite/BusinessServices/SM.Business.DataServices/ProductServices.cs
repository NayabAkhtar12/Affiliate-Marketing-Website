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

        public List<ProductModel> Productsforcategories(int categoryId)
        {

            var ProductsQueryable = _repository.Get(x => x.CategoryId == categoryId);
            var ProductModels = ProductsQueryable.Select(x => new ProductModel
            { Id = x.Id,Name = x.Name, Price = x.Price, Img = x.Img,
                Product_Description = x.Product_Description,LinkToBuy=x.LinkToBuy,CategoryId=x.CategoryId
            }).ToList();
            return ProductModels;
        }
    }
}