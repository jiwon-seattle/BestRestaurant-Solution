using Microsoft.EntityFrameworkCore;

namespace BestRestaurant.Models
{
    public class BestRestaurantContext : DbContext
    {
        public virtual DbSet<Restaurant> Restaurant {get; set;}
        public DBSet<Cuisine> Cuisines {get; set;}
        public BestRestaurantContext(DbContextOptions options) : base(option) {}
    }
}