using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace ProductsManagement
{
    public static class MigrationManager
    {
        public static IHost MigrateDatabase<TContext>(this IHost host) where TContext : DbContext
        {
            using (var scope = host.Services.CreateScope())
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<TContext>();
                try
                {
                    dbContext.Database.Migrate();
                }
                catch (Exception)
                {
                    // Log the error or handle it as needed
                    throw;
                }
            }

            return host;
        }
    }
}
