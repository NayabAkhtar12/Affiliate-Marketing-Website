﻿using AM.Business.Interfaces;
using AM.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Protocols;
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

            //All custom configurations
            services.AddScoped<IProductService, ProductServices>();
        }
    }
}