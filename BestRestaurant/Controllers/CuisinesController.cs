using Microsoft.AspNetCore.Mvc;
using BestRestaurant.Models;
using System.Collections.Generic;
using System.Linq;
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AnimalShelter.Controllers
{
    public class CuisinesController : Controller
    {
        private readonly BestRestaurantContext _db;
        public CuisinesController(BestRestaurantContext db)
        {
            _db = db;
        }
        public ActionResult Index()
        {
            List<Cuisine> model = _db.Cuisines.Include(cuisines => cuisines.Restaurant).ToList();
            return View(model);
        }
        public ActionResult Create()
        {
            ViewBag.RestaurantId = new SelectList(_db.Restaurant, "RestaurantId", "Name");
            return View();
        }
        [HttpPost]
        public ActionResult Create(Cuisine cuisine)
        {   
            _db.Cuisines.Add(cuisine);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Details(int id)
        {
            Cuisine thisCuisine = _db.Cuisines.FirstOrDefault(cuisine => cuisine.CuisineId == id);
            Restaurant thisRestaurant = _db.Restaurant.FirstOrDefault(restaurant => restaurant.RestaurantId == thisCuisine.RestaurantId);
            ViewBag.Restaurant = thisRestaurant.Name;
            return View(thisCuisine);
        }
        public ActionResult Edit(int id)
        {
            var thisCuisine = _db.Cuisines.FirstOrDefault(cuisines => cuisines.CuisineId == id);
            ViewBag.RestaurantId = new SelectList(_db.Restaurant, "RestaurantId", "Name");
            return View(thisCuisine);
        }
        [HttpPost]
        public ActionResult Edit(Cuisine cuisine)
        {
            _db.Entry(cuisine).State = EntityState.Modified;
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            var thisCuisine = _db.Cuisines.FirstOrDefault(cuisines => cuisines.CuisineId == id);
            return View(thisCuisine);
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var thisCuisine = _db.Cuisines.FirstOrDefault(cuisines => cuisines.CuisineId == id);
            _db.Cuisines.Remove(thisCuisine);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
