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
    public class PrioridadsController : Controller
    {
        private listaProductosEntities db = new listaProductosEntities();

        // GET: Prioridads
        public ActionResult Index()
        {
            return View(db.Prioridads.ToList());
        }

        // GET: Prioridads/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Prioridad prioridad = db.Prioridads.Find(id);
            if (prioridad == null)
            {
                return HttpNotFound();
            }
            return View(prioridad);
        }

        // GET: Prioridads/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Prioridads/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "index,Unnamed__0,Data,Producto_Previos,Secuencia,País,Integrado_PRODUCTOS,id_producto,Prioridad1,Estado,Avance,Responsable_Desarrollo,Responsable_Información,Tecnología,Tareas_Elementos,Columna1,Tecnología2,Fecha_estimada,id,Fecha_Actualizacion")] Prioridad prioridad)
        {
            if (ModelState.IsValid)
            {
                db.Prioridads.Add(prioridad);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(prioridad);
        }

        // GET: Prioridads/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Prioridad prioridad = db.Prioridads.Find(id);
            if (prioridad == null)
            {
                return HttpNotFound();
            }
            return View(prioridad);
        }

        // POST: Prioridads/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "index,Unnamed__0,Data,Producto_Previos,Secuencia,País,Integrado_PRODUCTOS,id_producto,Prioridad1,Estado,Avance,Responsable_Desarrollo,Responsable_Información,Tecnología,Tareas_Elementos,Columna1,Tecnología2,Fecha_estimada,id,Fecha_Actualizacion")] Prioridad prioridad)
        {
            if (ModelState.IsValid)
            {
                db.Entry(prioridad).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(prioridad);
        }

        // GET: Prioridads/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Prioridad prioridad = db.Prioridads.Find(id);
            if (prioridad == null)
            {
                return HttpNotFound();
            }
            return View(prioridad);
        }

        // POST: Prioridads/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Prioridad prioridad = db.Prioridads.Find(id);
            db.Prioridads.Remove(prioridad);
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
