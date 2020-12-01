using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetEassyGest.BO
{
    public class TypeMenu
    {
        public int IdTypeMenu { get; set; }

        public string NomMenu { get; set; }

        public TypeMenu()
        {
        }

        public TypeMenu(int idTypeMenu, string nomMenu)
        {
            IdTypeMenu = idTypeMenu;
            NomMenu = nomMenu;
        }
    }
}
