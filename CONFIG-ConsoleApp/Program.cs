using System;
using System.IO;
using Microsoft.Extensions.Configuration;

// .Net Core Configuration
// https://ballardsoftware.com/adding-appsettings-json-configuration-to-a-net-core-console-application/
// Install-Package Microsoft.Extensions.Configuration
// Install-Package Microsoft.Extensions.Configuration.Binder
// Install-Package Microsoft.Extensions.Configuration.EnvironmentVariables
// Install-Package Microsoft.Extensions.Configuration.FileExtensions
// Install-Package Microsoft.Extensions.Configuration.Json
// Install-Package Microsoft.Extensions.Configuration.UserSecrets#
//
// using Microsoft.Extensions.Configuration;

// Involves some existing file preparation seen below:
//
// C:\Users\steve\AppData\Roaming\Microsoft\UserSecrets\93d033dc-12eb-446a-91a6-efec88dfb437\secrets.json
//{
//  "ApiSecret":  "21u021u401u412u4102u410"
//}

// and some local app file preparation 
//
// C:\Users\steve\Documents\Visual Studio Work\Try\ConsoleApp-01\MySettingsConfig.cs
//{
//  "ConnectionStrings": {
//    "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=MyApplicationDatabase;Trusted_Connection=True;MultipleActiveResultSets=true"
//  },
// "MySettings": {
//    "AccountName": "myaccount",
//    "ApiKey": "3ut3902ut32ut9238uy932u902421414141"
//  }
//}

namespace Conductus.CONFIG.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
               .AddUserSecrets<Program>()
               .AddEnvironmentVariables();

            IConfigurationRoot configuration = builder.Build();
            var mySettingsConfig = new MySettingsConfig();
            configuration.GetSection("MySettings").Bind(mySettingsConfig);

            Console.WriteLine("Setting from appsettings.json: " + mySettingsConfig.AccountName);
            Console.WriteLine("Setting from secrets.json: " + mySettingsConfig.ApiSecret);
            Console.WriteLine("Connection string: " + configuration.GetConnectionString("DefaultConnection"));

            Console.ReadKey();
        }
    }
}
