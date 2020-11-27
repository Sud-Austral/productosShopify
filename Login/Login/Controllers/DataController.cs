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
    public class DataController : Controller
    {
        private listaProductosEntities db = new listaProductosEntities();

        // GET: Data
        public ActionResult Index()
        {
            return View(db.Datas.ToList());
        }

        // GET: Data/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Data data = db.Datas.Find(id);
            if (data == null)
            {
                return HttpNotFound();
            }
            return View(data);
        }

        // GET: Data/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Data/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "index,Unnamed__0,Data1,id_data,Estado,Desarrollo,Investigación,Breve_Descripción,Slogan___Cita,Vistas,Repositorio_Dropbox,Link_Logo,id")] Data data)
        {
            if (ModelState.IsValid)
            {
                db.Datas.Add(data);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(data);
        }

        // GET: Data/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Data data = db.Datas.Find(id);
            if (data == null)
            {
                return HttpNotFound();
            }
            return View(data);
        }

        // POST: Data/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "index,Unnamed__0,Data1,id_data,Estado,Desarrollo,Investigación,Breve_Descripción,Slogan___Cita,Vistas,Repositorio_Dropbox,Link_Logo,id")] Data data)
        {
            if (ModelState.IsValid)
            {
                db.Entry(data).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(data);
        }

        // GET: Data/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Data data = db.Datas.Find(id);
            if (data == null)
            {
                return HttpNotFound();
            }
            return View(data);
        }

        // POST: Data/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Data data = db.Datas.Find(id);
            db.Datas.Remove(data);
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
