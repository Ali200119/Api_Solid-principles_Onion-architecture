using System;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.Configurations
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.Property(e => e.FullName).HasMaxLength(100).IsRequired();
            builder.Property(e => e.Address).HasMaxLength(250).IsRequired();
            builder.Property(e => e.Age).IsRequired();
        }
    }
}