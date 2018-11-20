using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Xml;
using System.Xml.Linq;

namespace ProjetAgregation.Code
{
    class ParseurNews
    {
        public List<Nouvelle> listerNouvelles(string rss)
        {
            List<Nouvelle> listeNouvelles = new List<Nouvelle>();
            Console.WriteLine("RssDAO.listerNouvelles(" + rss + ")");
            HttpWebRequest requeteNouvelles = (HttpWebRequest)WebRequest.Create(rss);
            requeteNouvelles.Method = "GET";
            requeteNouvelles.UserAgent = "Mozilla Firefox";
            WebResponse reponse = requeteNouvelles.GetResponse();
            StreamReader lecteur = new StreamReader(reponse.GetResponseStream());
            string xml = lecteur.ReadToEnd();
            XElement nouvellesXML = XElement.Parse(xml);
            foreach (XElement nouvelleXML in nouvellesXML.Elements())
            {
                XmlReader lecteurNouvelle = nouvelleXML.CreateReader();
                lecteurNouvelle.MoveToContent();
                lecteurNouvelle.ReadToDescendant("title");
                string name = lecteurNouvelle.ReadInnerXml();
                Console.WriteLine(name);

            //   lecteurNouvelle.ReadToFollowing("published");
             //   string publication = lecteurNouvelle.ReadInnerXml();
             //   Console.WriteLine(publication);

              //  lecteurNouvelle.ReadToFollowing("summary");
              //  string resume = lecteurNouvelle.ReadInnerXml();
              //  Console.WriteLine(resume);

                Nouvelle nouvelle = new Nouvelle();
                nouvelle.name = name;
               // nouvelle.publication = publication;
               // nouvelle.resume = resume;

                listeNouvelles.Add(nouvelle);
            }
            return listeNouvelles;
        }
    }
}
