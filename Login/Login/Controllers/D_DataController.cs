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
    public class D_DataController : Controller
    {
        private listaProductosEntities1 db = new listaProductosEntities1();

        // GET: D_Data
        public ActionResult Index()
        {
            return View(db.D_Data.ToList());
        }

        // GET: D_Data/Details/5
        public ActionResult Details(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            D_Data d_Data = db.D_Data.Find(id);
            if (d_Data == null)
            {
                return HttpNotFound();
            }
            return View(d_Data);
        }

        // GET: D_Data/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: D_Data/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,data,id_data,estado,desarrollo,investigacion,descripcion,slogan,vista,repositorio_dropbox,logo")] D_Data d_Data)
        {
            if (ModelState.IsValid)
            {
                db.D_Data.Add(d_Data);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(d_Data);
        }

        // GET: D_Data/Edit/5
        public ActionResult Edit(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            D_Data d_Data = db.D_Data.Find(id);
            if (d_Data == null)
            {
                return HttpNotFound();
            }
            return View(d_Data);
        }

        // POST: D_Data/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,data,id_data,estado,desarrollo,investigacion,descripcion,slogan,vista,repositorio_dropbox,logo")] D_Data d_Data)
        {
            if (ModelState.IsValid)
            {
                db.Entry(d_Data).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(d_Data);
        }

        // GET: D_Data/Delete/5
        public ActionResult Delete(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            D_Data d_Data = db.D_Data.Find(id);
            if (d_Data == null)
            {
                return HttpNotFound();
            }
            return View(d_Data);
        }

        // POST: D_Data/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(decimal id)
        {
            D_Data d_Data = db.D_Data.Find(id);
            db.D_Data.Remove(d_Data);
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
