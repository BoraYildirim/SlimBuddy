using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Seed
{
    public class SeedMeals : IEntityTypeConfiguration<Meal>
    {
        public void Configure(EntityTypeBuilder<Meal> builder)
        {
            builder.HasData
               (
                   new Meal { MealID = 1, MealName = "Breakfast" },
                   new Meal { MealID = 2, MealName = "Lunch" },
                   new Meal { MealID = 3, MealName = "Dinner" },
                   new Meal { MealID = 4, MealName = "Snack" }
               );
        }
    }
}
