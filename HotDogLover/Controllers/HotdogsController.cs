using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HotDogLover.Models;

namespace HotDogLover.Controllers
{
    public class HotdogsController : Controller
    {
        private HotDogLover.Models.Hotdog.HotDogLoverContext db = new HotDogLover.Models.Hotdog.HotDogLoverContext();

        // GET: Hotdogs
        public ActionResult Index()
        {
            return View(db.Hotdogs.ToList());
        }

        // GET: Hotdogs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hotdog hotdog = db.Hotdogs.Find(id);
            if (hotdog == null)
            {
                return HttpNotFound();
            }
            return View(hotdog);
        }

        // GET: Hotdogs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Hotdogs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Type,Date")] Hotdog hotdog)
        {
            if (ModelState.IsValid)
            {
                db.Hotdogs.Add(hotdog);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(hotdog);
        }

        // GET: Hotdogs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hotdog hotdog = db.Hotdogs.Find(id);
            if (hotdog == null)
            {
                return HttpNotFound();
            }
            return View(hotdog);
        }

        // POST: Hotdogs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Type,Date")] Hotdog hotdog)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hotdog).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(hotdog);
        }

        // GET: Hotdogs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hotdog hotdog = db.Hotdogs.Find(id);
            if (hotdog == null)
            {
                return HttpNotFound();
            }
            return View(hotdog);
        }

        // POST: Hotdogs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Hotdog hotdog = db.Hotdogs.Find(id);
            db.Hotdogs.Remove(hotdog);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
