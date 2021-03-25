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
                => configure.AddConsole()).AddTransient<MyApplication>();
                                            // .AddLogging
                                            // .BuildServiceProvider
                                            // .AddSingleton
                                            // .AddTranient
                                            // .AddOptions
                                            // .AddScoped

            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                MyApplication app = serviceProvider.GetService<MyApplication>();
                // Start up logic here
                app.Run();
            }
        }
    }
}
