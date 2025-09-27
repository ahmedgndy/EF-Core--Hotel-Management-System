using Inheritance_Mapping.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Mapping.Data.Contexts;

public class GusetConfiguration : IEntityTypeConfiguration<Guest>
{
   


    public void Configure(EntityTypeBuilder<Guest> builder)
    {
        builder.Property(p => p.FullName)
            .IsRequired()
            .HasColumnType("varchar")
            .HasMaxLength(20);

        builder.Property(p => p.Phone)
            .IsRequired()
            .HasMaxLength(20);
    }
}
