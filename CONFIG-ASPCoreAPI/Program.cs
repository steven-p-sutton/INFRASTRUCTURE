using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace Conductus.Config.API
{
    // Configuration
    // https://docs.microsoft.com/en-us/aspnet/core/fundamentals/configuration/?view=aspnetcore-3.1
    // Settings files, such as appsettings.json
    // Environment variables
    // Azure Key Vault
    // Azure App Configuration
    // Command-line arguments
    // Custom providers, installed or created
    // Directory files
    // In-memory.NET objects

    // https://www.fabiosilvalima.com/appsettings-read-config-aspnetcore/
    // Shows 6 ways starting from simple to the prefered DI method, which is implemented here, 
    // reading values from Appsettings.json out of the box

    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
