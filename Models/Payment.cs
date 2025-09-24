﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System.Models;
internal class Payment
{
    public int Id { get; set; }
    public int ReservationId { get; set; }

    public Reservation Reservation { get; set; }
    public decimal Amount { get; set; } 
    public DateTime PaymentDate { get; set; }

    public string PaymentMethoud { get; set; }  
}

