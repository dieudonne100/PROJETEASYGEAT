using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetEassyGest.BO
{
    public class Client
    {
        public int IdClient { get; set; }

        public string NomClient { get; set; }

        public string SurnameClient { get; set; }

        public string PasswordClient { get; set; }

        public double PhoneClient { get; set; }

        public string AddresseClient { get; set; }

        public int IdRole { get; set; }

        public Client()
        {
        }

        public Client(int idClient, string nomClient, string surnameClient, string passwordClient, double phoneClient, string addresseClient, int idRole)
        {
            IdClient = idClient;
            NomClient = nomClient;
            SurnameClient = surnameClient;
            PasswordClient = passwordClient;
            PhoneClient = phoneClient;
            AddresseClient = addresseClient;
            IdRole = idRole;
        }
    }
}
