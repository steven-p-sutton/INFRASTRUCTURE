using Microsoft.EntityFrameworkCore;

namespace Conductus.ENTITYFRAMEWORK.ConsoleApp
{
    public class Context : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
        // Sqlite
        //protected override void OnConfiguring(DbContextOptionsBuilder options)
        //=> options.UseSqlite("Data Source=Blogging.db");

        // SQL Server
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                 .UseSqlServer(@"Data Source=(localdb)\MSSQLLOCAL;Initial Catalog=Blogging;");
            //   Connection strings and models
            //      https://docs.microsoft.com/en-us/ef/ef6/fundamentals/configuring/connection-strings?redirectedfrom=MSDN
        }
    }
}
