using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NetC__CRUD.Models;

namespace NetC__CRUD.Controllers
{
    public class CareerController : Controller
    {
        private Vinculation db = new Vinculation();

        // GET: Career
        public ActionResult Index()
        {
            return View(db.career.ToList());
        }

        // GET: Career/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Career career = db.career.Find(id);
            if (career == null)
            {
                return HttpNotFound();
            }
            return View(career);
        }

        // GET: Career/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Career/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idCareer,name,duration,description,status")] Career career)
        {
            if (ModelState.IsValid)
            {
                db.career.Add(career);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(career);
        }

        // GET: Career/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Career career = db.career.Find(id);
            if (career == null)
            {
                return HttpNotFound();
            }
            return View(career);
        }

        // POST: Career/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idCareer,name,duration,description,status")] Career career)
        {
            if (ModelState.IsValid)
            {
                db.Entry(career).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(career);
        }

        // GET: Career/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Career career = db.career.Find(id);
            if (career == null)
            {
                return HttpNotFound();
            }
            return View(career);
        }

        // POST: Career/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Career career = db.career.Find(id);
            db.career.Remove(career);
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
