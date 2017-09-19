using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NewsSite_v1._1.Models;

namespace NewsSite_v1._1.Controllers
{
    public class EmailFormModelsController : Controller
    {
        private NewsModel db = new NewsModel();
        private ApplicationDbContext db1 = new ApplicationDbContext();

        // GET: EmailFormModels
        public ActionResult Index()
        {
            return View(db1.Users.ToList());
        }

       [HttpPost]
       public ActionResult Index(EmailFormModel model)
        {

            return View(model);
        }

        // GET: EmailFormModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmailFormModel emailFormModel = db.EmailForm.Find(id);
            if (emailFormModel == null)
            {
                return HttpNotFound();
            }
            return View(emailFormModel);
        }

        // POST: EmailFormModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Message")] EmailFormModel emailFormModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(emailFormModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(emailFormModel);
        }

        // GET: EmailFormModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmailFormModel emailFormModel = db.EmailForm.Find(id);
            if (emailFormModel == null)
            {
                return HttpNotFound();
            }
            return View(emailFormModel);
        }

        // POST: EmailFormModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EmailFormModel emailFormModel = db.EmailForm.Find(id);
            db.EmailForm.Remove(emailFormModel);
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
