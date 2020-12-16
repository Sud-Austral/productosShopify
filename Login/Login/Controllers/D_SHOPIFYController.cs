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
    public class D_SHOPIFYController : Controller
    {
        private listaProductosOriginal db = new listaProductosOriginal();

        // GET: D_SHOPIFY
        public ActionResult Index()
        {
            var d_SHOPIFY = db.D_SHOPIFY.Include(d => d.D_PRODUCTO);
            return View(d_SHOPIFY.ToList());
        }

        // GET: D_SHOPIFY/Details/5
        public ActionResult Details(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            D_SHOPIFY d_SHOPIFY = db.D_SHOPIFY.Find(id);
            if (d_SHOPIFY == null)
            {
                return HttpNotFound();
            }
            return View(d_SHOPIFY);
        }

        // GET: D_SHOPIFY/Create
        public ActionResult Create()
        {
            ViewBag.D_PRODUCTO_id_producto = new SelectList(db.D_PRODUCTO, "id", "data");
            return View();
        }

        // POST: D_SHOPIFY/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,Handle,Title,Body_HTML,Vendor,Type,Tags,Published,Option1_Name,Option1_Value,Option2_Name,Option2_Value,Option3_Name,Option3_Value,Variant_SKU,Variant_Grams,Variant_Inventory_Tracker,Variant_Inventory_Qty,Variant_Inventory_Policy,Variant_Fulfillment_Service,Variant_Price,Variant_Compare_At_Price,Variant_Requires_Shipping,Variant_Taxable,Variant_Barcode,Image_Src,Image_Position,Image_Alt_Text,Gift_Card,SEO_Title,SEO_Description,Google_Shopping_Google_Product_Category,Google_Shopping_Gender,Google_Shopping_Age_Group,Google_Shopping_MPN,Google_Shopping_AdWords_Grouping,Google_Shopping_AdWords_Labels,Google_Shopping_Condition,Google_Shopping_Custom_Product,Google_Shopping_Custom_Label_0,Google_Shopping_Custom_Label_1,Google_Shopping_Custom_Label_2,Google_Shopping_Custom_Label_3,Google_Shopping_Custom_Label_4,Variant_Image,Variant_Weight_Unit,Variant_Tax_Code,Cost_per_item,Status,D_PRODUCTO_id_producto")] D_SHOPIFY d_SHOPIFY)
        {
            if (ModelState.IsValid)
            {
                db.D_SHOPIFY.Add(d_SHOPIFY);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.D_PRODUCTO_id_producto = new SelectList(db.D_PRODUCTO, "id", "data", d_SHOPIFY.D_PRODUCTO_id_producto);
            return View(d_SHOPIFY);
        }

        // GET: D_SHOPIFY/Edit/5
        public ActionResult Edit(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            D_SHOPIFY d_SHOPIFY = db.D_SHOPIFY.Find(id);
            if (d_SHOPIFY == null)
            {
                return HttpNotFound();
            }
            ViewBag.D_PRODUCTO_id_producto = new SelectList(db.D_PRODUCTO, "id", "data", d_SHOPIFY.D_PRODUCTO_id_producto);
            return View(d_SHOPIFY);
        }

        // POST: D_SHOPIFY/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,Handle,Title,Body_HTML,Vendor,Type,Tags,Published,Option1_Name,Option1_Value,Option2_Name,Option2_Value,Option3_Name,Option3_Value,Variant_SKU,Variant_Grams,Variant_Inventory_Tracker,Variant_Inventory_Qty,Variant_Inventory_Policy,Variant_Fulfillment_Service,Variant_Price,Variant_Compare_At_Price,Variant_Requires_Shipping,Variant_Taxable,Variant_Barcode,Image_Src,Image_Position,Image_Alt_Text,Gift_Card,SEO_Title,SEO_Description,Google_Shopping_Google_Product_Category,Google_Shopping_Gender,Google_Shopping_Age_Group,Google_Shopping_MPN,Google_Shopping_AdWords_Grouping,Google_Shopping_AdWords_Labels,Google_Shopping_Condition,Google_Shopping_Custom_Product,Google_Shopping_Custom_Label_0,Google_Shopping_Custom_Label_1,Google_Shopping_Custom_Label_2,Google_Shopping_Custom_Label_3,Google_Shopping_Custom_Label_4,Variant_Image,Variant_Weight_Unit,Variant_Tax_Code,Cost_per_item,Status,D_PRODUCTO_id_producto")] D_SHOPIFY d_SHOPIFY)
        {
            if (ModelState.IsValid)
            {
                db.Entry(d_SHOPIFY).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.D_PRODUCTO_id_producto = new SelectList(db.D_PRODUCTO, "id", "data", d_SHOPIFY.D_PRODUCTO_id_producto);
            return View(d_SHOPIFY);
        }

        // GET: D_SHOPIFY/Delete/5
        public ActionResult Delete(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            D_SHOPIFY d_SHOPIFY = db.D_SHOPIFY.Find(id);
            if (d_SHOPIFY == null)
            {
                return HttpNotFound();
            }
            return View(d_SHOPIFY);
        }

        // POST: D_SHOPIFY/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(decimal id)
        {
            D_SHOPIFY d_SHOPIFY = db.D_SHOPIFY.Find(id);
            db.D_SHOPIFY.Remove(d_SHOPIFY);
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
