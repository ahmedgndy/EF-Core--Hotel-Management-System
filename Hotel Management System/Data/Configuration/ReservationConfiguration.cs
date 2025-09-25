using Hotel_Management_System.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System.Data.Configuration;
public class ReservationConfiguration : IEntityTypeConfiguration<Reservation>
{
    public void Configure(EntityTypeBuilder<Reservation> builder)
    {
        builder.HasKey(r => r.Id);
        

        builder.Property(r => r.CheckInDate) 
            .IsRequired();

        builder.Property(r => r.CheckOutDate)
            .IsRequired();

        builder.HasOne(reservation  => reservation.Room)
               .WithMany(room => room.Reservations)
               .HasForeignKey(reservation => reservation.RoomId);

        builder.HasOne(reservation => reservation.Guest)
            .WithMany(guest => guest.Reservations)
            .HasForeignKey(reservation => reservation.GuestId);

        builder.HasOne(reservation => reservation.Payment)
            .WithOne(reservation => reservation.Reservation)
            .HasForeignKey<Payment>(r => r.ReservationId);
        
    }
}

