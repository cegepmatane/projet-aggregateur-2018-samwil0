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
                    Graph graph = new Graph();
                    graph.Show();
                    App.Current.MainWindow = graph;
                    FenetreChoisie = null;
                    break;
                case "Monaie":
                    Monaie monaie = new Monaie();
                    monaie.Show();
                    App.Current.MainWindow = monaie;
                    FenetreChoisie = null;
                    break;
                case "News":
                    News news = new News();
                    news.Show();
                    App.Current.MainWindow = news;
                    FenetreChoisie = null;
                    break;
                case "Pokemon":
                    Pokedex pokemon = new Pokedex();
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
    }
}