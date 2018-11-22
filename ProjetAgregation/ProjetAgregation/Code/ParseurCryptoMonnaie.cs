using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Web.Script.Serialization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using ProjetAgregation.Code;
using System.Web.UI;

namespace ProjetAgregation.Code
{
    class ParseurCryptoMonnaie
    {
        static public List<CryptoMonnaie> listerMonnaies()
        {
            string url = "https://www.cryptocompare.com/api/data/coinlist/";
            HttpWebRequest requeteListeMonnaies = (HttpWebRequest)WebRequest.Create(url);
            WebResponse reponse = requeteListeMonnaies.GetResponse();
            StreamReader lecteurListeMonnaies = new StreamReader(reponse.GetResponseStream());
            string json = lecteurListeMonnaies.ReadToEnd();

            JavaScriptSerializer parseur = new JavaScriptSerializer();
            dynamic objet = parseur.Deserialize<dynamic>(json);
            var lesMonnaies = objet["Data"];

            List<CryptoMonnaie> listeCryptomonnaie = new List<CryptoMonnaie>();
            foreach (dynamic itemMonnaie in lesMonnaies)
            {
                var monnaie = itemMonnaie.Value;
                var symbole = monnaie["Symbol"];
                var nom = monnaie["CoinName"];
                var algorithme = monnaie["Algorithm"];
                var nombre = monnaie["TotalCoinSupply"];

                CryptoMonnaie cryptomonnaie = new CryptoMonnaie();
                cryptomonnaie.symbole = symbole;
                cryptomonnaie.nom = nom;
                cryptomonnaie.algorithme = algorithme;
                cryptomonnaie.nombre = nombre;
                listeCryptomonnaie.Add(cryptomonnaie);
            }
            return listeCryptomonnaie;
        }

    }
}
