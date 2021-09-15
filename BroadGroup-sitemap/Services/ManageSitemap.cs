using BroadGroup_sitemap.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Xml;

namespace BroadGroup_sitemap.Models
{
    public class ManageSitemap : IManageSitemap
    {        
        public string DeleteXmlNode()
        {
            throw new NotImplementedException();
        }

        public XmlDocument ReadXml()
        {
            XmlDocument xdoc = new XmlDocument();//xml doc used for xml parsing

            xdoc.Load(
                "https://www.broad-group.com/sitemaps/sitemap_BroadGroup.xml"
                );//loading XML in xml doc

            return xdoc;
        }

        public bool UrlIsValid(string url)
        {
            try
            {
                //Creating the HttpWebRequest
                HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
                
                request.Method = "GET";
                //Getting the Web Response.
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                //Returns TRUE if the Status code == 200
                response.Close();
                return (response.StatusCode == HttpStatusCode.OK);
            }
            catch
            {
                //Any exception will returns false.
                return false;
            }
        }

        
    }
}