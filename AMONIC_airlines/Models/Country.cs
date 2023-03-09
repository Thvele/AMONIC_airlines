using System;
using System.Collections.Generic;

namespace AMONIC_airlines.Models;

public partial class Country
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public ICollection<Office> Offices { get; } = new List<Office>();
}
