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
    public class FoodMeal_CFG : IEntityTypeConfiguration<FoodMeal>
    {
        public void Configure(EntityTypeBuilder<FoodMeal> builder)
        {
            
        }
    }
}
