using Meyawo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Meyawo.Controllers
{
    public class DashboardController : Controller
    {
        DbMyPortfolioEntities db = new DbMyPortfolioEntities();
        public ActionResult Index()
        {
            ViewBag.isReadMessageCount = db.TblContact.Where(i => i.IsRead == false).Count();
            ViewBag.categoriCount = db.TblCategory.Count();
            ViewBag.projectCount = db.TblProject.Count();

            return View();
        }
    }
}