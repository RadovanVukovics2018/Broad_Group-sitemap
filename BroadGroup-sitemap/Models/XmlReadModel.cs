using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BroadGroup_sitemap.interfaces;

namespace BroadGroup_sitemap.Models
{
    public class XmlReadModel
    {
        private readonly ICheckSitemap _checkSitemap;

        public XmlReadModel(ICheckSitemap checkSitemap)
        {
            _checkSitemap = checkSitemap;
        }

        public string XmlReadAll()
        {
            string message = _checkSitemap.Check();

            return message;
        }
    }
}