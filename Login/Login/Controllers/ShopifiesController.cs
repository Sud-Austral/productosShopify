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
    public class ShopifiesController : Controller
    {
        private listaProductosEntities db = new listaProductosEntities();

        // GET: Shopifies
        public ActionResult Index()
        {
            return View(db.Shopifies.ToList());
        }

        // GET: Shopifies/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Shopify shopify = db.Shopifies.Find(id);
            if (shopify == null)
            {
                return HttpNotFound();
            }
            return View(shopify);
        }

        // GET: Shopifies/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Shopifies/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "index,id_data,Corr_Producto,Data,id_producto,Producto_asociado_,Nombre_comercial,Variante,Corr_variante,id_prod_var,Estado,Avance,Responsable_Desarrollo,Responsable_Información,PORTADA_SHOPIFY,Párrafo_enganche,Variante_1,Precio_1,Variante_2,Precio_2,Variante_3,Precio_3,Variable_filtro1,Variable_filtro2,Variable_filtro3,Descripción__Indicar_qué_permite_ver_o_hacer_el_producto__,CAR_Tipo_Prod,CAR_Var1_Disponible,CAR_Periodo,CAR_Proveedor,CAR_Colección,ESP_Tecnología,Host_,Link_Odoo,Fecha_Publicación,País,Escala_,ESP_Periodo,ESP_Incluye,ESP_Uso_Disp_,ESP_Fuentes_,ACC_Recibirás,ACC_Licencia_uso,ACC_Actualizaciones,ACC_N__usuarios,Etiquetas,Vistas,Repositorio_Dropbox,Link_Logo,Observaciones,Miniatura,id")] Shopify shopify)
        {
            if (ModelState.IsValid)
            {
                db.Shopifies.Add(shopify);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(shopify);
        }

        // GET: Shopifies/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Shopify shopify = db.Shopifies.Find(id);
            if (shopify == null)
            {
                return HttpNotFound();
            }
            return View(shopify);
        }

        // POST: Shopifies/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "index,id_data,Corr_Producto,Data,id_producto,Producto_asociado_,Nombre_comercial,Variante,Corr_variante,id_prod_var,Estado,Avance,Responsable_Desarrollo,Responsable_Información,PORTADA_SHOPIFY,Párrafo_enganche,Variante_1,Precio_1,Variante_2,Precio_2,Variante_3,Precio_3,Variable_filtro1,Variable_filtro2,Variable_filtro3,Descripción__Indicar_qué_permite_ver_o_hacer_el_producto__,CAR_Tipo_Prod,CAR_Var1_Disponible,CAR_Periodo,CAR_Proveedor,CAR_Colección,ESP_Tecnología,Host_,Link_Odoo,Fecha_Publicación,País,Escala_,ESP_Periodo,ESP_Incluye,ESP_Uso_Disp_,ESP_Fuentes_,ACC_Recibirás,ACC_Licencia_uso,ACC_Actualizaciones,ACC_N__usuarios,Etiquetas,Vistas,Repositorio_Dropbox,Link_Logo,Observaciones,Miniatura,id")] Shopify shopify)
        {
            if (ModelState.IsValid)
            {
                db.Entry(shopify).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(shopify);
        }

        // GET: Shopifies/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Shopify shopify = db.Shopifies.Find(id);
            if (shopify == null)
            {
                return HttpNotFound();
            }
            return View(shopify);
        }

        // POST: Shopifies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Shopify shopify = db.Shopifies.Find(id);
            db.Shopifies.Remove(shopify);
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
