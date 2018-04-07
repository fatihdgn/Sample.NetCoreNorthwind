using Microsoft.EntityFrameworkCore;
using System;
using JetBrains.Annotations;
using Sample.NetCoreNorhwind.Entities;

namespace Sample.NetCoreNorthwind.Context
{
    public class NorthwindDB : DbContext
    {
        public NorthwindDB(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
