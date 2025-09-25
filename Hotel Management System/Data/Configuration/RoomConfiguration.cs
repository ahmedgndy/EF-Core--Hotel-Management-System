using Hotel_Management_System.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System.Data.Configuration;
public class RoomConfiguration : IEntityTypeConfiguration<Room>
{
    public void Configure(EntityTypeBuilder<Room> builder)
    {
       builder.HasKey(p => p.RoomId);

        builder.Property(p => p.RoomNumber)
            .IsRequired()
            .HasMaxLength(10);

        builder.HasAlternateKey(p => p.RoomNumber); // make the key unique

        builder.Property(p => p.IsAvailable)
            .IsRequired().HasColumnType("BIT");

        builder.Property(p => p.PricePerNight)
            .IsRequired()
            .HasColumnType("decimal(18,2)");

        builder.Property(p => p.RoomType)
            .IsRequired();


        builder
            .HasMany(room => room.Reservations)
            .WithOne(reservation => reservation.Room)
            .HasForeignKey(reservation => reservation.RoomId);
    }
}

