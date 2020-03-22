using Microsoft.AspNetCore.Mvc;
using BestRestaurant.Models;
using System.Collections.Generic;
using System.Linq;
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using MySql.Data.MySqlClient;


namespace BestRestaurant.Controllers
{
    public class SeattleController : Controller
    {
        private readonly BestRestaurantContext _db;
        public SeattleController(BestRestaurantContext db)
        {
            _db = db;
        }
        public ActionResult Index()
        {   
            // ViewBag.Restaurants = (List<Restaurant>) _db.Restaurants.ToList();
            List<Seattle> model = _db.Seattle.ToList();
            return View(model);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Seattle seattle)
        {
            try {
                _db.Seattle.Add(seattle);
                _db.SaveChanges();
            } catch (DbUpdateException e) {
                TempData["ErrorMessage"]="Duplicate Area";
            }
            return RedirectToAction("Index");
        }
        public ActionResult Details(int id)
        {
            Seattle thisSeattle = _db.Seattle.FirstOrDefault(seattle => seattle.SeattleId == id);
            return View(thisSeattle);
        }
        public ActionResult Edit(int id)
        {
            Seattle thisSeattle = _db.Seattle.FirstOrDefault(seattle => seattle.SeattleId == id);
            return View(thisSeattle);
        }
        [HttpPost]
        public ActionResult Edit(Seattle seattle)
        {
            _db.Entry(seattle).State = EntityState.Modified;
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            Seattle thisSeattle = _db.Seattle.FirstOrDefault(seattle => seattle.SeattleId == id);
            return View(thisSeattle);
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Seattle thisSeattle = _db.Seattle.FirstOrDefault(seattle => seattle.SeattleId == id);
            _db.Seattle.Remove(thisSeattle);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Search(int id)
        {
            List<Restaurant> thisRestaurants = _db.Restaurants.Where(Restaurant => Restaurant.SeattleId == id).ToList();
            Seattle thisSeattle = _db.Seattle.FirstOrDefault(seattle => seattle.SeattleId == id);
            ViewBag.AreaName = thisSeattle.AreaName;
            return View(thisRestaurants);
        }
    }
}