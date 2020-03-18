using System;

namespace BestRestaurant.Models
{
    public class Cuisine
    {
        public int CuisineId {get; set;}
        public int RestaurantId {get; set;}
        public virtual Restaurant Restaurant {get; set;}
        public string Name;
        public string Description;
        // public List<string> Ingredients {get; set;}
    }
}