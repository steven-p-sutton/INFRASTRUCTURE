using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;

// Logging
// https://www.tutorialsteacher.com/core/fundamentals-of-logging-in-dotnet-core
// https://thecodebuzz.com/logging-in-net-core-console-application/
// Install-Package Serilog.Extensions.Logging.File

namespace Conductus.LOGGING.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://thecodebuzz.com/logging-in-net-core-console-application/

            var services = new ServiceCollection();

            // .AddConfiguration
            // .AddConsole
            // .AddFilter
            // .AddProvider
            services.AddLogging(configure 
                => configure.AddConsole()).AddTransient<clsMyApplication>();
                                            // .AddLogging
                                            // .BuildServiceProvider
                                            // .AddSingleton
                                            // .AddTranient
                                            // .AddOptions
                                            // .AddScoped

            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                clsMyApplication app = serviceProvider.GetService<clsMyApplication>();
                // Start up logic here
                app.Run();
            }
        }
    }
}
