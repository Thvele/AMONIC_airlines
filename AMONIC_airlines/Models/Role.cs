using System;
using System.Collections.Generic;

namespace AMONIC_airlines.Models;

public partial class Role
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public ICollection<User> Users { get; } = new List<User>();
}
