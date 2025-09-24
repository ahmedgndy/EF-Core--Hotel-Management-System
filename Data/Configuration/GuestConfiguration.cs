using Hotel_Management_System.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System.Data.Configuration;
internal class GuestConfiguration : IEntityTypeConfiguration<Guest>
{
    public void Configure(EntityTypeBuilder<Guest> builder)
    {
        builder.HasKey(p => p.GuestId);

        builder.Property(p => p.GuestId)
            .ValueGeneratedOnAdd();

        builder.Property(p => p.FullName)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(p => p.Phone)
            .IsRequired()
            .HasColumnType("varChar(20)")
            .HasMaxLength(20);

        builder.Property(p => p.Email)
            .HasMaxLength(40);

        builder.HasMany(p => p.Reservations)
               .WithOne(reservation => reservation.Guest)
               .HasForeignKey(reservation => reservation.Guestid);
            
    }
}

