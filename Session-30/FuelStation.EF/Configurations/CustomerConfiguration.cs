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
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer>builder) 
        {

            builder.ToTable("Customer");

            builder.HasKey(customer => customer.Id);
            
            builder.HasIndex(customer => customer.CardNumber).IsUnique();

            builder.Property(customer => customer.Name).HasMaxLength(40).IsRequired();
            builder.Property(customer => customer.Surname).HasMaxLength(400).IsRequired();
            builder.Property(customer => customer.CardNumber).HasMaxLength(20).IsRequired();
        }
    }
}


