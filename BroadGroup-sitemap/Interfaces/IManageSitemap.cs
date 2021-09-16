using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BroadGroup_sitemap.Interfaces
{
    public interface IManageSitemap
    {
        List<string> ReadLinksXml();
        List<string> DeleteNotWorkingLinks(List<string> all_links, List<string> bad_links);

        bool UrlIsValid(string url);

        List<string> CheckLinks(List<string> links);

        

    }
}
