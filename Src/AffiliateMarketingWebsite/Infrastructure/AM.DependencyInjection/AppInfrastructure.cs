using AM.Business.DataServices;
using AM.Business.Interfaces;
using AM.Data;
using AM.Data.Interfaces;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SM.Business.DataServices;

namespace AM.DependencyInjection
{
    public static class AppInfrastructure
    {
        public static void AppDISetup(this IServiceCollection services, IConfiguration configuration) 
        {
            //Configure Entity Framework
            services.AddDbContext<AffiliateMarketingDbContext>(
            options => options.
            UseSqlServer(configuration.GetConnectionString("DbConnection")));

            //Repository Configurations
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

            //Configurations for Authentication
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie((CookieOptions) =>
                {
                    CookieOptions.LoginPath = "/Authentication/Login";
                    CookieOptions.Cookie = new CookieBuilder
                    {
                        Name = "AffiliateMarketingCookie"
                    };
                });

            //All custom configurations
            services.AddScoped<IProductService, ProductServices>();
            services.AddScoped<ICategoryService, Categoryservice>();

            //AutoMapper Configuration
            services.AddAutoMapper(typeof(BusinessEntityMappings));
        }
    }
}