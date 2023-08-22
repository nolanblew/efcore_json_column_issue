using EFCoreTest.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCoreTest;

public class DatabaseContext : DbContext
{
    public DatabaseContext(DbContextOptions options)
    : base(options) { }

    public DbSet<Person> People { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Person>().Property(p => p.Id).UseIdentityColumn();
        builder.Entity<Person>().OwnsMany(p => p.Pets, navBuilder =>
        {
            navBuilder.ToJson();
            navBuilder.OwnsMany(pet => pet.AcceptableFood);
        });
    }
}
