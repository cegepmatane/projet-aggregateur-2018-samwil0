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
using System.Windows.Navigation;
using System.Windows.Shapes;
using ProjetAgregation.Fenetres;


namespace ProjetAgregation
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            InitializeComponent();
        }

        private void TextBox_TextChanged()
        {

        }


        //Fonctions reserver pour changer de fenetre
        private void Acueil_Click(object sender, RoutedEventArgs e)
        {
            Window1 acueil = new Window1();
            acueil.Show();
            this.Hide();
        }
        private void Amis_Click(object sender, RoutedEventArgs e)
        {
            Window2 amis = new Window2();
            amis.Show();
            this.Hide();
        }
        private void Email_Click(object sender, RoutedEventArgs e)
        {
            Window3 email = new Window3();
            email.Show();
            this.Hide();
        }
        private void Graph_Click(object sender, RoutedEventArgs e)
        {
            Window4 graph = new Window4();
            graph.Show();
            this.Hide();
        }
        private void News_Click(object sender, RoutedEventArgs e)
        {
            Window5 news = new Window5();
            news.Show();
            this.Hide();
        }
        private void Chat_Click(object sender, RoutedEventArgs e)
        {
            Window6 chat = new Window6();
            chat.Show();
            this.Hide();
        }
        private void Pokemon_Click(object sender, RoutedEventArgs e)
        {
            Window7 pokemon = new Window7();
            pokemon.Show();
            this.Hide();
        }
        private void Crypto_Click(object sender, RoutedEventArgs e)
        {
            Window8 crypto = new Window8();
            crypto.Show();
            this.Hide();
        }

    }
}
