using AM.Business.Interfaces;
using AM.Data;
using Microsoft.EntityFrameworkCore;
using SM.Business.DataServices;

namespace AM.WebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //build
            var builder = WebApplication.CreateBuilder(args);
            // Add services to the container.
            builder.Services.AddControllersWithViews();
            //Configure Entity Framework
            builder.Services.AddDbContext<AffiliateMarketingDbContext>(
            options => options.UseSqlServer("Data Source=CRIBV-DNET30; Database=AMSystem; Integrated Security=SSPI;  TrustServerCertificate=True;"));
            //All custom configurations
            builder.Services.AddSingleton<IProductServices>();
            builder.Services.AddSingleton<IProductService, IProductServices>();

            var app = builder.Build();
            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}