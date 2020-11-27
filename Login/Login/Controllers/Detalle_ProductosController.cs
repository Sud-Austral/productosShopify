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
    public class Detalle_ProductosController : Controller
    {
        private listaProductosEntities db = new listaProductosEntities();

        // GET: Detalle_Productos
        public ActionResult Index()
        {
            return View(db.Detalle_Productos.ToList());
        }

        // GET: Detalle_Productos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Detalle_Productos detalle_Productos = db.Detalle_Productos.Find(id);
            if (detalle_Productos == null)
            {
                return HttpNotFound();
            }
            return View(detalle_Productos);
        }

        // GET: Detalle_Productos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Detalle_Productos/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "index,Unnamed__0,Data,id_producto,Plazo_Producto,Producto,Secciones,Sub_secciones,Variables,Fuente,Situación_Variable,Fecha_Actualización,Observaciones,id")] Detalle_Productos detalle_Productos)
        {
            if (ModelState.IsValid)
            {
                db.Detalle_Productos.Add(detalle_Productos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(detalle_Productos);
        }

        // GET: Detalle_Productos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Detalle_Productos detalle_Productos = db.Detalle_Productos.Find(id);
            if (detalle_Productos == null)
            {
                return HttpNotFound();
            }
            return View(detalle_Productos);
        }

        // POST: Detalle_Productos/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "index,Unnamed__0,Data,id_producto,Plazo_Producto,Producto,Secciones,Sub_secciones,Variables,Fuente,Situación_Variable,Fecha_Actualización,Observaciones,id")] Detalle_Productos detalle_Productos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(detalle_Productos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(detalle_Productos);
        }

        // GET: Detalle_Productos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Detalle_Productos detalle_Productos = db.Detalle_Productos.Find(id);
            if (detalle_Productos == null)
            {
                return HttpNotFound();
            }
            return View(detalle_Productos);
        }

        // POST: Detalle_Productos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Detalle_Productos detalle_Productos = db.Detalle_Productos.Find(id);
            db.Detalle_Productos.Remove(detalle_Productos);
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
