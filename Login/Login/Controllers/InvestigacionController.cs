using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Login.Models;

namespace Login.Controllers
{
    public class InvestigacionController : Controller
    {
        private listaProductosEntities db = new listaProductosEntities();

        // GET: Investigacion
        public ActionResult Index()
        {
            return View(db.Investigacios.ToList());
        }

        // GET: Investigacion/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Investigacio investigacio = db.Investigacios.Find(id);
            if (investigacio == null)
            {
                return HttpNotFound();
            }
            return View(investigacio);
        }

        // GET: Investigacion/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Investigacion/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "index,N_,Tema_Investigación_,Responsables_,Fecha_inicio,Estado,Fecha_Termino,Chile,Panamá_,Guatemala,Honduras,El_Salvador,Link_1,Link_2,id")] Investigacio investigacio)
        {
            if (ModelState.IsValid)
            {
                db.Investigacios.Add(investigacio);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(investigacio);
        }

        // GET: Investigacion/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Investigacio investigacio = db.Investigacios.Find(id);
            if (investigacio == null)
            {
                return HttpNotFound();
            }
            return View(investigacio);
        }

        // POST: Investigacion/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "index,N_,Tema_Investigación_,Responsables_,Fecha_inicio,Estado,Fecha_Termino,Chile,Panamá_,Guatemala,Honduras,El_Salvador,Link_1,Link_2,id")] Investigacio investigacio)
        {
            if (ModelState.IsValid)
            {
                db.Entry(investigacio).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(investigacio);
        }

        // GET: Investigacion/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Investigacio investigacio = db.Investigacios.Find(id);
            if (investigacio == null)
            {
                return HttpNotFound();
            }
            return View(investigacio);
        }

        // POST: Investigacion/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Investigacio investigacio = db.Investigacios.Find(id);
            db.Investigacios.Remove(investigacio);
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
