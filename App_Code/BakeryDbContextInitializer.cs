using System;
using System.Collections.Generic;
using System.Data.Entity;

public class BakeryDbContextInitializer : DropCreateDatabaseAlways<BakeryDbContext>
{
    protected override void Seed(BakeryDbContext context)
    {
        base.Seed(context);
    }
}