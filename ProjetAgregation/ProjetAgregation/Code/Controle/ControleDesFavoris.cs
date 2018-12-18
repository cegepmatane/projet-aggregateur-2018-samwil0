using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetAgregation.Code.Modelle;

namespace ProjetAgregation.Code.Controle
{
    public class ControleDesFavoris
    {

        public List<Favoris> listFavoris = new List<Favoris>();

        public void ajouterFavoris(String texte)
        {
            Favoris favoris = new Favoris();
            favoris.contenu = texte;
            listFavoris.Add(favoris);
        }

        public List<Favoris> GetListFavoris()
        {
            return this.listFavoris;
        }

    }
}
