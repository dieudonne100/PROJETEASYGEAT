using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetEassyGest.BO
{
    public class Menu
    {
        public int IdMenu { get; set; }

        public string NomMenu { get; set; }

        public string Attribut { get; set; }

        public Menu()
        {
        }

        public Menu(int idMenu, string nomMenu, string attribut)
        {
            IdMenu = idMenu;
            NomMenu = nomMenu;
            Attribut = attribut;
        }
    }
}
