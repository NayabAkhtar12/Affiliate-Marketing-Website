using AM.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace AM.Data
{

    public class AffiliateMarketingDbContext : DbContext
    {
        public AffiliateMarketingDbContext(DbContextOptions<AffiliateMarketingDbContext> options) : base(options) { }
       //All Entities Dbset
        public DbSet<Product> Products { get; set; }
        public DbSet<category> categories { get; set; }

    }
}