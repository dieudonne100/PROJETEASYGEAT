using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetEassyGest.BO
{
    public class Role
    {
        public int IdRole { get; set; }

        public string NomRole { get; set; }

        public Role()
        {
        }

        public Role(int idRole, string nomRole)
        {
            IdRole = idRole;
            NomRole = nomRole;
        }
    }
}
