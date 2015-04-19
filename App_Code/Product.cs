using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

/// <summary>
/// Summary description for Product
/// </summary>
public class Product
{
    public Product()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public int ProductId { get; set; }
    [StringLength(50)]
    public string Name { get; set; }
    [StringLength(1000)]
    public string Description { get; set; }
    public decimal Price { get; set; }
    [StringLength(50)]
    public string ImageName { get; set; }
}
