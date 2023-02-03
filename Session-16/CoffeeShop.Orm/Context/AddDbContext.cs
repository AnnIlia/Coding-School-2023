using coffeeshop.model;
using CoffeeShop.Model;
using CoffeeShop.Orm.Configuration;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Orm.Context
{
    public class AddDbContext : DbContext
    {
        //maybe must include and Customer -im not sure-
        //Problem: ProductCategory
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Product> Products { get; set; }

        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<TransactionLine> TransactionLines { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            

            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new ProductCatConfiguration());
            modelBuilder.ApplyConfiguration(new TransactionLineConfiguration());
            modelBuilder.ApplyConfiguration(new TransactionConfiguration());
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CoffeShop;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;");
            base.OnConfiguring(optionsBuilder);
        }


    }
}
