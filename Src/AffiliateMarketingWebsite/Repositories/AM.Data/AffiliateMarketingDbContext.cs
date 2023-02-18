using AM.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace AM.Data
{

    public class AffiliateMarketingDbContext : DbContext
    {
        public AffiliateMarketingDbContext()
        {
        }

        public AffiliateMarketingDbContext(DbContextOptions<AffiliateMarketingDbContext> options) : base(options) { }
        //All Entities Dbset
        public DbSet<category> category { get; set; }
        public DbSet<Product> Products { get; set; }
       // public DbSet<PDetails> Product_Details { get; set; }
      //  public DbSet<Categories_Products> Category_Product { get; set; }
        public DbSet<User> Users { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Write Fluent API configurations here
            modelBuilder.Entity<Product>()
                   .HasOne(e => e.Category)
                   .WithMany(e => e.Product)
                   .HasForeignKey(e => e.CategoryId)
                   .OnDelete(DeleteBehavior.Cascade); ;

            // modelBuilder.Entity<category>()
            //.HasOne<Product>(s => s.Products)
            //.WithMany(g => g.Categories)
            //.HasForeignKey(s => s.ProductId);

            //categories relation with product
            //modelBuilder.Entity<category>()
            //            .HasMany(t => t.Product)
            //            .WithMany(t => t.Categories)
            //            .UsingEntity(j => j.ToTable("Categories_Products"));

            //Product relation with product _Details 

            //modelBuilder.Entity<Product>()
            //            .HasOne(t => t.PDetails)
            //            .WithOne(t => t.Products)
            //            .HasForeignKey<PDetails>(e => e.Id);

            // modelBuilder.Entity<Categories_Products>()
            //.HasKey(t => new { t.CategoryId, t.ProductId });

            // modelBuilder.Entity<Categories_Products>()
            //             .HasOne(t => t.Category)
            //             .WithMany(t => t.Category_Product)
            //             .HasForeignKey(t => t.CategoryId);

            // modelBuilder.Entity<Categories_Products>()
            //.HasOne(t => t.Product)
            //.WithMany(t => t.Category_Product)
            //.HasForeignKey(t => t.ProductId);
        }
    }
}