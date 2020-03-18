using Microsoft.EntityFrameworkCore;

namespace BestRestaurant.Models
{
  public class BestRestaurantContext : DbContext
  {

    public virtual DbSet<Restaurant> Restaurant {get; set; }
    public DbSet<Cuisine> Cuisines { get; set; }
    public BestRestaurantContext(DbContextOptions options) : base(options) {}
  }
}