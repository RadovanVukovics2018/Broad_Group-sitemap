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

        public HomeController(IManageSitemap manageSitemap)
        {
            _manageSitemap = manageSitemap;
        }

        
        public ActionResult Index()
        {
            XmlDocument data = _manageSitemap.ReadXml();
                                  
            List<string> links = new List<string>();

            foreach(XmlNode node in data.DocumentElement.ChildNodes)
            {
                links.Add(node.ChildNodes[0].InnerText);
            }

            //ViewBag.Data = data;
            ViewBag.XmlLinks = links;

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