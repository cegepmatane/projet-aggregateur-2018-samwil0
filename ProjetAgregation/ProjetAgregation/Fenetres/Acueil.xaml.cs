using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using ProjetAgregation.Code;

namespace ProjetAgregation.Fenetres
{
    /// <summary>
    /// Logique d'interaction pour Acueil.xaml
    /// </summary>
    public partial class Acueil : Window
    {


        ParseurNews nouvelleDAO = new ParseurNews();
        ParseurMeteo MeteoDAO = new ParseurMeteo();
        ParseurPokemon pokemonDAO = new ParseurPokemon();
        CryptoMonnaie cryptomonnaieDAO = new CryptoMonnaie();


        public Acueil()
        {
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            InitializeComponent();
            montrerNouvelles();
            montrerMeteo();
            montrerPokemon();
            montrerMonnaie();
        }



        //commende pour aficher les nouvelles
        private void montrerNouvelles()
        {
            string rssReddit = "https://www.reddit.com/.rss";
            List<Nouvelle> listeNouvelles = nouvelleDAO.listerNouvelles(rssReddit);

            // il faut partir au 7em element car les 6 premier ne sont pas des nouvelles
            Nouvelle new1 = listeNouvelles[7];
            news.Text = news.Text + new1.name;
        }

        private void montrerMeteo()
        {
            string meteoMediaMatane = "http://rss.meteomedia.com/weather/caqc0342";
            List<Meteo> listeMeteo = MeteoDAO.listerMeteo(meteoMediaMatane);

            Meteo meteo1 = listeMeteo[0];
            temp.Text = temp.Text + meteo1.description;
        }


        public void montrerPokemon()
        {
            List<Pokemon> listePokemon = pokemonDAO.listerPokemon();

            Pokemon poke1 = listePokemon[0];
            pokemon.Text = pokemon.Text + poke1.nom;
        }

        private void montrerMonnaie()
        {
            List<CryptoMonnaie> listeMonnaies = ParseurCryptoMonnaie.listerMonnaies();
            CryptoMonnaie monnaie1 = listeMonnaies[1];
            monaie.Text = monaie.Text + monnaie1.nom;

        }

        //Fonctions reserver pour changer de fenetre
        private void Acueil_Click(object sender, RoutedEventArgs e)
        {
            Window1 acueil = new Window1();
            acueil.Show();
            App.Current.MainWindow = acueil;
            this.Close();
        }
        private void Amis_Click(object sender, RoutedEventArgs e)
        {
            Window2 amis = new Window2();
            amis.Show();
            App.Current.MainWindow = amis;
            this.Close();
        }
        private void Email_Click(object sender, RoutedEventArgs e)
        {
            Window3 email = new Window3();
            email.Show();
            App.Current.MainWindow = email;
            this.Close();
        }
        private void Graph_Click(object sender, RoutedEventArgs e)
        {
            Window4 graph = new Window4();
            graph.Show();
            App.Current.MainWindow = graph;
            this.Close();
        }
        private void News_Click(object sender, RoutedEventArgs e)
        {
            Window5 news = new Window5();
            news.Show();
            App.Current.MainWindow = news;
            this.Close();
        }
        private void Chat_Click(object sender, RoutedEventArgs e)
        {
            Window6 chat = new Window6();
            chat.Show();
            App.Current.MainWindow = chat;
            this.Close();
        }
        private void Pokemon_Click(object sender, RoutedEventArgs e)
        {
            Window7 pokemon = new Window7();
            pokemon.Show();
            App.Current.MainWindow = pokemon;
            this.Close();
        }
        private void Crypto_Click(object sender, RoutedEventArgs e)
        {
            Window8 crypto = new Window8();
            crypto.Show();
            App.Current.MainWindow = crypto;
            this.Close();
        }

        private void Menu_Click(object sender, RoutedEventArgs e)
        {
            MainWindow menu = new MainWindow();
            menu.Show();
            App.Current.MainWindow = menu;
            this.Close();
        }


    }
}
