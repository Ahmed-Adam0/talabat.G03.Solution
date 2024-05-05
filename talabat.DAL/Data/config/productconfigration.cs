using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using talabat.DAL.Entities;

namespace talabat.DAL.Data.config
{
    public class productconfigration : IEntityTypeConfiguration<product>
    {
        public void Configure(EntityTypeBuilder<product> builder)
        {
            builder.Property(p=>p.Name).IsRequired().HasMaxLength(100);
            builder.Property(p=>p.Description).IsRequired();
            builder.Property(p => p.price).HasColumnType("decimal(18,2)");
            builder.Property(p => p.pictureurl).IsRequired();
            //builder.HasOne(p => p.productBrand).WithMany()
            //    .HasForeignKey(p => p.productBrandId);
            //builder.HasOne(p => p.producttype).WithMany()
            //    .HasForeignKey(p => p.producttypeid);
        }
    }
}
