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
    public class D_PRODUCTOController : Controller
    {
        private listaProductosOriginal db = new listaProductosOriginal();

        // GET: D_PRODUCTO
        public ActionResult Index()
        {
            var d_PRODUCTO = db.D_PRODUCTO.Include(d => d.D_PRIORIZACION);
            return View(d_PRODUCTO.ToList());
        }

        // GET: D_PRODUCTO/Details/5
        public ActionResult Details(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            D_PRODUCTO d_PRODUCTO = db.D_PRODUCTO.Find(id);
            if (d_PRODUCTO == null)
            {
                return HttpNotFound();
            }
            return View(d_PRODUCTO);
        }

        // GET: D_PRODUCTO/Create
        public ActionResult Create()
        {
            ViewBag.D_PRIORIZACION_id_priorizacion = new SelectList(db.D_PRIORIZACION, "id", "producto_previo");
            return View();
        }

        // POST: D_PRODUCTO/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,corr_Producto,data,pais,id_producto,producto_asociado,nombre_comercial,estado,avance,responsable_desarrollo,responsable_informacion,tecnologia,host,link_odoo,fecha_publicación,escala,periodo,actualizaciones,tipo_producto,fuentes,ref_principal,competencia,vista,repositorio_dropbox,logo,observaciones,miniatura,portada_shopify,parrafo_enganche,variante_1,precio1_usd,variante_2,precio2_usd,variante_3,precio3_usd,variable_filtro1,variable_filtro2,variable_filtro3,descripcion,CAR_tipo_prod,CAR_var1_disponible,CAR_var2_disponible,CAR_var3_disponible,CAR_periodo,CAR_proveedor,CAR_colección,ESP_tecnología,ESP_incluye,ESP_uso_disp,ESP_fuentes_,ACC_recibirás,ACC_licencia_uso,ACC_actualizaciones,ACC_numero_usuarios,etiquetas,D_PRIORIZACION_id_priorizacion")] D_PRODUCTO d_PRODUCTO)
        {
            if (ModelState.IsValid)
            {
                db.D_PRODUCTO.Add(d_PRODUCTO);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.D_PRIORIZACION_id_priorizacion = new SelectList(db.D_PRIORIZACION, "id", "producto_previo", d_PRODUCTO.D_PRIORIZACION_id_priorizacion);
            return View(d_PRODUCTO);
        }

        // GET: D_PRODUCTO/Edit/5
        public ActionResult Edit(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            D_PRODUCTO d_PRODUCTO = db.D_PRODUCTO.Find(id);
            if (d_PRODUCTO == null)
            {
                return HttpNotFound();
            }
            ViewBag.D_PRIORIZACION_id_priorizacion = new SelectList(db.D_PRIORIZACION, "id", "producto_previo", d_PRODUCTO.D_PRIORIZACION_id_priorizacion);
            return View(d_PRODUCTO);
        }

        // POST: D_PRODUCTO/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,corr_Producto,data,pais,id_producto,producto_asociado,nombre_comercial,estado,avance,responsable_desarrollo,responsable_informacion,tecnologia,host,link_odoo,fecha_publicación,escala,periodo,actualizaciones,tipo_producto,fuentes,ref_principal,competencia,vista,repositorio_dropbox,logo,observaciones,miniatura,portada_shopify,parrafo_enganche,variante_1,precio1_usd,variante_2,precio2_usd,variante_3,precio3_usd,variable_filtro1,variable_filtro2,variable_filtro3,descripcion,CAR_tipo_prod,CAR_var1_disponible,CAR_var2_disponible,CAR_var3_disponible,CAR_periodo,CAR_proveedor,CAR_colección,ESP_tecnología,ESP_incluye,ESP_uso_disp,ESP_fuentes_,ACC_recibirás,ACC_licencia_uso,ACC_actualizaciones,ACC_numero_usuarios,etiquetas,D_PRIORIZACION_id_priorizacion")] D_PRODUCTO d_PRODUCTO)
        {
            if (ModelState.IsValid)
            {
                db.Entry(d_PRODUCTO).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.D_PRIORIZACION_id_priorizacion = new SelectList(db.D_PRIORIZACION, "id", "producto_previo", d_PRODUCTO.D_PRIORIZACION_id_priorizacion);
            return View(d_PRODUCTO);
        }

        // GET: D_PRODUCTO/Delete/5
        public ActionResult Delete(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            D_PRODUCTO d_PRODUCTO = db.D_PRODUCTO.Find(id);
            if (d_PRODUCTO == null)
            {
                return HttpNotFound();
            }
            return View(d_PRODUCTO);
        }

        // POST: D_PRODUCTO/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(decimal id)
        {
            D_PRODUCTO d_PRODUCTO = db.D_PRODUCTO.Find(id);
            db.D_PRODUCTO.Remove(d_PRODUCTO);
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
