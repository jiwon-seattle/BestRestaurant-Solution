using System;

namespace BestRestaurant.Models
{
    public class Restaurant
    {
        public int RestaurantId {get; set;}
        public int SeattleId {get; set;}
        public virtual Seattle Seattle {get; set;}
        public string RestaurantName;
        public string Location;
        public string Type;
        public string MainMenu;
        public int Rating;

    }
}