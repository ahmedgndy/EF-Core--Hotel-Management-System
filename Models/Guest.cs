using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System.Models;
internal class Guest
{
    public int GuestId { get; set; }
    public string FullName { get; set; }

    public string Phone;

    public string? Email;

    //list of reservitions
    public List<Reservation>? Reservations { get; set; }

}

