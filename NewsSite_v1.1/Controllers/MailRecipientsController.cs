using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NewsSite_v1._1.Models;
using System.Threading.Tasks;

namespace NewsSite_v1._1.Controllers
{
    public class MailRecipientsController : Controller
    {
        private ApplicationDbContext1 db = new ApplicationDbContext1();

        // GET: MailRecipients
        [Authorize]
        public async Task<ActionResult> Index()
        {
            var model = new MailRecipientsViewModel();

            var recipients = await db.MailRecipients.ToListAsync();
            foreach(var item in recipients)
            {
                var newRecipient = new SelectRecipientEditorViewModel()
                {
                    MailRecipientId = item.MailRecipientId,
                    Email = item.Email,
                    LastMailedDate = item.getLastEmailDate().HasValue ? item.getLastEmailDate().Value.ToShortDateString():"",
                    Selected = true
                };
                model.MailRecipients.Add(newRecipient);
            }
            return View(model);
        }

        [HttpPost]
        [Authorize]
        public ActionResult SendMail(MailRecipientsViewModel recipients)
        {
            System.Threading.Thread.Sleep(2000);
            return RedirectToAction("Index");
        }

        // GET: MailRecipients/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MailRecipient mailRecipient = db.MailRecipients.Find(id);
            if (mailRecipient == null)
            {
                return HttpNotFound();
            }
            return View(mailRecipient);
        }

        // GET: MailRecipients/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MailRecipients/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Email")] MailRecipient mailRecipient)
        {
            if (ModelState.IsValid)
            {
                db.MailRecipients.Add(mailRecipient);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(mailRecipient);
        }

        // GET: MailRecipients/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MailRecipient mailRecipient = db.MailRecipients.Find(id);
            if (mailRecipient == null)
            {
                return HttpNotFound();
            }
            return View(mailRecipient);
        }

        // POST: MailRecipients/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MailRecipientId,Email")] MailRecipient mailRecipient)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mailRecipient).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mailRecipient);
        }

        // GET: MailRecipients/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MailRecipient mailRecipient = db.MailRecipients.Find(id);
            if (mailRecipient == null)
            {
                return HttpNotFound();
            }
            return View(mailRecipient);
        }

        // POST: MailRecipients/Delete/5
        [HttpPost, ActionName("Delete")]
        [Authorize]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MailRecipient mailRecipient = db.MailRecipients.Find(id);
            db.MailRecipients.Remove(mailRecipient);
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
