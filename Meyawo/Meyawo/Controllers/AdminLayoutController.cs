using Meyawo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Meyawo.Controllers
{
    public class AdminLayoutController : Controller
    {
        DbMyPortfolioEntities db = new DbMyPortfolioEntities();
        public ActionResult _Layout()
        {
            ViewBag.v = "Merhaba";
            return View();
        }

        public PartialViewResult _HeaderPartial()
        {
            return PartialView();
        }

        public PartialViewResult _SidebarPartial()
        {
            ViewBag.v = "Merhaba";
            return PartialView();
        }

        public PartialViewResult _ScriptPartial()
        {
            return PartialView();
        }
    }
}