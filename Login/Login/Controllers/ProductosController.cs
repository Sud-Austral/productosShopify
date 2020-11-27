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
    public class ProductosController : Controller
    {
        private listaProductosEntities db = new listaProductosEntities();

        // GET: Productos
        public ActionResult Index()
        {
            return View(db.Productos.ToList());
        }

        // GET: Productos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Producto producto = db.Productos.Find(id);
            if (producto == null)
            {
                return HttpNotFound();
            }
            return View(producto);
        }

        // GET: Productos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Productos/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "index,id_data,id_pais,Corr_Producto,Data,País,id_producto,Producto_asociado_,Nombre_comercial,Estado,Avance,Responsable_Desarrollo,Responsable_Información,Tecnología,Host_,Link_Odoo,Fecha_Publicación,Escala_,Periodo,Actualizaciones,Tipo_Producto,Fuentes_,Ref_principal_,Competencia_o_material_vinculado_,Vistas,Repositorio_Dropbox,Link_Logo,Observaciones,Miniatura,PORTADA_SHOPIFY,Párrafo_enganche,Variante_1,Precio_1__USD_,Variante_2,Precio_2__USD_,Variante_3,Precio_3__USD_,Variable_filtro1,Variable_filtro2,Variable_filtro3,Descripción__Indicar_qué_permite_ver_o_hacer_el_producto__2,CAR_Tipo_Prod,CAR_Var1_Disponible,CAR_Var2_Disponible,CAR_Var3_Disponible,CAR_Periodo,CAR_Proveedor,CAR_Colección,ESP_Tecnología,ESP_Incluye,ESP_Uso_Disp_,ESP_Fuentes_,ACC_Recibirás,ACC_Licencia_uso,ACC_Actualizaciones,ACC_N__usuarios,Etiquetas,id")] Producto producto)
        {
            if (ModelState.IsValid)
            {
                db.Productos.Add(producto);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(producto);
        }

        // GET: Productos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Producto producto = db.Productos.Find(id);
            if (producto == null)
            {
                return HttpNotFound();
            }
            return View(producto);
        }

        // POST: Productos/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "index,id_data,id_pais,Corr_Producto,Data,País,id_producto,Producto_asociado_,Nombre_comercial,Estado,Avance,Responsable_Desarrollo,Responsable_Información,Tecnología,Host_,Link_Odoo,Fecha_Publicación,Escala_,Periodo,Actualizaciones,Tipo_Producto,Fuentes_,Ref_principal_,Competencia_o_material_vinculado_,Vistas,Repositorio_Dropbox,Link_Logo,Observaciones,Miniatura,PORTADA_SHOPIFY,Párrafo_enganche,Variante_1,Precio_1__USD_,Variante_2,Precio_2__USD_,Variante_3,Precio_3__USD_,Variable_filtro1,Variable_filtro2,Variable_filtro3,Descripción__Indicar_qué_permite_ver_o_hacer_el_producto__2,CAR_Tipo_Prod,CAR_Var1_Disponible,CAR_Var2_Disponible,CAR_Var3_Disponible,CAR_Periodo,CAR_Proveedor,CAR_Colección,ESP_Tecnología,ESP_Incluye,ESP_Uso_Disp_,ESP_Fuentes_,ACC_Recibirás,ACC_Licencia_uso,ACC_Actualizaciones,ACC_N__usuarios,Etiquetas,id")] Producto producto)
        {
            if (ModelState.IsValid)
            {
                db.Entry(producto).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(producto);
        }

        // GET: Productos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Producto producto = db.Productos.Find(id);
            if (producto == null)
            {
                return HttpNotFound();
            }
            return View(producto);
        }

        // POST: Productos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Producto producto = db.Productos.Find(id);
            db.Productos.Remove(producto);
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
