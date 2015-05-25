using GlossaryManagementSystem.Context;
using GlossaryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace GlossaryManagementSystem.Controllers
{
    public class ProductController : Controller
    {
        private ProductContext productContext = new ProductContext();
        // GET: Product
        public ActionResult Index()
        {
            return View(productContext.Products.ToList());
        }

        // GET: Product/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            Product product = productContext.Products.Find(id);
            if (product == null) return HttpNotFound();
            else return View(product);
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        public ActionResult Create(Product product)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    productContext.Products.Add(product);
                    productContext.SaveChanges();
                    return RedirectToAction("Index");
                }
                else return View(product);
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            Product product = productContext.Products.Find(id);
            if (product == null) return HttpNotFound();

            return View(product);
        }

        // POST: Product/Edit/5
        [HttpPost]
        public ActionResult Edit(Product product)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    productContext.Entry(product).State = System.Data.Entity.EntityState.Modified;
                    productContext.SaveChanges();

                    return RedirectToAction("Index");
                }
                else return View(product);
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            Product product = productContext.Products.Find(id);
            if (product == null) return HttpNotFound();

            return View(product);
          
        }

        // POST: Product/Delete/5
        [HttpPost]
        public ActionResult Delete(int? id)
        {
            try
            {
                Product product = new Product();
                if (ModelState.IsValid)
                {
                    product= productContext.Products.Find(id);
                    productContext.Products.Remove(product);
                    productContext.SaveChanges();
                    return RedirectToAction("Index");
                }
                else return View(product);
            }
            catch
            {
                return View();
            }
        }
    }
}
