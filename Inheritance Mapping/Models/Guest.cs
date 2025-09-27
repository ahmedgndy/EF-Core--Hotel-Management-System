using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Mapping.Models;

public abstract class Guest
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public string Phone { get; set; }
    public string? Email { get; set; }
    public List<Reservation> Reservations { get; set; } = new List<Reservation>();
}
