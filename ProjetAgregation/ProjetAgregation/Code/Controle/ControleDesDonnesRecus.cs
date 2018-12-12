using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetAgregation.Code;
using ProjetAgregation.Fenetres;

namespace ProjetAgregation.Code.Controle
{
    public class ControleDesDonnesRecus
    {
        //on recoit les parseurs
        CryptoMonnaie cryptomonnaieDAO = new CryptoMonnaie();
        ParseurNews nouvelleDAO = new ParseurNews();
        ParseurPokemon pokemonDAO = new ParseurPokemon();
        ParseurMeteo MeteoDAO = new ParseurMeteo();

        //section reserver a parsing et a l'ajout des donnes dasn les fenetres

        public void MontrerMonnaie(Monaie Monaie)
        {
            List<CryptoMonnaie> listeMonnaies = ParseurCryptoMonnaie.listerMonnaies();
            CryptoMonnaie monnaie1 = listeMonnaies[1];
            Monaie.monnaieSuivie.Text = monnaie1.nom;
            Monaie.monnaieInfo.Text = "Symbole : " + monnaie1.symbole + "  // Algorithme : " + monnaie1.algorithme;
            Monaie.monnaieNombre.Text = "Nombre existant : " + monnaie1.nombre;
            Console.WriteLine("Monaie ajouter dans les TextBox");
        }

        public void MontrerNouvelles(News News)
        {
            string rssReddit = "https://www.reddit.com/.rss";
            List<Nouvelle> listeNouvelles = nouvelleDAO.listerNouvelles(rssReddit);

            // il faut partir au 7em element car les 6 premier ne sont pas des nouvelles
            Nouvelle new1 = listeNouvelles[7];
            News.nouvelle1.Text = new1.name;

            Nouvelle new2 = listeNouvelles[8];
            News.nouvelle2.Text = new2.name;

            Nouvelle new3 = listeNouvelles[9];
            News.nouvelle3.Text = new3.name;

            Nouvelle new4 = listeNouvelles[10];
            News.nouvelle4.Text = new4.name;

            Nouvelle new5 = listeNouvelles[11];
            News.nouvelle5.Text = new5.name;

            Nouvelle new6 = listeNouvelles[12];
            News.nouvelle6.Text = new6.name;

            Nouvelle new7 = listeNouvelles[13];
            News.nouvelle7.Text = new7.name;

            Nouvelle new8 = listeNouvelles[14];
            News.nouvelle8.Text = new8.name;

            Nouvelle new9 = listeNouvelles[15];
            News.nouvelle9.Text = new9.name;

            Nouvelle new10 = listeNouvelles[16];
            News.nouvelle10.Text = new10.name;

            Console.WriteLine("Nouvelles ajouter dans les TextBox");
        }

        public void MontrerPokemon(Pokedex Pokedex)
        {
            List<Pokemon> listePokemon = pokemonDAO.listerPokemon();

            Pokemon poke1 = listePokemon[0];
            Pokedex.pokemonTrouver1.Text = poke1.nom;

            Pokemon poke2 = listePokemon[1];
            Pokedex.pokemonTrouver2.Text = poke2.nom;

            Pokemon poke3 = listePokemon[2];
            Pokedex.pokemonTrouver3.Text = poke3.nom;

            Pokemon poke4 = listePokemon[3];
            Pokedex.pokemonTrouver4.Text = poke4.nom;

            Console.WriteLine("Pokemons ajouter dans les TextBox");
        }

        public void MontrerMeteo(Graph Graph)
        {
            string meteoMediaMatane = "http://rss.meteomedia.com/weather/caqc0342";
            List<Meteo> listeMeteo = MeteoDAO.listerMeteo(meteoMediaMatane);

            Meteo meteo1 = listeMeteo[0];
            Graph.donnee.Text = meteo1.description;
            Console.WriteLine("Meteo ajouter dans les TextBox");
        }




        //versions des donnes reserver a l'aceuil

        //commende pour aficher les nouvelles
        public void MontrerNouvellesAcueil(Acueil Acueil)
        {
            string rssReddit = "https://www.reddit.com/.rss";
            List<Nouvelle> listeNouvelles = nouvelleDAO.listerNouvelles(rssReddit);

            // il faut partir au 7em element car les 6 premier ne sont pas des nouvelles
            Nouvelle new1 = listeNouvelles[7];
            Acueil.news.Text = Acueil.news.Text + new1.name;
            Console.WriteLine("Nouvelle ajouter dans la TextBox");
        }

        public void MontrerMeteoAcueil(Acueil Acueil)
        {
            string meteoMediaMatane = "http://rss.meteomedia.com/weather/caqc0342";
            List<Meteo> listeMeteo = MeteoDAO.listerMeteo(meteoMediaMatane);

            Meteo meteo1 = listeMeteo[0];
            Acueil.temp.Text = Acueil.temp.Text + meteo1.description;
            Console.WriteLine("Meteo ajouter dans la TextBox");
        }


        public void MontrerPokemonAcueil(Acueil Acueil)
        {
            List<Pokemon> listePokemon = pokemonDAO.listerPokemon();

            Pokemon poke1 = listePokemon[0];
            Acueil.pokemon.Text = Acueil.pokemon.Text + poke1.nom;
            Console.WriteLine("Pokemon ajouter dans la TextBox");
        }

        public void MontrerMonnaieAcueil(Acueil Acueil)
        {
            List<CryptoMonnaie> listeMonnaies = ParseurCryptoMonnaie.listerMonnaies();
            CryptoMonnaie monnaie1 = listeMonnaies[1];
            Acueil.monaie.Text = Acueil.monaie.Text + monnaie1.nom;
            Console.WriteLine("Monaie ajouter dans la TextBox");
        }


    }
}
