using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System_Data_anotaion.Models
{
    public class Payment
    {
        [Key]
        public int PaymentId { get; set; }


        [Required]
        [ForeignKey("Reservation")]
        public int ReservationId { get; set; }
        public Reservation Reservation { get; set; }


        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Amount { get; set; }


        [Required]
        public DateTime PaymentDate { get; set; }


        [StringLength(50)]
        public string PaymentMethod { get; set; }
    }
}
