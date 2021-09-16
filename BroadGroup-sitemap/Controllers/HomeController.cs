using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml;
using BroadGroup_sitemap.Interfaces;

namespace BroadGroup_sitemap.Controllers
{
    public class HomeController : Controller
    {
        private readonly IManageSitemap _manageSitemap;


        private static List<string> links = new List<string>();
        private static List<string> notWorkingLinks = new List<string>();

        public HomeController(IManageSitemap manageSitemap)
        {
            _manageSitemap = manageSitemap;
        }



        public ActionResult Index()
        {

            links = _manageSitemap.ReadLinksXml();


            ViewBag.XmlLinks = links;
            ViewBag.XmlLinksNotWorking = notWorkingLinks;

            return View();
        }

        public ActionResult CheckLinks()
        {

            notWorkingLinks = _manageSitemap.CheckLinks(links);

            ViewBag.XmlLinks = links;
            ViewBag.XmlLinksNotWorking = notWorkingLinks;

            return View("Index");

        }

        public ActionResult Delete()
        {
            links = _manageSitemap.DeleteNotWorkingLinks(links, notWorkingLinks);

            notWorkingLinks = new List<string>();

            ViewBag.XmlLinks = links;
            ViewBag.XmlLinksNotWorking = notWorkingLinks;

            return View("Index");
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