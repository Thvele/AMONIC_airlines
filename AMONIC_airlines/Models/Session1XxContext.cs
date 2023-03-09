using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AMONIC_airlines.Models;

public partial class Session1XxContext : DbContext
{
    public Session1XxContext()
    {
    }

    public DbSet<Country> Countries { get; set; }

    public DbSet<Office> Offices { get; set; }

    public DbSet<Role> Roles { get; set; }

    public DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer("Data Source=DESKTOP-CDAE4UR;Initial Catalog=Session1_XX;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
}
