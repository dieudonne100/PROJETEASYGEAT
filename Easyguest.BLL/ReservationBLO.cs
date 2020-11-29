using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easyguest.BLL
{
    public class ReservationBLO
    {
        ReservationDAO reservationRepo;
        private string dbFolder;

        public ReservationBLO(string dbFolder)
        {
            reservationRepo = new ReservationDAO(dbFolder);
        }

        public void CreateReservation(Reservation reservation)
        {
            reservationRepo.Add(reservation);
        }

        public void DeleteReservation(Reservation reservation)
        {
            reservationRepo.Remove(reservation);
        }


        public IEnumerable<Reservation> GetAllReservations()
        {
            return reservationRepo.Find();
        }


        public IEnumerable<Reservation> GetByReference(string reference)
        {
            return reservationRepo.Find(x => x.Reference == reference);
        }

        public IEnumerable<Reservation> GetBy(Func<Reservation, bool> predicate)
        {
            return reservationRepo.Find(predicate);
        }

        public void EditReservation(Reservation oldReservation, Reservation newReservation)
        {
            reservationRepo.Set(oldReservation, newReservation);
        }

        public Reservation GetReservation()
        {
            Reservation reservation = reservationRepo.Get();
            return reservation;
        }
    }
}
