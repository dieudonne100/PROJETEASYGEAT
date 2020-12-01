using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetEassyGest.BO
{
    public class Reservation
    {
        public int IdReservation { get; set; }

        public int IdClient { get; set; }

        public DateTime TimeStar { get; set; }

        public DateTime TimeEnd { get; set; }

        public DateTime DateReservation { get; set; }

        public int IdTypeMenu { get; set; }

        public Reservation()
        {
        }

        public Reservation(int idReservation, int idClient, DateTime timeStar, DateTime timeEnd, DateTime dateReservation, int idTypeMenu)
        {
            IdReservation = idReservation;
            IdClient = idClient;
            TimeStar = timeStar;
            TimeEnd = timeEnd;
            DateReservation = dateReservation;
            IdTypeMenu = idTypeMenu;
        }
    }
}
