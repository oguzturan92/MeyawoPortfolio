using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Meyawo.Models;

namespace Meyawo.Controllers
{
    public class ContactController : Controller
    {
        DbMyPortfolioEntities db = new DbMyPortfolioEntities();
        public ActionResult Index()
        {
            var values = db.TblContact.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult DetailMessage(int id)
        {
            var message = db.TblContact.Find(id);
            message.IsRead = true;
            db.SaveChanges();
            return View(message);
        }

        public ActionResult DeleteMessage(int id)
        {
            var message = db.TblContact.Find(id);
            db.TblContact.Remove(message);
            db.SaveChanges();
            return RedirectToAction("Index","Contact");
        }

    }
}