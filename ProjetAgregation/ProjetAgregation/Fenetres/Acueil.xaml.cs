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
using ProjetAgregation.Code.Controle;

namespace ProjetAgregation.Fenetres
{
    /// <summary>
    /// Logique d'interaction pour Acueil.xaml
    /// </summary>
    public partial class Acueil : Window
    {
        ControleDesDonnesRecus controleDonnees = null;

        public Acueil()
        {
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            InitializeComponent();
            this.controleDonnees = new ControleDesDonnesRecus();
            this.controleDonnees.activerVueAccueil(this);
        }

        public void montrerMeteo(List<Meteo> listeMeteo)
        {
            Meteo meteo1 = listeMeteo[0];
            this.temp.Text = this.temp.Text + meteo1.description;
            Console.WriteLine("Meteo ajouter dans la TextBox");
        }

        public void montrerCrypto(List<CryptoMonnaie> listeMonnaies)
        {
            CryptoMonnaie monnaie1 = listeMonnaies[1];
            this.monaie.Text = this.monaie.Text + monnaie1.nom;
            Console.WriteLine("Monaie ajouter dans la TextBox");
        }

        public void montrerPokemon(List<Pokemon> listePokemon)
        {
            Pokemon poke1 = listePokemon[0];
            this.pokemon.Text = this.pokemon.Text + poke1.nom;
            Console.WriteLine("Pokemon ajouter dans la TextBox");
        }

        public void montrerNouvelles(List<Nouvelle> listeNouvelles)
        {
            // il faut partir au 7em element car les 6 premier ne sont pas des nouvelles
            Nouvelle new1 = listeNouvelles[7];
            this.news.Text = this.news.Text + new1.name;
            Console.WriteLine("Nouvelle ajouter dans la TextBox");
        }

        //Fonctions reserver pour appeler le changement de fenetre
        private void Menu_Click(object sender, RoutedEventArgs e)
        {
            WindowsSwitcher.Loader("Menu");
            Console.WriteLine("La fenetre Menu a ete loder, la presente va fermer");
            this.Close();
        }
        private void Acueil_Click(object sender, RoutedEventArgs e)
        {
            WindowsSwitcher.Loader("Acueil");
            Console.WriteLine("La fenetre Acueil a ete loder, la presente va fermer");
            this.Close();
        }
        private void Amis_Click(object sender, RoutedEventArgs e)
        {
            WindowsSwitcher.Loader("Amis");
            Console.WriteLine("La fenetre Amis a ete loder, la presente va fermer");
            this.Close();
        }
        private void Email_Click(object sender, RoutedEventArgs e)
        {
            WindowsSwitcher.Loader("Email");
            Console.WriteLine("La fenetre Email a ete loder, la presente va fermer");
            this.Close();
        }
        private void Graph_Click(object sender, RoutedEventArgs e)
        {
            WindowsSwitcher.Loader("Graph");
            Console.WriteLine("La fenetre Graph a ete loder, la presente va fermer");
            this.Close();
        }
        private void News_Click(object sender, RoutedEventArgs e)
        {
            WindowsSwitcher.Loader("News");
            Console.WriteLine("La fenetre News a ete loder, la presente va fermer");
            this.Close();
        }
        private void Chat_Click(object sender, RoutedEventArgs e)
        {
            WindowsSwitcher.Loader("Chat");
            Console.WriteLine("La fenetre Chat a ete loder, la presente va fermer");
            this.Close();
        }
        private void Pokemon_Click(object sender, RoutedEventArgs e)
        {
            WindowsSwitcher.Loader("Pokemon");
            Console.WriteLine("La fenetre Pokemon a ete loder, la presente va fermer");
            this.Close();
        }
        private void Crypto_Click(object sender, RoutedEventArgs e)
        {
            WindowsSwitcher.Loader("Monaie");
            Console.WriteLine("La fenetre Monaie a ete loder, la presente va fermer");
            this.Close();
        }


    }
}
