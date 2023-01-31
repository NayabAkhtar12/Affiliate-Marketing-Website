using AM.Data.Interfaces;
using AM.Data.Models;

namespace AM.Data
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(AffiliateMarketingDbContext context) : base(context)
        {

        }
    }
}
