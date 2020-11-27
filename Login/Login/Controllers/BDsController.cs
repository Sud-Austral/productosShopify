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
    public class BDsController : Controller
    {
        private listaProductosEntities db = new listaProductosEntities();

        // GET: BDs
        public ActionResult Index()
        {
            return View(db.BDs.ToList());
        }

        // GET: BDs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BD bD = db.BDs.Find(id);
            if (bD == null)
            {
                return HttpNotFound();
            }
            return View(bD);
        }

        // GET: BDs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BDs/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "index,Unnamed__0,Data,Estado,Fecha_Actualización_,Responsable,Tema,Observación_,Acción,Monitoreo,id")] BD bD)
        {
            if (ModelState.IsValid)
            {
                db.BDs.Add(bD);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bD);
        }

        // GET: BDs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BD bD = db.BDs.Find(id);
            if (bD == null)
            {
                return HttpNotFound();
            }
            return View(bD);
        }

        // POST: BDs/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "index,Unnamed__0,Data,Estado,Fecha_Actualización_,Responsable,Tema,Observación_,Acción,Monitoreo,id")] BD bD)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bD).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bD);
        }

        // GET: BDs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BD bD = db.BDs.Find(id);
            if (bD == null)
            {
                return HttpNotFound();
            }
            return View(bD);
        }

        // POST: BDs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BD bD = db.BDs.Find(id);
            db.BDs.Remove(bD);
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
