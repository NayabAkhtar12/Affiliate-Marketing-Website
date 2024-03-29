using AM.Business.Interfaces;
using AM.Data;
using AM.DependencyInjection;
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
            //All Application Di configurations
            builder.Services.AppDISetup(builder.Configuration);
            //
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
            app.UseAuthentication();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}