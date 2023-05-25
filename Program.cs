using BZLAND.DAL;
using Microsoft.EntityFrameworkCore;

namespace BZLAND
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            var connectionString = builder.Configuration.GetConnectionString("Default");
            builder.Services.AddDbContext<AddDbContext>(x => x.UseSqlServer(connectionString));

            var app = builder.Build();


            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();


            app.UseEndpoints(endpoints =>
            {


                endpoints.MapControllerRoute(
                  name: "areas",
                  pattern: "{area:exists}/{controller=Dashboard}/{action=Index}/{id?}"
                  );


                endpoints.MapDefaultControllerRoute();

                app.Run();
            });
        }
    }
}
    