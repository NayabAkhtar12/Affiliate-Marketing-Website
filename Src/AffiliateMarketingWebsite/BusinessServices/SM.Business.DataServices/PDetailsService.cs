using AM.Business.Interfaces;
using AM.Business.Models;
using AM.Data.Interfaces;
using AM.Data.Models;
using AutoMapper;

namespace AM.Business.DataServices
{
    public class PDetailsService : GenericService<PDetailsModel, PDetails>, IPDetailsService
    {
        public PDetailsService(IRepository<PDetails> repository, IMapper mapper) : base(repository, mapper)

        {
        }
    }
}
