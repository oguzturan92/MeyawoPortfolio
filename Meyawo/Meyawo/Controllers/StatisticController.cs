using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Meyawo.Models;

namespace Meyawo.Controllers
{
    public class StatisticController : Controller
    {
        DbMyPortfolioEntities db = new DbMyPortfolioEntities();
        public ActionResult Index()
        {
            ViewBag.categoriCount = db.TblCategory.Count();
            ViewBag.projectCount = db.TblProject.Count();
            ViewBag.messageCount = db.TblContact.Count();
            ViewBag.flutterProjectCount = db.TblProject.Where(i => i.ProjectCategory == 1).Count();
            ViewBag.isReadMessageCount = db.TblContact.Where(i => i.IsRead == false).Count();
            ViewBag.lastPorjectName = db.TblProject.OrderByDescending(i => i.ProjectID).FirstOrDefault().Title;
            ViewBag.servicesCount = db.TblService.Count();
            ViewBag.firstCategory = db.TblCategory.FirstOrDefault().CategoryName;
            ViewBag.activeTestimonial = db.TblTestimonial.Where(i => i.Status == true).FirstOrDefault().NameSurname;
            ViewBag.headerTitle = db.TblFuture.FirstOrDefault().Title;
            ViewBag.sonEklenenProjectName = db.TblProject.OrderByDescending(i => i.ProjectID).FirstOrDefault().Title;
            ViewBag.enCokKullanilanKategori = db.TblProject.GroupBy(i => i.ProjectCategory).OrderByDescending(i => i.Count()).ToList();
            return View();
        }
    }
}