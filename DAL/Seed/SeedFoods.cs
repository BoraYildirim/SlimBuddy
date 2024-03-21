using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models.Concrete;
using Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Seed
{
    internal class SeedFoods : IEntityTypeConfiguration<Food>
    {
        public void Configure(EntityTypeBuilder<Food> builder)
        {
            builder.HasData
               (
               new Food { FoodID = 1, Name = "Apple", Calorie = 52, Status = Status.Active, Unit = Unit.Quantity, Image = "\\FoodPhotos\\2.jpg" },
               
            new Food { FoodID = 2, Name = "Orange", Calorie = 47, Status = Status.Active, Unit = Unit.Quantity, Image = "\\FoodPhotos\\2.jpg" },
               
            new Food { FoodID = 3, Name = "Banana", Calorie = 131, Status = Status.Active, Unit = Unit.Quantity, Image = "\\FoodPhotos\\2.jpg" },
            new Food { FoodID = 4, Name = "Plum", Calorie = 46, Status = Status.Active, Unit = Unit.Quantity, Image = "\\FoodPhotos\\2.jpg" },
            new Food { FoodID = 5, Name = "Kiwi", Calorie = 61, Status = Status.Active, Unit = Unit.Quantity, Image = "\\FoodPhotos\\2.jpg" },
            new Food { FoodID = 6, Name = "Watermelon", Calorie = 30, Status = Status.Active, Unit = Unit.Quantity, Image = "\\FoodPhotos\\2.jpg" },
            new Food { FoodID = 7, Name = "Melon", Calorie = 34, Status = Status.Active, Unit = Unit.Quantity, Image = "\\FoodPhotos\\2.jpg" },
            new Food { FoodID = 8, Name = "Peach", Calorie = 59, Status = Status.Active, Unit = Unit.Quantity, Image = "\\FoodPhotos\\2.jpg" },
            new Food { FoodID = 9, Name = "Mango", Calorie = 60, Status = Status.Active, Unit = Unit.Quantity, Image = "\\FoodPhotos\\2.jpg" },
            new Food { FoodID = 10, Name = "Cherry", Calorie = 50, Status = Status.Active, Unit = Unit.Quantity, Image = "\\FoodPhotos\\2.jpg" },
            new Food { FoodID = 11, Name = "Strawberry", Calorie = 33, Status = Status.Active, Unit = Unit.Quantity, Image = "\\FoodPhotos\\2.jpg" }

               );

        }
    }
}
