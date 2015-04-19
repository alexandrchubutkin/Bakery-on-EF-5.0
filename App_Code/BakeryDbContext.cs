using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Data.Entity.Migrations;

/// <summary>
/// Summary description for BakeryDbContext
/// </summary>
public class BakeryDbContext : DbContext
{
    public BakeryDbContext()
    {
        //
        // TODO: Add constructor logic here
        //
        Configuration.LazyLoadingEnabled = false;         
    }

    public DbSet<Product> Products { get; set; }
}

// Migrations 
/*
    In _AppStart.cshtml create string:
    System.Data.Entity.Database.SetInitializer<BakeryContext>(new BakeryContextInitializer());
*/
public class BakeryDbContextInitializer : MigrateDatabaseToLatestVersion<BakeryDbContext, BakeryDbContextDbMigrationsConfiguration> 
{

}

public sealed class BakeryDbContextDbMigrationsConfiguration : DbMigrationsConfiguration<BakeryDbContext> 
{
    public BakeryDbContextDbMigrationsConfiguration() 
    {
        AutomaticMigrationsEnabled = true;
        AutomaticMigrationDataLossAllowed = true;
    }

    protected override void Seed(BakeryDbContext context)
    {
        var products = WebMatrix.Data.Database.Open("bakery").Query("select * from Products").ToList();
        foreach (var p in products) {
            context.Products.Add(new Product() { Name = p.Name, Description = p.Description, 
                Price = p.Price, ImageName = p.ImageName });
        }
        base.Seed(context);
    }
}