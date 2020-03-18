using Microsoft.AspNetCore.Mvc;
using BestRestaurant.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;


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
            if(seattle.AreaName == "")
            {
                _db.SaveChanges();
            }
            else
            {
                _db.Seattle.Add(seattle);
                _db.SaveChanges();
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
    }
}