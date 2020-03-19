using Microsoft.AspNetCore.Mvc;
using BestRestaurant.Models;
using System.Collections.Generic;
using System.Linq;
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BestRestaurant.Controllers
{
    public class RestaurantsController : Controller
    {
        private readonly BestRestaurantContext _db;
        public RestaurantsController(BestRestaurantContext db)
        {
            _db = db;
        }
        public ActionResult Index()
        {
            List<Restaurant> model = _db.Restaurants.Include(restaurant => restaurant.Seattle).ToList();
            return View(model);
        }
        public ActionResult Create()
        {
            ViewBag.SeattleId = new SelectList(_db.Seattle, "SeattleId", "AreaName");
            return View();
        }
        [HttpPost]
        public ActionResult Create(Restaurant restaurant)
        {   
            if(restaurant.RestaurantName == "")
            {
                _db.SaveChanges();
            }
            else
            {
                _db.Restaurants.Add(restaurant);
                _db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        public ActionResult Details(int id)
        {
            Restaurant thisRestaurant = _db.Restaurants.FirstOrDefault(restaurant => restaurant.RestaurantId == id);
            Seattle thisSeattle = _db.Seattle.FirstOrDefault(seattle => seattle.SeattleId == thisRestaurant.SeattleId);
            ViewBag.Seattle = thisSeattle.AreaName;
            return View(thisRestaurant);
        }
        public ActionResult Edit(int id)
        {
            var thisRestaurant = _db.Restaurants.FirstOrDefault(restaurant => restaurant.RestaurantId == id);
            ViewBag.SeattleId = new SelectList(_db.Seattle, "SeattleId", "AreaName");
            return View(thisRestaurant);
        }
        [HttpPost]
        public ActionResult Edit(Restaurant restaurant)
        {
            _db.Entry(restaurant).State = EntityState.Modified;
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            var thisRestaurant = _db.Restaurants.FirstOrDefault(restaurant => restaurant.RestaurantId == id);
            return View(thisRestaurant);
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var thisRestaurant = _db.Restaurants.FirstOrDefault(restaurant => restaurant.RestaurantId == id);
            _db.Restaurants.Remove(thisRestaurant);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
