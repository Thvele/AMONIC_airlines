using System;
using System.Collections.Generic;

namespace AMONIC_airlines.Models;

public partial class User
{
    public int Id { get; set; }

    public int RoleId { get; set; }
    public Role Role { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string? FirstName { get; set; }

    public string LastName { get; set; } = null!;

    public int OfficeId { get; set; }
    public Office Office { get; set; } = null!;

    public DateTime? Birthdate { get; set; }

    public bool? Active { get; set; }
}
