using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ravi.learn.web.docker.Extensions
{
    public static class WebHostExtension
    {
        public static IWebHost MigrateDatabase<T>(this IWebHost webHost) where T : DbContext
        {
            using (var scope = webHost.Services.CreateScope())
            {
                var serviceProvider = scope.ServiceProvider;
                try
                {
                    var dbContext = serviceProvider.GetService<T>();
                    dbContext.Database.Migrate();
                } catch (Exception ex)
                {
                    var logger = serviceProvider.GetService<ILogger<Program>>();
                    logger.LogError(ex, "An error occurred while migrating the database");
                }
            }
            return webHost;
        }
    }
}
