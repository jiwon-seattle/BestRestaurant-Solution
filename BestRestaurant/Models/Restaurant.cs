using System;

namespace BestRestaurant.Models
{
    public class Restaurant
    {
        public int RestaurantId {get; set;}
        public int SeattleId {get; set;}
        public virtual Seattle Seattle {get; set;}
        public string RestaurantName {get; set;}
        public string Location {get; set;}
        public string Type {get; set;}
        public string MainMenu {get; set;}
        public int Rating {get; set;}

    }
}