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
        NouvellesDAO nouvelleDAO = new NouvellesDAO();
        PokemonDAO pokemonDAO = new PokemonDAO();
        MeteoDAO MeteoDAO = new MeteoDAO();

        public void activerVueAccueil(Acueil vue)
        {
            //meteo
            List<Meteo> listeMeteo = MeteoDAO.listerMeteoAccueil();
            vue.montrerMeteo(listeMeteo);

            //crypto
            List<CryptoMonnaie> listeMonnaies = CryptoMonnaieDAO.listerMonnaies();
            vue.montrerCrypto(listeMonnaies);

            //pokemon
            List<Pokemon> listePokemon = pokemonDAO.listerPokemon();
            vue.montrerPokemon(listePokemon);

            //nouvelles
            List<Nouvelle> listeNouvelles = nouvelleDAO.listerNouvelles();
            vue.montrerNouvelles(listeNouvelles);
        }


        //section reserver a parsing et a l'ajout des donnes dans les fenetres

        public void activerVueMonnaie(MonnaieVue vue)
        {
            List<CryptoMonnaie> listeMonnaies = CryptoMonnaieDAO.listerMonnaies();
            vue.montrerMonnaie(listeMonnaies);
        }

        public void activerVueNouvelle(NouvelleVue vue)
        {
            
            List<Nouvelle> listeNouvelles = nouvelleDAO.listerNouvelles();
            vue.montrerNouvelle(listeNouvelles);

        }

        public void activerVuePokemon(PokemonVue vue)
        {
            List<Pokemon> listePokemon = pokemonDAO.listerPokemon();
            vue.montrerPokemon(listePokemon);
        }

        public void notifierMeteo(MeteoVue vue)
        {
            List<Meteo> listeMeteo = MeteoDAO.listerMeteoMatane();
            vue.montrerMeteo(listeMeteo);
        }
        
    }
}
