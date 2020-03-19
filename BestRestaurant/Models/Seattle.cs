using System.Collections.Generic;

namespace BestRestaurant.Models
{
    public class Seattle
    {
        public Seattle()
        {
            this.Restaurants = new HashSet<Restaurant>();
        }
        public int SeattleId {get; set;}
        public string AreaName {get; set;}
        
        public virtual ICollection<Restaurant> Restaurants {get; set;}
    }

}