using Inheritance_Mapping.Data;
using Inheritance_Mapping.Repositories;

namespace Inheritance_Mapping
{
    internal class Program
    {
        static  void Main(string[] args)
        {
            using AppDbContext context = new AppDbContext();

            var repo = new GuestRepositories(context);

            var guests =  repo.GetAllGuests();
            foreach(var guest in guests) { 
                Console.WriteLine(guest.FullName);
            }

            var rv = repo.GetReservationsWithGuestInfo();
            foreach (var reservation in rv) {
                Console.WriteLine(reservation.Id);
                Console.WriteLine(reservation.Guest.FullName);
            }
        }
    }
}
