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
    class NouvellesDAO
    {
        string rssReddit = "https://www.reddit.com/.rss";
        public List<Nouvelle> listerNouvelles()
        {
            List<Nouvelle> listeNouvelles = new List<Nouvelle>();
            HttpWebRequest requeteNouvelles = (HttpWebRequest)WebRequest.Create(rssReddit);
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

                lecteurNouvelle.ReadToFollowing("img");
                string img = lecteurNouvelle.ReadInnerXml();

                Nouvelle nouvelle = new Nouvelle();
                nouvelle.name = name;
                nouvelle.img = img;

                listeNouvelles.Add(nouvelle);
            }
            return listeNouvelles;
        }
    }
}
