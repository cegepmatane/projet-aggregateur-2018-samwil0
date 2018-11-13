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

namespace ProjetAgregation.Fenetres
{
    /// <summary>
    /// Logique d'interaction pour Window6.xaml
    /// </summary>
    public partial class Window6 : Window
    {
        public Window6()
        {
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            InitializeComponent();
        }

        //Fonctions reserver pour changer de fenetre
        private void Acueil_Click(object sender, RoutedEventArgs e)
        {
            Window1 acueil = new Window1();
            acueil.Show();
            this.Close();
        }
        private void Amis_Click(object sender, RoutedEventArgs e)
        {
            Window2 amis = new Window2();
            amis.Show();
            this.Close();
        }
        private void Email_Click(object sender, RoutedEventArgs e)
        {
            Window3 email = new Window3();
            email.Show();
            this.Close();
        }
        private void Graph_Click(object sender, RoutedEventArgs e)
        {
            Window4 graph = new Window4();
            graph.Show();
            this.Close();
        }
        private void News_Click(object sender, RoutedEventArgs e)
        {
            Window5 news = new Window5();
            news.Show();
            this.Close();
        }
        private void Chat_Click(object sender, RoutedEventArgs e)
        {
            Window6 chat = new Window6();
            chat.Show();
            this.Close();
        }
        private void Pokemon_Click(object sender, RoutedEventArgs e)
        {
            Window7 pokemon = new Window7();
            pokemon.Show();
            this.Close();
        }
        private void Crypto_Click(object sender, RoutedEventArgs e)
        {
            Window8 crypto = new Window8();
            crypto.Show();
            this.Close();
        }
        private void Menu_Click(object sender, RoutedEventArgs e)
        {
            App.Current.MainWindow.Show();
            this.Close();
        }
    }
}
