﻿using System;
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
    /// Logique d'interaction pour Pokedex.xaml
    /// </summary>
    public partial class Pokedex : Window
    {
        ParseurPokemon pokemonDAO = new ParseurPokemon();
        public Pokedex()
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


        //Fonctions reserver pour appeler le changement de fenetre
        private void Menu_Click(object sender, RoutedEventArgs e)
        {
            WindowsSwitcher.Loader("Menu");
            Console.WriteLine("La fenetre Acueil a ete loder, la presente va fermer");
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
