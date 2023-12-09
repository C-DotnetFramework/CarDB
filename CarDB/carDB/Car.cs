using System;
using System.Collections.Generic;

namespace CarDB.carDB;

public partial class Car
{
    public int Id { get; set; }

    public string ModelName { get; set; } = null!;

    public int MakerId { get; set; }

    public DateTime ProductionDate { get; set; }

    public string Color { get; set; } = null!;

    public string RentalPrice { get; set; } = null!;

    public virtual Maker Maker { get; set; } = null!;

    public virtual ICollection<Rental> Rentals { get; set; } = new List<Rental>();
}
