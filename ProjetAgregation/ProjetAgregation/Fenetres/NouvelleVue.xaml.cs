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
using ProjetAgregation.Code.Controle;


namespace ProjetAgregation.Fenetres
{
    /// <summary>
    /// Logique d'interaction pour News.xaml
    /// </summary>
    public partial class NouvelleVue : Window
    {
        ControleDesDonnesRecus ControleDesDonnesRecus = new ControleDesDonnesRecus();
        ControleDesFavoris ControleDesFavoris = new ControleDesFavoris();

        public NouvelleVue()
        {
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            InitializeComponent();
            ControleDesDonnesRecus.activerVueNouvelle(this);
        }


        public ControleDesFavoris GetCtrlFav()
        {
            return this.ControleDesFavoris;
        }


        //section pour l'ajout de favoris
        private void Favoris1_Click(object sender, RoutedEventArgs e)
        {
            ControleDesFavoris.ajouterFavoris(nouvelle1.Text);
        }
        private void Favoris2_Click(object sender, RoutedEventArgs e)
        {
            ControleDesFavoris.ajouterFavoris(nouvelle2.Text);
        }
        private void Favoris3_Click(object sender, RoutedEventArgs e)
        {
            ControleDesFavoris.ajouterFavoris(nouvelle3.Text);
        }
        private void Favoris4_Click(object sender, RoutedEventArgs e)
        {
            ControleDesFavoris.ajouterFavoris(nouvelle4.Text);
        }
        private void Favoris5_Click(object sender, RoutedEventArgs e)
        {
            ControleDesFavoris.ajouterFavoris(nouvelle5.Text);
        }
        private void Favoris6_Click(object sender, RoutedEventArgs e)
        {
            ControleDesFavoris.ajouterFavoris(nouvelle6.Text);
        }
        private void Favoris7_Click(object sender, RoutedEventArgs e)
        {
            ControleDesFavoris.ajouterFavoris(nouvelle7.Text);
        }
        private void Favoris8_Click(object sender, RoutedEventArgs e)
        {
            ControleDesFavoris.ajouterFavoris(nouvelle8.Text);
        }
        private void Favoris9_Click(object sender, RoutedEventArgs e)
        {
            ControleDesFavoris.ajouterFavoris(nouvelle9.Text);
        }
        private void Favoris10_Click(object sender, RoutedEventArgs e)
        {
            ControleDesFavoris.ajouterFavoris(nouvelle10.Text);
        }


        public void montrerNouvelle(List<Nouvelle> listeNouvelles)
        {
            // il faut partir au 7em element car les 6 premier ne sont pas des nouvelles
            Nouvelle new1 = listeNouvelles[7];
            this.nouvelle1.Text = new1.name;

            Nouvelle new2 = listeNouvelles[8];
            this.nouvelle2.Text = new2.name;

            Nouvelle new3 = listeNouvelles[9];
            this.nouvelle3.Text = new3.name;

            Nouvelle new4 = listeNouvelles[10];
            this.nouvelle4.Text = new4.name;

            Nouvelle new5 = listeNouvelles[11];
            this.nouvelle5.Text = new5.name;

            Nouvelle new6 = listeNouvelles[12];
            this.nouvelle6.Text = new6.name;

            Nouvelle new7 = listeNouvelles[13];
            this.nouvelle7.Text = new7.name;

            Nouvelle new8 = listeNouvelles[14];
            this.nouvelle8.Text = new8.name;

            Nouvelle new9 = listeNouvelles[15];
            this.nouvelle9.Text = new9.name;

            Nouvelle new10 = listeNouvelles[16];
            this.nouvelle10.Text = new10.name;

            Console.WriteLine("Nouvelles ajouter dans les TextBox");
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




        //bouton experimentale pour les favoris
        private void Favoris_Click(object sender, RoutedEventArgs e)
        {
            WindowsSwitcher.LoaderFavoris(this);
            Console.WriteLine("La fenetre Favoris a ete loder, la presente va fermer");
            this.Close();
        }

    }
}
