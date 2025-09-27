using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System_Data_anotaion.Models
{
    public class Room
    {
        [Key]
        public int RoomId { get; set; }


        [Required]
        [StringLength(10)]
        public string RoomNumber { get; set; }


        [Required]
        [StringLength(20)]
        public string RoomType { get; set; }


        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal PricePerNight { get; set; }


        [Required]
        public bool IsAvailable { get; set; }


        public ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
    }
}
