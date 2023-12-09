using System;
using System.Collections.Generic;

namespace CarDB.carDB;

public partial class Maker
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Country { get; set; } = null!;

    public virtual ICollection<Car> Cars { get; set; } = new List<Car>();
}
