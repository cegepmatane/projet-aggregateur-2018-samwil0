using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetAgregation.Code.Modelle;

namespace ProjetAgregation.Code.Controle
{
    public class ControleDesFiltres
    {
        public List<Favoris> listFavoris = new List<Favoris>();
        public List<String> listElementFiltrer = new List<String>();
        public string letreFiltre;

        public void SetListFavoris(List<Favoris> list)
        {
            listFavoris = list;
        }

        public void Filtrer()
        {
            int i = 0;
            foreach (Favoris element in listFavoris)
            {
                string elementTraiter = listFavoris[i].contenu;
                if (elementTraiter.ToLower().Contains(letreFiltre))
                {
                    listElementFiltrer.Add(elementTraiter);
                }
                i++;
            }
        }
    }
}
