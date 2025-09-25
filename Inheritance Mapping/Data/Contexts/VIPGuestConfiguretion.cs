using Inheritance_Mapping.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Mapping.Data.Contexts
{
    internal class VIPGuestConfiguretion : IEntityTypeConfiguration<VIPGuest>
    {
        public void Configure(EntityTypeBuilder<VIPGuest> builder)
        {
            builder.Property(p => p.VipCardNumber)
                .HasColumnType("varchar(50)");
           
            builder.HasIndex(p => p.VipCardNumber)
           .IsUnique();

        }
    }
}
