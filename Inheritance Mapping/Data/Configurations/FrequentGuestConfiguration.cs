using Inheritance_Mapping.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Mapping.Data.Contexts;

public class FrequentGuestConfiguration : IEntityTypeConfiguration<FrequentGuest>
{



    public void Configure(EntityTypeBuilder<FrequentGuest> builder)
    {
        builder.Property(p => p.FullName)
            .HasColumnType("varchar(50)")
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(p => p.Phone)
            .IsRequired()
            .HasMaxLength(20);

        builder.Property(p => p.Email)
            .HasColumnType("varchar(100)")
            .HasMaxLength(100);

    }
}
