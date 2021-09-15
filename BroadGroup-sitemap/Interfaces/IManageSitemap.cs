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
        XmlDocument ReadXml();
        string DeleteXmlNode();

        bool UrlIsValid(string url);

    }
}
