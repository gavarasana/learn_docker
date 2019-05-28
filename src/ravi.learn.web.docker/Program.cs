using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using ravi.learn.web.docker.Data;
using ravi.learn.web.docker.Extensions;

namespace ravi.learn.web.docker
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().MigrateDatabase<MagazineContext>()
                .Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
