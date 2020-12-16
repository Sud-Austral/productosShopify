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
    public class D_INVESTIGACIONController : Controller
    {
        private listaProductosOriginal db = new listaProductosOriginal();

        // GET: D_INVESTIGACION
        public ActionResult Index()
        {
            var d_INVESTIGACION = db.D_INVESTIGACION.Include(d => d.D_Data);
            return View(d_INVESTIGACION.ToList());
        }

        // GET: D_INVESTIGACION/Details/5
        public ActionResult Details(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            D_INVESTIGACION d_INVESTIGACION = db.D_INVESTIGACION.Find(id);
            if (d_INVESTIGACION == null)
            {
                return HttpNotFound();
            }
            return View(d_INVESTIGACION);
        }

        // GET: D_INVESTIGACION/Create
        public ActionResult Create()
        {
            ViewBag.D_Data_id_data = new SelectList(db.D_Data, "id", "data");
            return View();
        }

        // POST: D_INVESTIGACION/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,numero,tema,responsable,fecha_inicio,fecha_avance,fecha_termino,comentario,accion,seguimiento,D_Data_id_data")] D_INVESTIGACION d_INVESTIGACION)
        {
            if (ModelState.IsValid)
            {
                db.D_INVESTIGACION.Add(d_INVESTIGACION);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.D_Data_id_data = new SelectList(db.D_Data, "id", "data", d_INVESTIGACION.D_Data_id_data);
            return View(d_INVESTIGACION);
        }

        // GET: D_INVESTIGACION/Edit/5
        public ActionResult Edit(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            D_INVESTIGACION d_INVESTIGACION = db.D_INVESTIGACION.Find(id);
            if (d_INVESTIGACION == null)
            {
                return HttpNotFound();
            }
            ViewBag.D_Data_id_data = new SelectList(db.D_Data, "id", "data", d_INVESTIGACION.D_Data_id_data);
            return View(d_INVESTIGACION);
        }

        // POST: D_INVESTIGACION/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,numero,tema,responsable,fecha_inicio,fecha_avance,fecha_termino,comentario,accion,seguimiento,D_Data_id_data")] D_INVESTIGACION d_INVESTIGACION)
        {
            if (ModelState.IsValid)
            {
                db.Entry(d_INVESTIGACION).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.D_Data_id_data = new SelectList(db.D_Data, "id", "data", d_INVESTIGACION.D_Data_id_data);
            return View(d_INVESTIGACION);
        }

        // GET: D_INVESTIGACION/Delete/5
        public ActionResult Delete(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            D_INVESTIGACION d_INVESTIGACION = db.D_INVESTIGACION.Find(id);
            if (d_INVESTIGACION == null)
            {
                return HttpNotFound();
            }
            return View(d_INVESTIGACION);
        }

        // POST: D_INVESTIGACION/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(decimal id)
        {
            D_INVESTIGACION d_INVESTIGACION = db.D_INVESTIGACION.Find(id);
            db.D_INVESTIGACION.Remove(d_INVESTIGACION);
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
