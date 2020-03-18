using Microsoft.EntityFrameworkCore;

namespace BestRestaurant.Models
{
  public class BestRestaurantContext : DbContext
  {

    public virtual DbSet<Seattle> Seattle{get; set; }
    public DbSet<Restaurant> Restaurants { get; set; }
    public BestRestaurantContext(DbContextOptions options) : base(options) {}
  }
}