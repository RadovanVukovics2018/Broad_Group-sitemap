using BroadGroup_sitemap.Clients;
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
        public List<string> CheckLinks(List<string> links)
        {
            List<string> notWorkingLinks = new List<string>();

            foreach (string link in links)
            {
                if (!UrlIsValid(link))
                {
                    notWorkingLinks.Add(link);
                }

            }

            return notWorkingLinks;
        }

        public List<string> DeleteNotWorkingLinks(List<string> all_links, List<string> bad_links)
        {
            foreach (var bad_link in bad_links)
            {
                all_links.Remove(bad_link);
            }

            return all_links;
        }

        public List<string> ReadLinksXml()
        {
            XmlDocument xdoc = new XmlDocument();//xml doc used for xml parsing
            List<string> links = new List<string>();

            xdoc.Load(
                "https://www.broad-group.com/sitemaps/sitemap_BroadGroup.xml"
                );//loading XML in xml doc



            foreach (XmlNode node in xdoc.DocumentElement.ChildNodes)
            {
                links.Add(node.ChildNodes[0].InnerText);

                //provera, obrisati ako sve radi kako treba
                //if (links.Count() > 100)
                //{
                //    break;
                //}
            }


            return links;
        }

        public bool UrlIsValid(string url)
        {
            try
            {
                //1. nacin (sporiji)

                ////Creating the HttpWebRequest
                //HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;

                //request.Method = "HEAD";
                ////Getting the Web Response.
                //HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                ////Returns TRUE if the Status code == 200
                //response.Close();
                //return (response.StatusCode == HttpStatusCode.OK);



                //2. nacin (brzi)
                using (var client = new MyClient())
                {
                    client.HeadOnly = true;

                    string s1 = client.DownloadString(url);

                }

                return true;
            }
            catch
            {
                //Any exception will returns false.
                return false;
            }
        }




    }
}