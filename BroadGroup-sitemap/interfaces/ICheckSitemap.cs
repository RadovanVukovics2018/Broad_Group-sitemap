using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BroadGroup_sitemap.interfaces
{
    public interface ICheckSitemap
    {
        string ReadXml();
        string DeleteXmlNode();

    }
}
