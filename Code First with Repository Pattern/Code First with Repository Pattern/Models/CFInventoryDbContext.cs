using Code_First_with_Repository_Pattern.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Code_First_with_Repository_Pattern.Models
{
    public class CFInventoryDbContext:DbContext
    {
        public CFInventoryDbContext():base("CFInventoryDb")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<CFInventoryDbContext, Configuration>());
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        /*fluent Api*/
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasKey<int>(k=>k.CategoryId);
            modelBuilder.Entity<Product>().HasKey<int>(k=>k.ProductId);
            modelBuilder.Entity<Category>().Property(p => p.CategoryName).IsOptional().HasColumnOrder(2);
        }
    }
}