using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BroadGroup_sitemap.interfaces;

namespace BroadGroup_sitemap.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICheckSitemap _checkSitemap;

        public HomeController(ICheckSitemap checkSitemap)
        {
            _checkSitemap = checkSitemap;
        }

        
        public ActionResult Index()
        {
            string proba = _checkSitemap.Check();

            //ViewBag.Proba = proba;

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}