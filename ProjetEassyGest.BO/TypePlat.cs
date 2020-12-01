using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetEassyGest.BO
{
    public class TypePlat
    {
        public int IdTypePlat { get; set; }

        public string NomTypePlat { get; set; }

        public TypePlat()
        {
        }

        public TypePlat(int idTypePlat, string nomTypePlat)
        {
            IdTypePlat = idTypePlat;
            NomTypePlat = nomTypePlat;
        }
    }
}
