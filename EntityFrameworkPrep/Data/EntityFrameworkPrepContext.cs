using EntityFrameworkPrep.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkPrep.Data
{
    public class EntityFrameworkPrepContext : DbContext //DBContext represents a session with the the db
    {
        public DbSet<Customer> Customers { get; set; } //each db represents the table that will be created in the db
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductOrder> ProductOrders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=EFPrepDB");
        }
    }
}
