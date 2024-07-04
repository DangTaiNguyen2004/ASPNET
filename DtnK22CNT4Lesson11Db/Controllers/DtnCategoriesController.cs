using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DtnK22CNT4Lesson11Db.Models;

namespace DtnK22CNT4Lesson11Db.Controllers
{
    public class DtnCategoriesController : Controller
    {
        private DtnK22CNT4Lesson11DbEntities db = new DtnK22CNT4Lesson11DbEntities();

        // GET: DtnCategories
        public ActionResult DtnIndex()
        {
            return View(db.DtnCategory.ToList());
        }

        // GET: DtnCategories/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DtnCategory dtnCategory = db.DtnCategory.Find(id);
            if (dtnCategory == null)
            {
                return HttpNotFound();
            }
            return View(dtnCategory);
        }

        // GET: DtnCategories/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DtnCategories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DtnID,DtnCateName,DtnStatus")] DtnCategory dtnCategory)
        {
            if (ModelState.IsValid)
            {
                db.DtnCategory.Add(dtnCategory);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dtnCategory);
        }

        // GET: DtnCategories/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DtnCategory dtnCategory = db.DtnCategory.Find(id);
            if (dtnCategory == null)
            {
                return HttpNotFound();
            }
            return View(dtnCategory);
        }

        // POST: DtnCategories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DtnID,DtnCateName,DtnStatus")] DtnCategory dtnCategory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dtnCategory).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dtnCategory);
        }

        // GET: DtnCategories/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DtnCategory dtnCategory = db.DtnCategory.Find(id);
            if (dtnCategory == null)
            {
                return HttpNotFound();
            }
            return View(dtnCategory);
        }

        // POST: DtnCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DtnCategory dtnCategory = db.DtnCategory.Find(id);
            db.DtnCategory.Remove(dtnCategory);
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
