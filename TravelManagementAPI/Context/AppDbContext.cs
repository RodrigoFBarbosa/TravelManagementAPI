using Microsoft.EntityFrameworkCore;
using TravelManagementAPI.Models;

namespace TravelManagementAPI.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
    {

    }

    public DbSet<Travel> Travels { get; set; }
    public DbSet<Expense> Expenses { get; set; }
    public DbSet<Location> Locations { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }

}
