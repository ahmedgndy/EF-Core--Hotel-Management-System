using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System.Models;
internal class Reservation
{
    public int Id { get; set; }
    public int GuestId { get; set; } 
    public int RoomId { get; set; }

    public DateTime CheckInDate { get; set; }
    public DateTime CheckOutDate { get; set; }

    public decimal TotalAmout { get; set; }

    public Guest Guest { get; set; }
    public Room Room { get; set; }  

    public Payment Payment { get; set; }
    


}

