using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetEassyGest.BO
{
    public class Tables
    {
        public int IdTable { get; set; }

        public int NumberPlace { get; set; }

        public string ClasseTable { get; set; }

        public Tables()
        {
        }

        public Tables(int idTable, int numberPlace, string classeTable)
        {
            IdTable = idTable;
            NumberPlace = numberPlace;
            ClasseTable = classeTable;
        }
    }
}
