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
            var User = db1.Users.ToList();
            foreach(var item in User)
            {
                EmailFormModel model = new EmailFormModel();
                model.Email = item.Email;
                model.Username = item.UserName;
                db.EmailForm.Add(model);
                db.SaveChanges();
            }
            return View(db.EmailForm.ToList());
        }

       [HttpPost]
       public ActionResult Index(List<bool> check)
        {
            return View();
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
