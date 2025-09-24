using Hotel_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System.Interfaces;
public interface IRoomRepository
{
    List<Room> GetAvailableRooms();
    Room? GetRoomByType(string type);
}

