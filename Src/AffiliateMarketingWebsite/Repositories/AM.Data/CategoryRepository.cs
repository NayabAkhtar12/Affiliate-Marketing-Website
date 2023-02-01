using AM.Data.Interfaces;
using AM.Data.Models;
using System.Linq.Expressions;

namespace AM.Data
{

        public class CategoryRepository : Repository<category>, ICategoryRepository
        {
            public CategoryRepository(AffiliateMarketingDbContext context) : base(context)
            {

            }
          
        }
}
