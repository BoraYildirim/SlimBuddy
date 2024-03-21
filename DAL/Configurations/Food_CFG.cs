using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models.Concrete;

namespace DAL.Configurations
{
    public class Food_CFG : IEntityTypeConfiguration<Food>
    {
        public void Configure(EntityTypeBuilder<Food> builder)
        {
            builder.Property(x => x.Name).HasColumnType("nvarchar").HasMaxLength(30).IsRequired();
            builder.Property(x => x.Calorie).IsRequired();
            builder.Property(x => x.Image).HasColumnType("nvarchar").HasMaxLength(50).IsRequired();
        }
    }
}
