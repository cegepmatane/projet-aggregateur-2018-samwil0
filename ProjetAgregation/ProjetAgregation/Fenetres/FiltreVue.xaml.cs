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
    /// Logique d'interaction pour FiltreVue.xaml
    /// </summary>
    public partial class FiltreVue : Window
    {

        public ControleDesFavoris ControleDesFavoris;
        public ControleDesFiltres ControleDesFiltres = new ControleDesFiltres();

        public FiltreVue()
        {
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            InitializeComponent();
        }



        public void montrerFiltres()
        {
            if (ControleDesFiltres.listElementFiltrer.ElementAtOrDefault(0) != null)
            {
                this.favoris1.Text = ControleDesFiltres.listElementFiltrer[0];
            }
            if (ControleDesFiltres.listElementFiltrer.ElementAtOrDefault(1) != null)
            {
                this.favoris2.Text = ControleDesFiltres.listElementFiltrer[1];
            }
            if (ControleDesFiltres.listElementFiltrer.ElementAtOrDefault(2) != null)
            {
                this.favoris3.Text = ControleDesFiltres.listElementFiltrer[2];
            }
            if (ControleDesFiltres.listElementFiltrer.ElementAtOrDefault(3) != null)
            {
                this.favoris4.Text = ControleDesFiltres.listElementFiltrer[3];
            }
            if (ControleDesFiltres.listElementFiltrer.ElementAtOrDefault(4) != null)
            {
                this.favoris5.Text = ControleDesFiltres.listElementFiltrer[4];
            }
            if (ControleDesFiltres.listElementFiltrer.ElementAtOrDefault(5) != null)
            {
                this.favoris6.Text = ControleDesFiltres.listElementFiltrer[5];
            }
            if (ControleDesFiltres.listElementFiltrer.ElementAtOrDefault(6) != null)
            {
                this.favoris7.Text = ControleDesFiltres.listElementFiltrer[6];
            }
            if (ControleDesFiltres.listElementFiltrer.ElementAtOrDefault(7) != null)
            {
                this.favoris8.Text = ControleDesFiltres.listElementFiltrer[7];
            }
            if (ControleDesFiltres.listElementFiltrer.ElementAtOrDefault(8) != null)
            {
                this.favoris9.Text = ControleDesFiltres.listElementFiltrer[8];
            }
            if (ControleDesFiltres.listElementFiltrer.ElementAtOrDefault(9) != null)
            {
                this.favoris10.Text = ControleDesFiltres.listElementFiltrer[9];
            }
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
