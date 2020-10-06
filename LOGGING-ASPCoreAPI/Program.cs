using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Conductus.Logging.ASPCoreAPI
{
    // Logging
    // https://www.tutorialsteacher.com/core/fundamentals-of-logging-in-dotnet-core
    // https://www.tutorialsteacher.com/core/aspnet-core-logging
    // Install-Package Serilog.Extensions.Logging.File

    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }
        public static IHostBuilder CreateHostBuilder(string[] args) => 
            Host.CreateDefaultBuilder(args).ConfigureWebHostDefaults
            (
                webBuilder => {webBuilder.UseStartup<Startup>();}

            ).ConfigureLogging 
                (
                    // Logging added
                    logBuilder =>            
                    {
                        logBuilder.ClearProviders(); // removes all providers from LoggerFactory
                        logBuilder.AddConsole();
                        logBuilder.AddTraceSource("Information, ActivityTracing"); // Add Trace listener provider
                    }
                );
}
}
