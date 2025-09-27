using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System_Data_anotaion.Models
{
    public class Guest
    {
        [Key]
        public int GuestId { get; set; }


        [Required]
        [StringLength(50)]
        public string FullName { get; set; }


        [Required]
        [StringLength(20)]
        public string Phone { get; set; }


        [StringLength(100)]
        public string Email { get; set; }


        // Navigation
        public ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
    }
}
