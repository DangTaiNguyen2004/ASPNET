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
    public class DtnProductsController : Controller
    {
        private DtnK22CNT4Lesson11DbEntities db = new DtnK22CNT4Lesson11DbEntities();

        // GET: DtnProducts
        public ActionResult DtnIndex()
        {
            return View(db.DtnProduct.ToList());
        }

        // GET: DtnProducts/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DtnProduct dtnProduct = db.DtnProduct.Find(id);
            if (dtnProduct == null)
            {
                return HttpNotFound();
            }
            return View(dtnProduct);
        }

        // GET: DtnProducts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DtnProducts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Dtnid2210900052,DtnProName,DtnQty,DtnPrice,DtnCateId,DtnActive")] DtnProduct dtnProduct)
        {
            if (ModelState.IsValid)
            {
                db.DtnProduct.Add(dtnProduct);
                db.SaveChanges();
                return RedirectToAction("DtnIndex");
            }

            return View(dtnProduct);
        }

        // GET: DtnProducts/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DtnProduct dtnProduct = db.DtnProduct.Find(id);
            if (dtnProduct == null)
            {
                return HttpNotFound();
            }
            return View(dtnProduct);
        }

        // POST: DtnProducts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Dtnid2210900052,DtnProName,DtnQty,DtnPrice,DtnCateId,DtnActive")] DtnProduct dtnProduct)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dtnProduct).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dtnProduct);
        }

        // GET: DtnProducts/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DtnProduct dtnProduct = db.DtnProduct.Find(id);
            if (dtnProduct == null)
            {
                return HttpNotFound();
            }
            return View(dtnProduct);
        }

        // POST: DtnProducts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            DtnProduct dtnProduct = db.DtnProduct.Find(id);
            db.DtnProduct.Remove(dtnProduct);
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
