using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using ProductsManagement.Models;
using ProductsManagement;  // Add this line to include the namespace for MigrationManager

namespace ProductsManagement
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            host.MigrateDatabase<ProductContext>(); // Apply migrations before starting the application
            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}