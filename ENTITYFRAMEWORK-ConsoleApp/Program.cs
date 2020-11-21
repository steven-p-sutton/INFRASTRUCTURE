using System;
using System.Linq;
// 
// Migrations Overview - Migrstion using cmd line
//   https://docs.microsoft.com/en-us/ef/core/managing-schemas/migrations/?tabs=dotnet-core-cli
//
//   1. Build the model in code
//   2. Create the db using migration
//      - dotnet ef migrations add InitialCreate
//      - dotnet ef database update
//   3. Revise the model in code 
//   4. Upgrade the db using migration
//      - dotnet ef migrations add <abc>
//      - dotnet ef database update
//   5. Repeat code -> upgrade steps as required
//   6. Copy db from source folder to deployment folder before running, else exceptions will occur 
//      (cant fins db so new blank created and tables are seen as missing, exception rised by app)
// SQLite Viewer Download - use to view the blogging.db created by the migration
//   https://www.systoolsgroup.com/sqlite-viewer.html
//
// References
//
//   SqliteDbContextOptionsBuilderExtensions.UseSqlite Method   
//      https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.sqlitedbcontextoptionsbuilderextensions.usesqlite?view=efcore-5.0
//   C# (CSharp) DbContextOptionsBuilder.UseSqlite Examples
//      https://csharp.hotexamples.com/examples/-/DbContextOptionsBuilder/UseSqlite/php-dbcontextoptionsbuilder-usesqlite-method-examples.html
//   Configuring a DbContext
//      https://docs.microsoft.com/en-us/ef/core/dbcontext-configuration/
//   Entity Framework Core using SQL Server
//      https://entityframeworkcore.com/providers-sql-server
//   NUGet install Microsoft.EntityFrameworkCore.SqlServer
//
//   Connection strings and models
//      https://docs.microsoft.com/en-us/ef/ef6/fundamentals/configuring/connection-strings?redirectedfrom=MSDN

namespace Conductus.EntityFramework.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            using (var db = new Context())
            {
                // Create and save a new Blog
                Console.Write("Enter a name for a new Blog: ");
                var name = Console.ReadLine();

                var blog = new Blog { Name = name };
                db.Blogs.Add(blog);
                db.SaveChanges();

                // Display all Blogs from the database
                var query = from b in db.Blogs
                            orderby b.Name
                            select b;

                Console.WriteLine("All blogs in the database:");
                foreach (var item in query)
                {
                    Console.WriteLine(item.Name);
                }

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }
}
