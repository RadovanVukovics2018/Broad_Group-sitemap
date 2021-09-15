using BroadGroup_sitemap.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BroadGroup_sitemap.Models
{
    public class CheckSitemap : ICheckSitemap
    {
        public string Check()
        {
            return "Proba metode";
        }
    }
}