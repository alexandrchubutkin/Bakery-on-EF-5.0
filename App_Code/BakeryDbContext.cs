using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Data.Entity.Validation;

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
        this.Configuration.LazyLoadingEnabled = false;
    }
}
