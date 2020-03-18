using Microsoft.AspNetCore.Mvc;
using BestRestaurant.Models;
using System.Collections.Generic;
using System.Linq;
using Miscrosoft.EntityFrameworkCore;
using Miscrosoft.AspNetCore.Mvc.Rendering;

namespace BestRestaurant.Controllers
{
    public class RestaurantController : Controller
    {
        private readonly BestRestaurantContext _db;
        public RestaurantController(BestRestaurantContext db)
        {
            _db = db;
        }
        public ActionResult IndeX()
        {
            List<Restaurant> model = _db.Restaurant.ToList();
            return View(model);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Restaurant restaurant)
        {
            _db.Restaurant.Add(restaurant);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionRsult Details(int id)
        {
            Restaurant thisRestaurant = _db.Restaurant.FirstOrDefault(restaurant => restaurant.RestaurantId == id);
            return View(thisRestaurant);
        }
        public ActionResult Edit(int id)
        {
            Restaurant thisRestaurant = _db.Restaurant.FirstOrDefault(restaurant => restaurant.RestaurantId == id);
        }
        [HttpPost]
        public ActionResult Edit(Restaurant restaurant)
        {
            _db.Entry(Restaurant).State = EntityState.Modified;
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            Restaurant thisRestaurant = _db.Restaurant.FirstOrDefault(restaurant => restaurant.RestaurantId == id);
            return View(thisRestaurant);
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Restaurant thisRestaurant = _db.Restaurant.FirstOrDefault(restaurant => restaurant.RestaurantId == id)
            _db.Restaurant.Remove(thisRestaurant);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}