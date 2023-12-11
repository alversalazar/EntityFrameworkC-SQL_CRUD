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
    public class StudyPlanController : Controller
    {
        private Vinculation db = new Vinculation();

        // GET: StudyPlan
        public ActionResult Index()
        {
            return View(db.studyplan.ToList());
        }

        // GET: StudyPlan/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudyPlan studyPlan = db.studyplan.Find(id);
            if (studyPlan == null)
            {
                return HttpNotFound();
            }
            return View(studyPlan);
        }

        // GET: StudyPlan/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudyPlan/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idStudyPlan,objetive,starDate,finalDate,key1,status,idCareer")] StudyPlan studyPlan)
        {
            if (ModelState.IsValid)
            {
                db.studyplan.Add(studyPlan);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(studyPlan);
        }

        // GET: StudyPlan/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudyPlan studyPlan = db.studyplan.Find(id);
            if (studyPlan == null)
            {
                return HttpNotFound();
            }
            return View(studyPlan);
        }

        // POST: StudyPlan/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idStudyPlan,objetive,starDate,finalDate,key1,status,idCareer")] StudyPlan studyPlan)
        {
            if (ModelState.IsValid)
            {
                db.Entry(studyPlan).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(studyPlan);
        }

        // GET: StudyPlan/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudyPlan studyPlan = db.studyplan.Find(id);
            if (studyPlan == null)
            {
                return HttpNotFound();
            }
            return View(studyPlan);
        }

        // POST: StudyPlan/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            StudyPlan studyPlan = db.studyplan.Find(id);
            db.studyplan.Remove(studyPlan);
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
