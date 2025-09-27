using Hotel_Management_System_Data_anotaion.Data.Contexts;
using Hotel_Management_System_Data_anotaion.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System_Data_anotaion.Services
{
    public class ReservationService
    {
        private readonly HotelContext _ctx;
        public ReservationService(HotelContext ctx)
        {
            _ctx = ctx;
        }


        public IEnumerable<Reservation> GetReservationsByGuest(int guestId)
        {
            return _ctx.Reservations
            .Where(r => r.GuestId == guestId)
            .Include(r => r.Room)
            .Include(r => r.Payments)
            .AsNoTracking()
            .ToList();
        }


        public IEnumerable<Reservation> GetCurrentReservations()
        {
            var today = DateTime.UtcNow.Date;
            return _ctx.Reservations
            .Where(r => r.CheckInDate.Date <= today && r.CheckOutDate.Date >= today)
            .Include(r => r.Room)
            .Include(r => r.Guest)
            .AsNoTracking()
            .ToList();
        }
    }
}
