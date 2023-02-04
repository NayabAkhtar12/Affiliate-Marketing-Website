using AM.Data.Interfaces;
using AM.Data.Models;

namespace AM.Data
{
    public class PDetailsRepository : Repository<PDetails>, IPDetailsRepository
    {
        public PDetailsRepository(AffiliateMarketingDbContext context) : base(context)
        {

        }
    }
}
