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
    public class ShopifyOriginalsController : Controller
    {
        private listaProductosEntities db = new listaProductosEntities();

        // GET: ShopifyOriginals
        public ActionResult Index()
        {
            return View(db.ShopifyOriginals.ToList());
        }

        // GET: ShopifyOriginals/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ShopifyOriginal shopifyOriginal = db.ShopifyOriginals.Find(id);
            if (shopifyOriginal == null)
            {
                return HttpNotFound();
            }
            return View(shopifyOriginal);
        }

        // GET: ShopifyOriginals/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ShopifyOriginals/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "index,Handle,Title,Body__HTML_,Vendor,Type,Tags,Published,Option1_Name,Option1_Value,Option2_Name,Option2_Value,Option3_Name,Option3_Value,Variant_SKU,Variant_Grams,Variant_Inventory_Tracker,Variant_Inventory_Qty,Variant_Inventory_Policy,Variant_Fulfillment_Service,Variant_Price,Variant_Compare_At_Price,Variant_Requires_Shipping,Variant_Taxable,Variant_Barcode,Image_Src,Image_Position,Image_Alt_Text,Gift_Card,SEO_Title,SEO_Description,Google_Shopping___Google_Product_Category,Google_Shopping___Gender,Google_Shopping___Age_Group,Google_Shopping___MPN,Google_Shopping___AdWords_Grouping,Google_Shopping___AdWords_Labels,Google_Shopping___Condition,Google_Shopping___Custom_Product,Google_Shopping___Custom_Label_0,Google_Shopping___Custom_Label_1,Google_Shopping___Custom_Label_2,Google_Shopping___Custom_Label_3,Google_Shopping___Custom_Label_4,Variant_Image,Variant_Weight_Unit,Variant_Tax_Code,Cost_per_item,Status,id")] ShopifyOriginal shopifyOriginal)
        {
            if (ModelState.IsValid)
            {
                db.ShopifyOriginals.Add(shopifyOriginal);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(shopifyOriginal);
        }

        // GET: ShopifyOriginals/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ShopifyOriginal shopifyOriginal = db.ShopifyOriginals.Find(id);
            if (shopifyOriginal == null)
            {
                return HttpNotFound();
            }
            return View(shopifyOriginal);
        }

        // POST: ShopifyOriginals/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "index,Handle,Title,Body__HTML_,Vendor,Type,Tags,Published,Option1_Name,Option1_Value,Option2_Name,Option2_Value,Option3_Name,Option3_Value,Variant_SKU,Variant_Grams,Variant_Inventory_Tracker,Variant_Inventory_Qty,Variant_Inventory_Policy,Variant_Fulfillment_Service,Variant_Price,Variant_Compare_At_Price,Variant_Requires_Shipping,Variant_Taxable,Variant_Barcode,Image_Src,Image_Position,Image_Alt_Text,Gift_Card,SEO_Title,SEO_Description,Google_Shopping___Google_Product_Category,Google_Shopping___Gender,Google_Shopping___Age_Group,Google_Shopping___MPN,Google_Shopping___AdWords_Grouping,Google_Shopping___AdWords_Labels,Google_Shopping___Condition,Google_Shopping___Custom_Product,Google_Shopping___Custom_Label_0,Google_Shopping___Custom_Label_1,Google_Shopping___Custom_Label_2,Google_Shopping___Custom_Label_3,Google_Shopping___Custom_Label_4,Variant_Image,Variant_Weight_Unit,Variant_Tax_Code,Cost_per_item,Status,id")] ShopifyOriginal shopifyOriginal)
        {
            if (ModelState.IsValid)
            {
                db.Entry(shopifyOriginal).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(shopifyOriginal);
        }

        // GET: ShopifyOriginals/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ShopifyOriginal shopifyOriginal = db.ShopifyOriginals.Find(id);
            if (shopifyOriginal == null)
            {
                return HttpNotFound();
            }
            return View(shopifyOriginal);
        }

        // POST: ShopifyOriginals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ShopifyOriginal shopifyOriginal = db.ShopifyOriginals.Find(id);
            db.ShopifyOriginals.Remove(shopifyOriginal);
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
