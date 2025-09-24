using Hotel_Management_System.Data.Contexts;
using Hotel_Management_System.Interfaces;
using Hotel_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System.Repositries
{
    internal class ReservationRepository(AppDbContext context) : IReservationService
    {
        public List<Reservation> GetCurrentReservations()
        {
            var reservations = context.Reservations.Where(r => r.CheckInDate.Day >= DateTime.Now.Day);
            return reservations.ToList(); 
;        }

        public List<Reservation> GetReservationsByGuest(int guestId)
        {
           var guest = context.Guests.FirstOrDefault(g => g.Equals(guestId));
            if (guest is null)
                throw new ArgumentNullException(nameof(guestId), "Can not find guest with this ID");


            return guest.Reservations ;
        }
    }



}

