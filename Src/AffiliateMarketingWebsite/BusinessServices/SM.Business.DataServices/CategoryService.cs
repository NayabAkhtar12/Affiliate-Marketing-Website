using AM.Business.DataServices;
using AM.Business.Interfaces;
using AM.Business.Models;
using AM.Data.Interfaces;
using AM.Data.Models;
using AutoMapper;

namespace SM.Business.DataServices
{
    public class Categoryservice : GenericService<CategoryModel, category>, ICategoryService
    {
        public Categoryservice(IRepository<category> repository, IMapper mapper) : base(repository, mapper)

        {
        }
    }

}