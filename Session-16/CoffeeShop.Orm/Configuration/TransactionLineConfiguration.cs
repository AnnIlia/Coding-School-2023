//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using CoffeeShop.Model;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;

//namespace CoffeeShop.Orm.Configuration
//{
//    public class TransactionLineConfiguration : IEntityTypeConfiguration<TransactionLine>
//    {
//        public void Configure(EntityTypeBuilder<TransactionLine> builder)
//        {
//            builder.ToTable("Transaction Lines");
//            builder.HasKey(transln => transln.ID);
//            builder.Property(transln => transln.ProductID);
//            builder.Property(transln => transln.Date);
//            builder.Property(transln => transln.Description);
//            builder.Property(transln => transln.Quantity);
//            builder.Property(transln => transln.Price)
//                    .HasPrecision(22, 2);
//            builder.Property(transln => transln.TotalCost)
//                    .HasPrecision(22, 2);
//            builder.Property(transln => transln.TotalPrice)
//                    .HasPrecision(22, 2);
//        }
//    }
//}