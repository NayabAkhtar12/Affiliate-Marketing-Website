using AM.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace AM.Data
{

    public class AffiliateMarketingDbContext : DbContext
    {
        public AffiliateMarketingDbContext(DbContextOptions<AffiliateMarketingDbContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; }
    }
}