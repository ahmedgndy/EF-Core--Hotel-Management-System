using Hotel_Management_System.Data.Contexts;
using Hotel_Management_System.Repositries;

namespace Hotel_Management_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //get all gests
            
            using (var context = new AppDbContext())
            {
                var Gustsrepo = new GustRepository(context);
                var guests = Gustsrepo.GetAllGuestsWithReservations();
                foreach (var guest in guests)
                {
                    Console.WriteLine(guest.FullName);
                    if (guest.Reservations.Count() !=0)
                        Console.WriteLine(guest.Reservations[0].Room);
                }

            }

            //get all guest by  id 
     
            using (var context = new AppDbContext())
            {
                var Gustsrepo = new GustRepository(context);
                var gust = Gustsrepo.FindGuestByPhone(phone: "11111111111");

                Console.WriteLine(gust.FullName);

            }
            
            //3.Show available rooms
            using (var context = new AppDbContext())
            {
                var RoomRepo = new RoomRepository(context);
                var rooms = RoomRepo.GetAvailableRooms();
                foreach (var room in rooms)
                {
                    Console.WriteLine($"room number : {room.RoomNumber} is available");
                }
            }

            //3-Show current reservations
            /*
            using (var context = new AppDbContext())
            {
                var ResevitionRepo = new ReservationRepository(context);
                var reservations = ResevitionRepo.GetCurrentReservations();
                foreach (var reservation in reservations)
                {
                    Console.WriteLine($"reservation  : {reservation.CheckInDate} is available");
                }
            }*/
        }
    } 
}
