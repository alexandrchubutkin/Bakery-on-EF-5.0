using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

/// <summary>
/// Summary description for Order
/// </summary>
public class Order
{
    public Order()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public int OrderId { get; set; }
    public DateTime Period { get; set; }
    public virtual int CustomerId { get; set; }
    public virtual Customer Customer { get; set; }
    public virtual int ProductId { get; set; }
    public virtual Product Product { get; set; }
    public decimal Price { get; set; } // if price changed, for history
    public int Count { get; set; }
    public decimal Total { get; set; }
}
