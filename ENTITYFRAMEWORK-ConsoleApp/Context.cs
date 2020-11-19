﻿using Microsoft.EntityFrameworkCore;

namespace Conductus.EntityFramework.ConsoleApp
{
    public class Context : DbContext
    {
        public DbSet<HelloWorld> HelloWorlds { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=HelloWorld.db");
    }
}
