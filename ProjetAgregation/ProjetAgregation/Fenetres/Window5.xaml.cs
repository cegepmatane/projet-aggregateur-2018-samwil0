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
    /// Logique d'interaction pour Window5.xaml
    /// </summary>
    public partial class Window5 : Window
    {
        ParseurNews nouvelleDAO = new ParseurNews();
        public Window5()
        {
            
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            InitializeComponent();
            montrerNouvelles();
        }
        //commende pour aficher les nouvelles
        private void montrerNouvelles()
        {
            string rssReddit = "https://www.reddit.com/.rss";
            List<Nouvelle> listeNouvelles = nouvelleDAO.listerNouvelles(rssReddit);

            // il faut partir au 7em element car les 6 premier ne sont pas des nouvelles
            Nouvelle new1 = listeNouvelles[7];
            nouvelle1.Text = new1.name;

            Nouvelle new2 = listeNouvelles[8];
            nouvelle2.Text = new2.name;

            Nouvelle new3 = listeNouvelles[9];
            nouvelle3.Text = new3.name;

            Nouvelle new4 = listeNouvelles[10];
            nouvelle4.Text = new4.name;

            Nouvelle new5 = listeNouvelles[11];
            nouvelle5.Text = new5.name;

            Nouvelle new6 = listeNouvelles[12];
            nouvelle6.Text = new6.name;

            Nouvelle new7 = listeNouvelles[13];
            nouvelle7.Text = new7.name;

            Nouvelle new8 = listeNouvelles[14];
            nouvelle8.Text = new8.name;

            Nouvelle new9 = listeNouvelles[15];
            nouvelle9.Text = new9.name;

            Nouvelle new10 = listeNouvelles[16];
            nouvelle10.Text = new10.name;
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
