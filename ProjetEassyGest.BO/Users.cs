using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetEassyGest.BO
{
    public class Users
    {
        public int IdUser { get; set; }

        public string NomUser { get; set; }

        public string SurnameUser { get; set; }

        public string PasswordUser { get; set; }

        public double PhoneUser { get; set; }

        public string AddresseUser { get; set; }

        public int IdRole { get; set; }

        public Users()
        {
        }

        public Users(int idUser, string nomUser, string surnameUser, string passwordUser, double phoneUser, string addresseUser, int idRole)
        {
            IdUser = idUser;
            NomUser = nomUser;
            SurnameUser = surnameUser;
            PasswordUser = passwordUser;
            PhoneUser = phoneUser;
            AddresseUser = addresseUser;
            IdRole = idRole;
        }
    }
}
