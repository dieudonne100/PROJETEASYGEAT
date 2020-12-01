using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetEassyGest.BO
{
    public class Factures
    {
        public int IdFacture { get; set; }

        public string Designation { get; set; }

        public int Price { get; set; }

        public int PriceTotal { get; set; }

        public int IdReservation { get; set; }

        public int IdTypeMenu { get; set; }

        public Factures()
        {
        }

        public Factures(int idFacture, string designation, int price, int priceTotal, int idReservation, int idTypeMenu)
        {
            IdFacture = idFacture;
            Designation = designation;
            Price = price;
            PriceTotal = priceTotal;
            IdReservation = idReservation;
            IdTypeMenu = idTypeMenu;
        }
    }
}
