using System;
using System.Collections.Generic;

namespace CarDB.carDB;

public partial class Customer
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Age { get; set; } = null!;

    public virtual ICollection<Rental> Rentals { get; set; } = new List<Rental>();
}
