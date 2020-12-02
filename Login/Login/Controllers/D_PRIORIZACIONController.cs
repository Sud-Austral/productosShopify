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
    public class D_PRIORIZACIONController : Controller
    {
        private listaProductosEntities1 db = new listaProductosEntities1();

        // GET: D_PRIORIZACION
        public ActionResult Index()
        {
            var d_PRIORIZACION = db.D_PRIORIZACION.Include(d => d.D_Data);
            return View(d_PRIORIZACION.ToList());
        }

        // GET: D_PRIORIZACION/Details/5
        public ActionResult Details(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            D_PRIORIZACION d_PRIORIZACION = db.D_PRIORIZACION.Find(id);
            if (d_PRIORIZACION == null)
            {
                return HttpNotFound();
            }
            return View(d_PRIORIZACION);
        }

        // GET: D_PRIORIZACION/Create
        public ActionResult Create()
        {
            ViewBag.D_Data_id_data = new SelectList(db.D_Data, "id", "data");
            return View();
        }

        // POST: D_PRIORIZACION/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,producto_previo,nombre,secuencia,pais,integrado,id_producto,prioridad,estado,avance,responsable_desarrollo,responsable_informacion,tecnologia,tarea,db,plataforma,control_calidad,odoo,shopify,fecha_estimada,fecha_actualizacion,D_Data_id_data")] D_PRIORIZACION d_PRIORIZACION)
        {
            if (ModelState.IsValid)
            {
                db.D_PRIORIZACION.Add(d_PRIORIZACION);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.D_Data_id_data = new SelectList(db.D_Data, "id", "data", d_PRIORIZACION.D_Data_id_data);
            return View(d_PRIORIZACION);
        }

        // GET: D_PRIORIZACION/Edit/5
        public ActionResult Edit(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            D_PRIORIZACION d_PRIORIZACION = db.D_PRIORIZACION.Find(id);
            if (d_PRIORIZACION == null)
            {
                return HttpNotFound();
            }
            ViewBag.D_Data_id_data = new SelectList(db.D_Data, "id", "data", d_PRIORIZACION.D_Data_id_data);
            return View(d_PRIORIZACION);
        }

        // POST: D_PRIORIZACION/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,producto_previo,nombre,secuencia,pais,integrado,id_producto,prioridad,estado,avance,responsable_desarrollo,responsable_informacion,tecnologia,tarea,db,plataforma,control_calidad,odoo,shopify,fecha_estimada,fecha_actualizacion,D_Data_id_data")] D_PRIORIZACION d_PRIORIZACION)
        {
            if (ModelState.IsValid)
            {
                db.Entry(d_PRIORIZACION).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.D_Data_id_data = new SelectList(db.D_Data, "id", "data", d_PRIORIZACION.D_Data_id_data);
            return View(d_PRIORIZACION);
        }

        // GET: D_PRIORIZACION/Delete/5
        public ActionResult Delete(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            D_PRIORIZACION d_PRIORIZACION = db.D_PRIORIZACION.Find(id);
            if (d_PRIORIZACION == null)
            {
                return HttpNotFound();
            }
            return View(d_PRIORIZACION);
        }

        // POST: D_PRIORIZACION/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(decimal id)
        {
            D_PRIORIZACION d_PRIORIZACION = db.D_PRIORIZACION.Find(id);
            db.D_PRIORIZACION.Remove(d_PRIORIZACION);
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
