using System;
using System.Collections.Generic;

namespace AMONIC_airlines.Models;

public partial class Office
{
    public int Id { get; set; }

    public int CountryId { get; set; }
    public Country Country { get; set; } = null!;

    public string Title { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string Contact { get; set; } = null!;

    public ICollection<User> Users { get; } = new List<User>();
}
