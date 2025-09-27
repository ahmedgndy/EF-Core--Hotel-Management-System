using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel_Management_System.Data.Contexts;
using Hotel_Management_System.Models;
using Hotel_Management_System.Interfaces;
using Microsoft.EntityFrameworkCore;
namespace Hotel_Management_System.Repositries;
public class GustRepository(AppDbContext context) : IGustRepository
{
   
    public Guest FindGuestByPhone(string phone)
    {
        var guest  = context.Guests.FirstOrDefault(g => g.Phone == phone);
        if (guest is null)
            throw  new ArgumentNullException(nameof(phone) ,"Can not find a user with this phone");
        return guest;
    }

    public  List<Guest> GetAllGuestsWithReservations()
    {
        var guests =  context.Guests.Include(g => g.Reservations).ToList();
        Console.WriteLine($"Found {guests.Count} guests");

        return guests;
    }
}

