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
    public class GuestService
    {
        private readonly HotelContext _ctx;
        public GuestService(HotelContext ctx)
        {
            _ctx = ctx;
        }


        public IEnumerable<Guest> GetAllGuestsWithReservations()
        {
            return _ctx.Guests
            .Include(g => g.Reservations)
            .ThenInclude(r => r.Room)
            .AsNoTracking()
            .ToList();
        }


        public Guest FindGuestByPhone(string phone)
        {
            if (string.IsNullOrWhiteSpace(phone)) return null;
            return _ctx.Guests
            .Include(g => g.Reservations)
            .ThenInclude(r => r.Room)
            .AsNoTracking()
            .FirstOrDefault(g => g.Phone == phone);
        }
    }
}
