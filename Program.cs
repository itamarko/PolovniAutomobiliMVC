using Microsoft.EntityFrameworkCore;
using PolovniAutomobiliMVC.Models;

namespace PolovniAutomobiliMVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContextPool<AppDbContext>(options =>
                {
                    options.UseSqlServer(builder.Configuration["PolovniAutomobiliDbConn"]);
                }
            );
            builder.Services.AddScoped<ICarRepository, CarRepository>();
            builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();

            builder.Services.AddScoped<ShoppingCart>(sp => ShoppingCart.GetCart(sp));
            builder.Services.AddHttpContextAccessor();
            builder.Services.AddSession();
            // Add services to the container.
            builder.Services.AddControllersWithViews();

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
            app.UseSession();
            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}