using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

/// <summary>
/// Summary description for Customer
/// </summary>
public class Customer
{
    public Customer()
    {
        Orders = new HashSet<Order>();
    }

    public int CustomerId { get; set; }
    [StringLength(256)]
    public string Email { get; set; }
    [StringLength(1000)]
    public string AddressShipping { get; set; }
    public DateTime PeriodOfFirstRegister { get; set; }
    public virtual ICollection<Order> Orders { get; set; }
}
