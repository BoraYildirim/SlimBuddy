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
    public class Meal_CFG : IEntityTypeConfiguration<Meal>
    {
        public void Configure(EntityTypeBuilder<Meal> builder)
        {
            builder.Property(x => x.MealName).HasColumnType("nvarchar").HasMaxLength(50).IsRequired();
        }
    }
}
