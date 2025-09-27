using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System_Data_anotaion.Models
{
    public class Reservation
    {
        [Key]
        public int ReservationId { get; set; }


        [Required]
        [ForeignKey("Guest")]
        public int GuestId { get; set; }
        public Guest Guest { get; set; }


        [Required]
        [ForeignKey("Room")]
        public int RoomId { get; set; }
        public Room Room { get; set; }


        [Required]
        public DateTime CheckInDate { get; set; }


        [Required]
        public DateTime CheckOutDate { get; set; }


        // Calculated property (not mapped)
        [NotMapped]
        public decimal TotalAmount
        {
            get
            {
                if (Room == null) return 0m;
                var nights = (CheckOutDate.Date - CheckInDate.Date).Days;
                if (nights <= 0) return 0m;
                return Room.PricePerNight * nights;
            }
        }


        // Navigation
        public ICollection<Payment> Payments { get; set; } = new List<Payment>();
    }
}
