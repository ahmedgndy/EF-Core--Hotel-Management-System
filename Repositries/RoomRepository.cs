using Hotel_Management_System.Data.Contexts;
using Hotel_Management_System.Interfaces;
using Hotel_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System.Repositries;
public class RoomRepository(AppDbContext context) : IRoomRepository
{
    public List<Room> GetAvailableRooms()
    {
        return context.Rooms.Where(r => r.IsAvailable == true).ToList();
    }

    public Room? GetRoomByType(string type)
    {
        return context.Rooms.FirstOrDefault(r => r.RoomType == type);
    }
}

