using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShop.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoffeeShop.Orm.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");
            builder.HasKey(prod => prod.ID);
            builder.Property(prod => prod.Code)
                    .HasMaxLength(50);
            builder.Property(prod => prod.Description)
                    .HasMaxLength(50);
            builder.Property(prod => prod.ProductCategoryID);
            builder.Property(prod => prod.TypeOfProduct);
            builder.Property(prod => prod.Price)
                    .HasPrecision(22, 2);
            builder.Property(prod => prod.Cost)
                    .HasPrecision(22, 2);
            //builder.HasOne(prod => prod.ProductCategory)
            //          .WithOne(prodCat => prodCat.Product)
            //          .HasForeignKey<Product>(prod => prod.ID);
            
        }
    }
}