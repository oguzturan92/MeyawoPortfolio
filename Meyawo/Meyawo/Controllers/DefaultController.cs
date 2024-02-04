using Meyawo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Meyawo.Controllers
{
    public class DefaultController : Controller
    {
        DbMyPortfolioEntities db = new DbMyPortfolioEntities();
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult HeadPartial()
        {
            return PartialView();
        }

        public PartialViewResult NavbarPartial()
        {
            return PartialView();
        }

        public PartialViewResult FeaturePartial()
        {
            var values = db.TblFuture.ToList();
            return PartialView(values);
        }

        public PartialViewResult AboutPartial()
        {
            var values = db.TblAbout.ToList();
            return PartialView(values);
        }

        public PartialViewResult ServicePartial()
        {
            var values = db.TblService.ToList();
            return PartialView(values);
        }

        public PartialViewResult ProjectPartial()
        {
            var values = db.TblProject.ToList();
            return PartialView(values);
        }

        public PartialViewResult TestimonialPartial()
        {
            var values = db.TblTestimonial.ToList();
            return PartialView(values);
        }

        public PartialViewResult ContactPartial()
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult ContactCreate(string nameSurname, string email, string msg)
        {
            var message = new TblContact()
            {
                NameSurname = nameSurname,
                Email = email,
                Message = msg,
                SendDate = DateTime.Now,
                IsRead = false
            };
            db.TblContact.Add(message);
            db.SaveChanges();
            return RedirectToAction("Index", "Default");
        }

        public PartialViewResult SocialMediaPartial()
        {
            var values = db.TblSocialMedia.ToList();
            return PartialView(values);
        }

    }
}