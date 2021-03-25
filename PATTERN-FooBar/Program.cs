using Conductus.PATTERN.FooBar.FOOSERVICE;
using Conductus.PATTERN.FooBar.BARSERVICE;
using Microsoft.Extensions.DependencyInjection;

namespace Conductus.PATTERN.FooBar
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://dotnetcoretutorials.com/2017/01/24/servicecollection-extension-pattern/


            // setup our DI
            // clsFooService will be injectected into clsBarService 
            // as constractors called behind the scenes, replacing
            // factory classes etc

            var serviceProvider = new ServiceCollection()
                .AddSingleton<IFooService, clsFooService>()
                .AddSingleton<IBarService, clsBarService>()
                .BuildServiceProvider();
                // .AddLogging
                // .BuildServiceProvider
                // .AddSingleton
                // .AddTranient
                // .AddOptions
                // .AddScoped

            // Called the Bar class and this will use the Foo class
            // setup in the DI framework setup 

            var bar = serviceProvider.GetService<IBarService>();
            bar.DoSomeRealWork();
        }
    }
}
