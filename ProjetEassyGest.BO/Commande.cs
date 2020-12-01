using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetEassyGest.BO
{
    public class Commande
    {
        public int IdCommande { get; set; }

        public int TypeCommande { get; set; }

        public Commande()
        {
        }

        public Commande(int idCommande, int typeCommande)
        {
            IdCommande = idCommande;
            TypeCommande = typeCommande;
        }
    }
}
