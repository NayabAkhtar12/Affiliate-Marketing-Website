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
        public DbSet<PDetails> Product_Details { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Write Fluent API configurations here

            modelBuilder.Entity<Product>()
                        .HasOne(t => t.PDetails)
                        .WithOne(t => t.Product)
                        .UsingEntity(j => j.ToTable("ProductDetails"));
        }
    }
}