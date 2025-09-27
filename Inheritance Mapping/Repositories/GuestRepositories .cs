using Inheritance_Mapping.Data;
using Inheritance_Mapping.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Mapping.Repositories;

internal class GuestRepositories(AppDbContext context)
{

    //List all Guests
    public  List<Guest> GetAllGuests() {
        var allGuest =  context.Guests.ToList();
   
        if (allGuest is  null)
            return [] ;

        return allGuest;
        }

    public List<Reservation> GetReservationsWithGuestInfo() { 
        var allReservations =  context.Reservations.Include(r => r.Guest).ToList();
        return allReservations;
    }
    
}
