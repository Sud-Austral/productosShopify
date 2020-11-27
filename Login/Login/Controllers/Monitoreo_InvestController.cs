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
    public class Monitoreo_InvestController : Controller
    {
        private listaProductosEntities db = new listaProductosEntities();

        // GET: Monitoreo_Invest
        public ActionResult Index()
        {
            return View(db.Monitoreo_Invest.ToList());
        }

        // GET: Monitoreo_Invest/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Monitoreo_Invest monitoreo_Invest = db.Monitoreo_Invest.Find(id);
            if (monitoreo_Invest == null)
            {
                return HttpNotFound();
            }
            return View(monitoreo_Invest);
        }

        // GET: Monitoreo_Invest/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Monitoreo_Invest/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "index,N_,Tema_institución_Investigación_,Responsable,Fecha_inicio,Fecha_avance,Fecha_Termino,Comentario,Acción,Seguimiento,id")] Monitoreo_Invest monitoreo_Invest)
        {
            if (ModelState.IsValid)
            {
                db.Monitoreo_Invest.Add(monitoreo_Invest);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(monitoreo_Invest);
        }

        // GET: Monitoreo_Invest/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Monitoreo_Invest monitoreo_Invest = db.Monitoreo_Invest.Find(id);
            if (monitoreo_Invest == null)
            {
                return HttpNotFound();
            }
            return View(monitoreo_Invest);
        }

        // POST: Monitoreo_Invest/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "index,N_,Tema_institución_Investigación_,Responsable,Fecha_inicio,Fecha_avance,Fecha_Termino,Comentario,Acción,Seguimiento,id")] Monitoreo_Invest monitoreo_Invest)
        {
            if (ModelState.IsValid)
            {
                db.Entry(monitoreo_Invest).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(monitoreo_Invest);
        }

        // GET: Monitoreo_Invest/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Monitoreo_Invest monitoreo_Invest = db.Monitoreo_Invest.Find(id);
            if (monitoreo_Invest == null)
            {
                return HttpNotFound();
            }
            return View(monitoreo_Invest);
        }

        // POST: Monitoreo_Invest/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Monitoreo_Invest monitoreo_Invest = db.Monitoreo_Invest.Find(id);
            db.Monitoreo_Invest.Remove(monitoreo_Invest);
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
