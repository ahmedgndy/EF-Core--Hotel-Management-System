using Hotel_Management_System.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System.Data.Configuration;

internal class PaymentConfiguration : IEntityTypeConfiguration<Payment>
{
    public void Configure(EntityTypeBuilder<Payment> builder)
    {
       builder.HasKey(p => p.Id);

       builder.Property(p => p.Amount)
             .IsRequired()
             .HasColumnType("decimal(18,2)");

        builder.Property(p => p.PaymentDate)
              .IsRequired()
              .HasColumnType("Date");//check now 

        builder.HasOne(p => p.Reservation)
            .WithOne(reservation => reservation.Payment)
            .HasForeignKey<Payment>(p => p.ReservationId);


    }
}

