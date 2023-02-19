using FuelStation.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.EF.Configurations
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {

        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employees");

            //Primary Key
            builder.HasKey(employee => employee.ID);

            builder.Property(employee => employee.Name).HasMaxLength(40).IsRequired();
            builder.Property(employee => employee.Surname).HasMaxLength(40).IsRequired();
            builder.Property(employee => employee.HireDateStart).IsRequired();
            builder.Property(employee => employee.HireDateEnd);
            builder.Property(employee => employee.SallaryPerMonth).HasPrecision(7, 2).IsRequired();
            builder.Property(employee => employee.EmployeeType).HasMaxLength(20).IsRequired();

        }
    }


}



