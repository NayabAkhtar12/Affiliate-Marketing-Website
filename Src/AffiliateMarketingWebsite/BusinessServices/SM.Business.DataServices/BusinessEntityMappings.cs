using AM.Business.Models;
using AM.Data.Models;
using AutoMapper;

namespace AM.Business.DataServices
{
    public class BusinessEntityMappings :Profile
    {
        public BusinessEntityMappings()
        {

            CreateMap<ProductModel, Product>().ReverseMap();
            CreateMap<CategoryModel, category>().ReverseMap();

        }
    }
}
