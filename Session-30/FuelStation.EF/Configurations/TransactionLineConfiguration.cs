using FuelStation.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.EF.Configurations
{
    public class TransactionLineConfiguration : IEntityTypeConfiguration<TransactionLine>
    {
        public void Configure(EntityTypeBuilder<TransactionLine> builder)
        {
            builder.ToTable("TransactionLines");

            builder.HasKey(transactionLine => transactionLine.ID);

            builder.Property(transactionLine => transactionLine.TransactionID).IsRequired();
            builder.Property(transactionLine => transactionLine.ItemID).IsRequired();
            builder.Property(transactionLine => transactionLine.Quantity).IsRequired();
            builder.Property(transactionLine => transactionLine.ItemPrice).HasPrecision(9, 2).IsRequired();
            builder.Property(transactionLine => transactionLine.NetValue).HasPrecision(9, 2).IsRequired();
            builder.Property(transactionLine => transactionLine.DiscountPercent).HasPrecision(9, 2);
            builder.Property(transactionLine => transactionLine.DiscountValue).HasPrecision(9, 2);
            builder.Property(transactionLine => transactionLine.TotalValue).HasPrecision(9, 2).IsRequired();

            builder.HasOne(transactionLine => transactionLine.Transaction)
            .WithMany(transaction => transaction.TransactionLines)
            .HasForeignKey(transactionLine => transactionLine.TransactionID)
            .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(transactionLine => transactionLine.Item)
            .WithMany(item => item.TransactionLines)
            .HasForeignKey(transactionLine => transactionLine.ItemID)
            .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
