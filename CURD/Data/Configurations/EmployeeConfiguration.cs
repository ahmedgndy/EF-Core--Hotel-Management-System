using CURD.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURD.Data.Configurations;

internal class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
{
    public void Configure(EntityTypeBuilder<Employee> builder)
    {
        builder.HasKey(emp => emp.Id);

        builder.Property(emp => emp.Id)
            .UseIdentityColumn(seed: 10 , increment: 10);

        builder.Property(emp => emp.Name)
            .IsRequired()
            .HasColumnType("varchar")
            .HasMaxLength(20);

        builder.Property(emp => emp.Age)
            .IsRequired();
            
        builder.Property(emp => emp.Address)
            .IsRequired()
            .HasColumnType("varchar")
            .HasMaxLength(20);

        builder.Property(emp => emp.Salary)
            .IsRequired()
            .HasColumnType("decimal(18,2)");
           
       


    }
}
