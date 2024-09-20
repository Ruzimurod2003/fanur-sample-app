using FanurApp.Models;
using Microsoft.EntityFrameworkCore;

namespace FanurApp.Data;

public class ApplicationContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Culture> Cultures { get; set; }
    public DbSet<Resource> Resources { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().HasData(
            new List<User>
            {
                new User
                {
                    Id = 1,
                    Email = "ruzimurodabdunazarov2003@mail.ru",
                    Name = "Ruzimurod Abdunazarov",
                    Password = "parol2003"
                },
                new User
                {
                    Id = 3,
                    Email = "farrukhkarshibayev@gmail.com",
                    Name = "Farrukh",
                    Password = "20.08.2001"
                }
            }
        );
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source = FanurDB.db");
    }
}