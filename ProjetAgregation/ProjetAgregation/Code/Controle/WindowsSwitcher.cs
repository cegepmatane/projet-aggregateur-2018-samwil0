using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetAgregation.Fenetres;
using ProjetAgregation;

namespace ProjetAgregation.Code
{
    public static class WindowsSwitcher
    {
        public static string FenetreChoisie;
        //Fonctions reserver pour changer de fenetre
        public static void Loader(String FenetreChoisie)
        {
            Console.WriteLine("La fenetre choisie et charger est " + FenetreChoisie);
            switch (FenetreChoisie)
            {
                case "Menu":
                    MainWindow menu = new MainWindow();
                    menu.Show();
                    App.Current.MainWindow = menu;
                    FenetreChoisie = null;
                    break;
                case "Acueil":
                    Acueil acueil = new Acueil();
                    acueil.Show();
                    App.Current.MainWindow = acueil;
                    FenetreChoisie = null;
                    break;
                case "Amis":
                    Amis amis = new Amis();
                    amis.Show();
                    App.Current.MainWindow = amis;
                    FenetreChoisie = null;
                    break;
                case "Chat":
                    Chat chat = new Chat();
                    chat.Show();
                    App.Current.MainWindow = chat;
                    FenetreChoisie = null;
                    break;
                case "Email":
                    Email email = new Email();
                    email.Show();
                    App.Current.MainWindow = email;
                    FenetreChoisie = null;
                    break;
                case "Graph":
                    MeteoVue graph = new MeteoVue();
                    graph.Show();
                    App.Current.MainWindow = graph;
                    FenetreChoisie = null;
                    break;
                case "Monaie":
                    MonnaieVue monaie = new MonnaieVue();
                    monaie.Show();
                    App.Current.MainWindow = monaie;
                    FenetreChoisie = null;
                    break;
                case "News":
                    NouvelleVue news = new NouvelleVue();
                    news.Show();
                    App.Current.MainWindow = news;
                    FenetreChoisie = null;
                    break;
                case "Pokemon":
                    PokemonVue pokemon = new PokemonVue();
                    pokemon.Show();
                    App.Current.MainWindow = pokemon;
                    FenetreChoisie = null;
                    break;
                default:
                    MainWindow menuEreur = new MainWindow();
                    menuEreur.Show();
                    App.Current.MainWindow = menuEreur;
                    FenetreChoisie = null;
                    Console.WriteLine("Erreur dans les choix de fenetre, retour au menu");
                    break;
            }



        }


        //reserver pour loder favoris et filtre pour le tp3
        public static void LoaderFavoris(NouvelleVue vue)
        {
            {
                FavorisVue favoris = new FavorisVue();
                favoris.Show();
                App.Current.MainWindow = favoris;
                favoris.ControleDesFavoris = vue.GetCtrlFav();
                favoris.montrerFavoris();
            }
        }
        public static void LoaderFiltre(FavorisVue vue)
        {
            {
                FiltreVue filtrer = new FiltreVue();
                filtrer.Show();
                App.Current.MainWindow = filtrer;
                filtrer.ControleDesFavoris = vue.GetCtrlFav();

                filtrer.ControleDesFiltres.letreFiltre = vue.GetLetreAFiltrer();
                filtrer.ControleDesFiltres.SetListFavoris(filtrer.ControleDesFavoris.listFavoris);
                filtrer.ControleDesFiltres.Filtrer();

                filtrer.montrerFiltres();
            }
        }


    }
}