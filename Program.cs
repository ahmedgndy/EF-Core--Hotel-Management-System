using Hotel_Management_System.Data.Contexts;
using Hotel_Management_System.Repositries;

namespace Hotel_Management_System
{
    internal class Program
    {
        static  void Main(string[] args)
        {
            using (var context = new AppDbContext() )
            {
                var Gustsrepo = new GustRepository(context);
                var gusts = Gustsrepo.GetAllGuestsWithReservations();
                foreach (var gust in gusts)
                {
                    Console.WriteLine(gust.FullName);
                    Console.WriteLine(gust.Reservations);
                }  

            }


            using (var context = new AppDbContext())
            {
                var Gustsrepo = new GustRepository(context);
                var gust = Gustsrepo.FindGuestByPhone(phone: "11111111111");
              
                    Console.WriteLine(gust.FullName);
                 
                

            }

        }
    }
}
