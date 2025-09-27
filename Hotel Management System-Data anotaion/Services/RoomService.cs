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
    public class RoomService
    {
        private readonly HotelContext _ctx;
        public RoomService(HotelContext ctx)
        {
            _ctx = ctx;
        }


        public IEnumerable<Room> GetAvailableRooms()
        {
            return _ctx.Rooms
            .Where(r => r.IsAvailable)
          
            .ToList();
        }


        public IEnumerable<Room> GetRoomsByType(string type)
        {
            return _ctx.Rooms
            .Where(r => r.RoomType.ToLower() == (type ?? string.Empty).ToLower())
          
            .ToList();
        }
    }
}
