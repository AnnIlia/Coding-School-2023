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
    public class ItemConfiguration : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder.ToTable("Items");

            builder.HasKey(item => item.Id);
            builder.Property(t => t.Id).ValueGeneratedOnAdd();

            builder.Property(item => item.Code).HasMaxLength(6);
            builder.Property(item => item.Description).HasMaxLength(40);
            builder.Property(item => item.ItemType).HasMaxLength(20).IsRequired();
            builder.Property(item => item.Price).HasPrecision(6, 2);
            builder.Property(item => item.Cost).HasPrecision(6, 2);
            builder.HasIndex(item => item.Code).IsUnique();

        }
    }
}

