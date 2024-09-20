using FanurApp.Models;
using Microsoft.EntityFrameworkCore;

namespace FanurApp.Data;

public class ApplicationContext : DbContext
{
    public DbSet<Culture> Cultures { get; set; }
    public DbSet<Resource> Resources { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Culture>().HasData(
            new List<Culture>
            {
                new Culture
                {
                    Id = 1,
                    Name = "en"
                },
                new Culture
                {
                    Id = 2,
                    Name = "ru"
                }
            }
        );
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source = FanurDB.db");
    }
}