using Microsoft.EntityFrameworkCore;
using WebApiIntro.Entites;

namespace WebApiIntro.Context;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Region> Regions { get; set; }
    public DbSet<Categories> Categories { get; set; }
}