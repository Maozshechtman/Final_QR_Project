using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using BE;
namespace DAL
{
    public class ProductConfigurations: EntityTypeConfiguration<Product>
    {
     public ProductConfigurations()
         {
            this.Property(p=>p.Name)
                .IsRequired()
                .HasMaxLength(40);
        }
    }
}
