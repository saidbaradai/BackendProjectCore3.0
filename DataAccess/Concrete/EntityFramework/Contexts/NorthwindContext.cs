using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework.Contexts
{
    public class NorthwindContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: "server=DESKTOP-7K06ESJ;database=Northwind;Integrated Security=True");
        }

        public DbSet<Product>  Products { get; set; }
        public DbSet<Category>  categories { get; set; }
        public DbSet<OperationClaim> operationClaims { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserOperationClaim> userOperationClaims { get; set; }

    }
}
