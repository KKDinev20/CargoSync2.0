using CargoSync.Business.Interfaces;
using CargoSync.Business.Services;
using CargoSync.DataAccess.Data;
using CargoSync.DataAccess.Data.Interfaces;
using CargoSync.DataAccess.Data.Repositories;
using CargoSync.DataAccess.Models;
using CargoSync.Presentation.Controllers;
using Microsoft.EntityFrameworkCore;

namespace CargoSync.Presentation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();

            string connectionString = "Server=tcp:cargosync.database.windows.net,1433;Initial Catalog=CargoSync;Persist Security Info=False;User ID=kkdinev20;Password=Yuh02969;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

            builder.Services.AddDbContext<CargoSyncDbContext>(options =>
                options.UseSqlServer(connectionString));

            // Add the service registration for IDeliveryService
            builder.Services.AddScoped<IDeliveryRepository, DeliveryRepository>();
            builder.Services.AddScoped<IDeliveryService, DeliveryService>();

            builder.Services.AddScoped<ICargoService, CargoService>();
            builder.Services.AddScoped<ICargoRepository, CargoRepository>();

            builder.Services.AddScoped<IUserRepository, UserRepository>();
            builder.Services.AddScoped<IUserService, UserService>();

            builder.Services.AddScoped<IRevenueRepository, RevenueRepository>();
            builder.Services.AddScoped<IRevenueService, RevenueService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.MapControllerRoute(
                name: "delivery",
                pattern: "{controller=DeliveryManagement}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
