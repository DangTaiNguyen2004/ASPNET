using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using dtnBaiKiemTraGK.Models;

namespace dtnBaiKiemTraGK.Controllers
{
    public class DtnKhoasController : Controller
    {
        private DtnK22CNT4Lesson07DfEntities db = new DtnK22CNT4Lesson07DfEntities();

        // GET: DtnKhoas
        public ActionResult DtnIndex()
        {
            return View(db.DtnKhoa.ToList());
        }

        // GET: DtnKhoas/Details/5
        public ActionResult DtnDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DtnKhoa dtnKhoa = db.DtnKhoa.Find(id);
            if (dtnKhoa == null)
            {
                return HttpNotFound();
            }
            return View(dtnKhoa);
        }

        // GET: DtnKhoas/Create
        public ActionResult DtnCreate()
        {
            return View();
        }

        // POST: DtnKhoas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DtnCreate([Bind(Include = "DtnMaKH,DtnTenMK,DtnTrangThai")] DtnKhoa dtnKhoa)
        {
            if (ModelState.IsValid)
            {
                db.DtnKhoa.Add(dtnKhoa);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dtnKhoa);
        }

        // GET: DtnKhoas/Edit/5
        public ActionResult DtnEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DtnKhoa dtnKhoa = db.DtnKhoa.Find(id);
            if (dtnKhoa == null)
            {
                return HttpNotFound();
            }
            return View(dtnKhoa);
        }

        // POST: DtnKhoas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DtnEdit([Bind(Include = "DtnMaKH,DtnTenMK,DtnTrangThai")] DtnKhoa dtnKhoa)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dtnKhoa).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dtnKhoa);
        }

        // GET: DtnKhoas/Delete/5
        public ActionResult DtnDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DtnKhoa dtnKhoa = db.DtnKhoa.Find(id);
            if (dtnKhoa == null)
            {
                return HttpNotFound();
            }
            return View(dtnKhoa);
        }

        // POST: DtnKhoas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DtnDeleteConfirmed(string id)
        {
            DtnKhoa dtnKhoa = db.DtnKhoa.Find(id);
            db.DtnKhoa.Remove(dtnKhoa);
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
