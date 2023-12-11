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
    public class ViaticController : Controller
    {
        private Vinculation db = new Vinculation();

        // GET: Viatic
        public ActionResult Index()
        {
            return View(db.viatic.ToList());
        }

        // GET: Viatic/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Viatic viatic = db.viatic.Find(id);
            if (viatic == null)
            {
                return HttpNotFound();
            }
            return View(viatic);
        }

        // GET: Viatic/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Viatic/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idViatic,place,description1,amount,idEmployee,status")] Viatic viatic)
        {
            if (ModelState.IsValid)
            {
                db.viatic.Add(viatic);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(viatic);
        }

        // GET: Viatic/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Viatic viatic = db.viatic.Find(id);
            if (viatic == null)
            {
                return HttpNotFound();
            }
            return View(viatic);
        }

        // POST: Viatic/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idViatic,place,description1,amount,idEmployee,status")] Viatic viatic)
        {
            if (ModelState.IsValid)
            {
                db.Entry(viatic).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(viatic);
        }

        // GET: Viatic/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Viatic viatic = db.viatic.Find(id);
            if (viatic == null)
            {
                return HttpNotFound();
            }
            return View(viatic);
        }

        // POST: Viatic/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Viatic viatic = db.viatic.Find(id);
            db.viatic.Remove(viatic);
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
