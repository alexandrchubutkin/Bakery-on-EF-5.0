using System;
using System.Collections.Generic;
using System.Data.Entity;

public class BakeryDbContextInitializer : DropCreateDatabaseAlways<BakeryDbContext>
{
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