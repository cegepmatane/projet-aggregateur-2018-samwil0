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
    class ParseurMeteo
    {
        public List<Meteo> listerMeteo(string rss)
        {
            List<Meteo> listeMeteo = new List<Meteo>();
            HttpWebRequest requeteMeteo = (HttpWebRequest)WebRequest.Create(rss);
            requeteMeteo.Method = "GET";
            requeteMeteo.UserAgent = "Mozilla Firefox";
            WebResponse reponse = requeteMeteo.GetResponse();
            StreamReader lecteur = new StreamReader(reponse.GetResponseStream());
            string xml = lecteur.ReadToEnd();
            XElement MeteoXML = XElement.Parse(xml);
            foreach (XElement nouvelleXML in MeteoXML.Elements())
            {
                XmlReader lecteurMeteo = MeteoXML.CreateReader();
                lecteurMeteo.MoveToContent();
                // lecteurMeteo.ReadToDescendant("title");
                // string title = lecteurMeteo.ReadInnerXml();

                // lecteurMeteo.ReadToFollowing("description");
                //string description = lecteurMeteo.ReadInnerXml();

                lecteurMeteo.ReadToDescendant("item");
                string item = lecteurMeteo.ReadInnerXml();
                 lecteurMeteo.ReadToFollowing("description");
                string description = lecteurMeteo.ReadInnerXml();

                Meteo meteo = new Meteo();
                //meteo.title = title;
                meteo.item = item;
                meteo.description = description;
                

                listeMeteo.Add(meteo);
            }
            return listeMeteo;
        }
    }
}
