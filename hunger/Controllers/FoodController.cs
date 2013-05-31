using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataAccessLayer.Db;

namespace hunger.Controllers
{
    [Authorize]
    public class FoodController : Controller
    {
        private foodDbContext db = new foodDbContext();

        //
        // GET: /Food/

        public ActionResult Index()
        {
            return View(db.Foods.ToList());
        }

        //
        // GET: /Food/Details/5

        public ActionResult Details(int id = 0)
        {
            Food food = db.Foods.Find(id);
            if (food == null)
            {
                return HttpNotFound();
            }
            return View(food);
        }

        //
        // GET: /Food/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Food/Create

        [HttpPost]
        public ActionResult Create(Food food)
        {
            if (ModelState.IsValid)
            {
                db.Foods.Add(food);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(food);
        }

        //
        // GET: /Food/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Food food = db.Foods.Find(id);
            if (food == null)
            {
                return HttpNotFound();
            }
            return View(food);
        }

        //
        // POST: /Food/Edit/5

        [HttpPost]
        public ActionResult Edit(Food food)
        {
            if (ModelState.IsValid)
            {
                db.Entry(food).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(food);
        }

        //
        // GET: /Food/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Food food = db.Foods.Find(id);
            if (food == null)
            {
                return HttpNotFound();
            }
            return View(food);
        }

        //
        // POST: /Food/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Food food = db.Foods.Find(id);
            db.Foods.Remove(food);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}