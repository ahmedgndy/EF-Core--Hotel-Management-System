using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System.Models;

public class Room
{
    public int RoomId { get; set; }
    public int RoomNumber { get; set; }

    public string RoomType { get; set; }
    public decimal PricePerNight {  get; set; }

    public bool IsAvailable { get; set; }

    //list of Reservations
    public List<Reservation>? Reservations { get; set; }
        
}

