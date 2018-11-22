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
    /// Logique d'interaction pour Window7.xaml
    /// </summary>
    public partial class Window7 : Window
    {
        ParseurPokemon pokemonDAO = new ParseurPokemon();
        public Window7()
        {
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            InitializeComponent();
            montrerPokemon();
        }

        public void montrerPokemon()
        {
            List<Pokemon> listePokemon = pokemonDAO.listerPokemon();

            Pokemon poke1 = listePokemon[0];
            pokemonTrouver1.Text = poke1.nom;

            Pokemon poke2 = listePokemon[1];
            pokemonTrouver2.Text = poke2.nom;

            Pokemon poke3 = listePokemon[2];
            pokemonTrouver3.Text = poke3.nom;

            Pokemon poke4 = listePokemon[3];
            pokemonTrouver4.Text = poke4.nom;
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
