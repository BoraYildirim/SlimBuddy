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
    public class SeedFoods : IEntityTypeConfiguration<Food>
    {
        public void Configure(EntityTypeBuilder<Food> builder)
        {
            builder.HasData
               (
            new Food { FoodID = 1, Name = "Apple", Calorie = 52, Status = Status.Active, Unit = Unit.Quantity, Image = "\\FoodPhotos\\2.jpg", CategoryID = 1 },
            new Food { FoodID = 2, Name = "Orange", Calorie = 47, Status = Status.Active, Unit = Unit.Quantity, Image = "\\FoodPhotos\\2.jpg", CategoryID = 1 },
            new Food { FoodID = 3, Name = "Banana", Calorie = 131, Status = Status.Active, Unit = Unit.Quantity, Image = "\\FoodPhotos\\2.jpg", CategoryID = 1 },
            new Food { FoodID = 4, Name = "Plum", Calorie = 46, Status = Status.Active, Unit = Unit.Quantity, Image = "\\FoodPhotos\\2.jpg", CategoryID = 1 },
            new Food { FoodID = 5, Name = "Kiwi", Calorie = 61, Status = Status.Active, Unit = Unit.Quantity, Image = "\\FoodPhotos\\2.jpg", CategoryID = 1 },
            new Food { FoodID = 6, Name = "Watermelon", Calorie = 30, Status = Status.Active, Unit = Unit.Quantity, Image = "\\FoodPhotos\\2.jpg", CategoryID = 1 },
            new Food { FoodID = 7, Name = "Melon", Calorie = 34, Status = Status.Active, Unit = Unit.Quantity, Image = "\\FoodPhotos\\2.jpg", CategoryID = 1 },
            new Food { FoodID = 8, Name = "Peach", Calorie = 59, Status = Status.Active, Unit = Unit.Quantity, Image = "\\FoodPhotos\\2.jpg", CategoryID = 1 },
            new Food { FoodID = 9, Name = "Mango", Calorie = 60, Status = Status.Active, Unit = Unit.Quantity, Image = "\\FoodPhotos\\2.jpg", CategoryID = 1 },
            new Food { FoodID = 10, Name = "Cherry", Calorie = 50, Status = Status.Active, Unit = Unit.Quantity, Image = "\\FoodPhotos\\2.jpg", CategoryID = 1 },


            new Food { FoodID = 11, Name = "Water", Calorie = 0, Status = Status.Active, Unit = Unit.milliliter, Image = "\\FoodPhotos\\2.jpg", CategoryID = 2 },
            new Food { FoodID = 12, Name = "Milkshake", Calorie = 113, Status = Status.Active, Unit = Unit.milliliter, Image = "\\FoodPhotos\\2.jpg", CategoryID = 2 },
            new Food { FoodID = 13, Name = "Cola", Calorie = 37, Status = Status.Active, Unit = Unit.milliliter, Image = "\\FoodPhotos\\2.jpg", CategoryID = 2 },
            new Food { FoodID = 14, Name = "Fanta", Calorie = 48, Status = Status.Active, Unit = Unit.milliliter, Image = "\\FoodPhotos\\2.jpg", CategoryID = 2},
            new Food { FoodID = 15, Name = "Hot Chocolate", Calorie = 89, Status = Status.Active, Unit = Unit.milliliter, Image = "\\FoodPhotos\\2.jpg", CategoryID = 2 },
            new Food { FoodID = 16, Name = "Soda", Calorie = 53, Status = Status.Active, Unit = Unit.milliliter, Image = "\\FoodPhotos\\2.jpg", CategoryID = 2 },
            new Food { FoodID = 17, Name = "Coffee", Calorie = 1, Status = Status.Active, Unit = Unit.milliliter, Image = "\\FoodPhotos\\2.jpg", CategoryID = 2 },
            new Food { FoodID = 18, Name = "Orange Juice", Calorie = 45, Status = Status.Active, Unit = Unit.milliliter, Image = "\\FoodPhotos\\2.jpg", CategoryID = 2 },
            new Food { FoodID = 19, Name = "Tea", Calorie = 2, Status = Status.Active, Unit = Unit.milliliter, Image = "\\FoodPhotos\\2.jpg", CategoryID = 2 },
            new Food { FoodID = 20, Name = "Lemonade", Calorie = 42, Status = Status.Active, Unit = Unit.milliliter, Image = "\\FoodPhotos\\2.jpg", CategoryID = 2 },


            new Food { FoodID = 21, Name = "Wafer", Calorie = 433, Status = Status.Active, Unit = Unit.Quantity, Image = "\\FoodPhotos\\2.jpg", CategoryID = 3 },
            new Food { FoodID = 22, Name = "Almond", Calorie = 11, Status = Status.Active, Unit = Unit.Quantity, Image = "\\FoodPhotos\\2.jpg", CategoryID = 3 },
            new Food { FoodID = 23, Name = "Peanut", Calorie = 6, Status = Status.Active, Unit = Unit.Quantity, Image = "\\FoodPhotos\\2.jpg", CategoryID = 3 },
            new Food { FoodID = 24, Name = "Snickers", Calorie = 488, Status = Status.Active, Unit = Unit.Quantity, Image = "\\FoodPhotos\\2.jpg", CategoryID = 3 },
            new Food { FoodID = 25, Name = "Popcorn", Calorie = 375, Status = Status.Active, Unit = Unit.Portion, Image = "\\FoodPhotos\\2.jpg", CategoryID = 3 },
            new Food { FoodID = 26, Name = "Chips", Calorie = 536, Status = Status.Active, Unit = Unit.Portion, Image = "\\FoodPhotos\\2.jpg", CategoryID = 3 },
            new Food { FoodID = 27, Name = "Cookies", Calorie = 502, Status = Status.Active, Unit = Unit.Portion, Image = "\\FoodPhotos\\2.jpg", CategoryID = 3 },
            new Food { FoodID = 28, Name = "Crackers", Calorie = 20, Status = Status.Active, Unit = Unit.Quantity, Image = "\\FoodPhotos\\2.jpg", CategoryID = 3 },
            new Food { FoodID = 29, Name = "Sunflower Seed", Calorie = 559, Status = Status.Active, Unit = Unit.Portion, Image = "\\FoodPhotos\\2.jpg", CategoryID = 3 },
            new Food { FoodID = 30, Name = "Marshmallow", Calorie = 318, Status = Status.Active, Unit = Unit.Portion, Image = "\\FoodPhotos\\2.jpg", CategoryID = 3 },


            new Food { FoodID = 31, Name = "Cheesecake", Calorie = 321, Status = Status.Active, Unit = Unit.Quantity, Image = "\\FoodPhotos\\2.jpg", CategoryID = 4 },
            new Food { FoodID = 32, Name = "Baklava", Calorie = 174, Status = Status.Active, Unit = Unit.Quantity, Image = "\\FoodPhotos\\2.jpg", CategoryID = 4 },
            new Food { FoodID = 33, Name = "Doughnut", Calorie = 438, Status = Status.Active, Unit = Unit.Quantity, Image = "\\FoodPhotos\\2.jpg", CategoryID = 4 },
            new Food { FoodID = 34, Name = "Creme brulee", Calorie = 321, Status = Status.Active, Unit = Unit.Portion, Image = "\\FoodPhotos\\2.jpg", CategoryID = 4 },
            new Food { FoodID = 35, Name = "Cookie", Calorie = 49, Status = Status.Active, Unit = Unit.Quantity, Image = "\\FoodPhotos\\2.jpg", CategoryID = 4 },
            new Food { FoodID = 36, Name = "Brownie", Calorie = 466, Status = Status.Active, Unit = Unit.Portion, Image = "\\FoodPhotos\\2.jpg", CategoryID = 4 },
            new Food { FoodID = 37, Name = "Ice cream", Calorie = 250, Status = Status.Active, Unit = Unit.Quantity, Image = "\\FoodPhotos\\2.jpg", CategoryID = 4 },
            new Food { FoodID = 38, Name = "Tiramisu", Calorie = 290, Status = Status.Active, Unit = Unit.Portion, Image = "\\FoodPhotos\\2.jpg", CategoryID = 4 },
            new Food { FoodID = 39, Name = "Pavlova", Calorie = 271, Status = Status.Active, Unit = Unit.Portion, Image = "\\FoodPhotos\\2.jpg", CategoryID = 4 },
            new Food { FoodID = 40, Name = "Pudding", Calorie = 120, Status = Status.Active, Unit = Unit.Portion, Image = "\\FoodPhotos\\2.jpg", CategoryID = 4 },


            new Food { FoodID = 41, Name = "Broccoli", Calorie = 33, Status = Status.Active, Unit = Unit.Portion, Image = "\\FoodPhotos\\2.jpg", CategoryID = 5 },
            new Food { FoodID = 42, Name = "Cucumber", Calorie = 15, Status = Status.Active, Unit = Unit.Portion, Image = "\\FoodPhotos\\2.jpg", CategoryID = 5 },
            new Food { FoodID = 43, Name = "Celery", Calorie = 42, Status = Status.Active, Unit = Unit.Portion, Image = "\\FoodPhotos\\2.jpg", CategoryID = 5 },
            new Food { FoodID = 44, Name = "Courgette", Calorie = 16, Status = Status.Active, Unit = Unit.Portion, Image = "\\FoodPhotos\\2.jpg", CategoryID = 5 },
            new Food { FoodID = 45, Name = "Eggplant", Calorie = 24, Status = Status.Active, Unit = Unit.Portion, Image = "\\FoodPhotos\\2.jpg", CategoryID = 5 },
            new Food { FoodID = 46, Name = "Tomatoes", Calorie = 19, Status = Status.Active, Unit = Unit.Portion, Image = "\\FoodPhotos\\2.jpg", CategoryID = 5 },
            new Food { FoodID = 47, Name = "Carrot", Calorie = 41, Status = Status.Active, Unit = Unit.Portion, Image = "\\FoodPhotos\\2.jpg", CategoryID = 5 },
            new Food { FoodID = 48, Name = "Pepper", Calorie = 39, Status = Status.Active, Unit = Unit.Portion, Image = "\\FoodPhotos\\2.jpg", CategoryID = 5 },
            new Food { FoodID = 49, Name = "Artichoke", Calorie = 47, Status = Status.Active, Unit = Unit.Portion, Image = "\\FoodPhotos\\2.jpg", CategoryID = 5 },
            new Food { FoodID = 50, Name = "Mushroom", Calorie = 22, Status = Status.Active, Unit = Unit.Portion, Image = "\\FoodPhotos\\2.jpg", CategoryID = 5 },


           new Food { FoodID = 51, Name = "Yogurt", Calorie = 59, Status = Status.Active, Unit = Unit.Portion, Image = "\\FoodPhotos\\2.jpg", CategoryID = 6 },
           new Food { FoodID = 52, Name = "Tzatziki", Calorie = 62, Status = Status.Active, Unit = Unit.Portion, Image = "\\FoodPhotos\\2.jpg", CategoryID = 6 },
           new Food { FoodID = 53, Name = "Ayran", Calorie = 50, Status = Status.Active, Unit = Unit.milliliter, Image = "\\FoodPhotos\\2.jpg", CategoryID = 6 },
           new Food { FoodID = 54, Name = "Cheddar cheese", Calorie = 402, Status = Status.Active, Unit = Unit.Portion, Image = "\\FoodPhotos\\2.jpg", CategoryID = 6 },
           new Food { FoodID = 55, Name = "Cottage cheese", Calorie = 98, Status = Status.Active, Unit = Unit.Portion, Image = "\\FoodPhotos\\2.jpg", CategoryID = 6 },
           new Food { FoodID = 56, Name = "Mozzarella cheese", Calorie = 280, Status = Status.Active, Unit = Unit.Portion, Image = "\\FoodPhotos\\2.jpg", CategoryID = 6 },
           new Food { FoodID = 57, Name = "Milk", Calorie = 42, Status = Status.Active, Unit = Unit.milliliter, Image = "\\FoodPhotos\\2.jpg", CategoryID = 6 },
           new Food { FoodID = 58, Name = "Goat milk", Calorie = 68, Status = Status.Active, Unit = Unit.milliliter, Image = "\\FoodPhotos\\2.jpg", CategoryID = 6 },
           new Food { FoodID = 59, Name = "Almond milk", Calorie = 32, Status = Status.Active, Unit = Unit.milliliter, Image = "\\FoodPhotos\\2.jpg", CategoryID = 6 },


           new Food { FoodID = 60, Name = "Soy milk", Calorie = 54, Status = Status.Active, Unit = Unit.milliliter, Image = "\\FoodPhotos\\2.jpg", CategoryID = 6 },
           new Food { FoodID = 61, Name = "Octopus", Calorie = 164, Status = Status.Active, Unit = Unit.Quantity, Image = "\\FoodPhotos\\2.jpg", CategoryID = 7 },
           new Food { FoodID = 62, Name = "Sea Bass", Calorie = 124, Status = Status.Active, Unit = Unit.Quantity, Image = "\\FoodPhotos\\2.jpg", CategoryID = 7 },
           new Food { FoodID = 63, Name = "Caviar", Calorie = 264, Status = Status.Active, Unit = Unit.Quantity, Image = "\\FoodPhotos\\2.jpg", CategoryID = 7 },
           new Food { FoodID = 64, Name = "Lobster", Calorie = 89, Status = Status.Active, Unit = Unit.Quantity, Image = "\\FoodPhotos\\2.jpg",  CategoryID = 7 },
           new Food { FoodID = 65, Name = "Calamary", Calorie = 175, Status = Status.Active, Unit = Unit.Quantity, Image = "\\FoodPhotos\\2.jpg", CategoryID = 7 },
           new Food { FoodID = 66, Name = "Blue Fish", Calorie = 159, Status = Status.Active, Unit = Unit.Quantity, Image = "\\FoodPhotos\\2.jpg", CategoryID = 7 },
           new Food { FoodID = 67, Name = "Whiting", Calorie = 90, Status = Status.Active, Unit = Unit.Quantity, Image = "\\FoodPhotos\\2.jpg", CategoryID = 7 },
           new Food { FoodID = 68, Name = "Salmon", Calorie = 206, Status = Status.Active, Unit = Unit.Quantity, Image = "\\FoodPhotos\\2.jpg", CategoryID = 7 },
           new Food { FoodID = 69, Name = "Sushi", Calorie = 150, Status = Status.Active, Unit = Unit.Quantity, Image = "\\FoodPhotos\\2.jpg", CategoryID = 7 },
           new Food { FoodID = 70, Name = "Mackerel", Calorie = 262, Status = Status.Active, Unit = Unit.Quantity, Image = "\\FoodPhotos\\2.jpg", CategoryID = 7 },


            new Food { FoodID = 71, Name = "Burger", Calorie = 295, Status = Status.Active, Unit = Unit.Portion, Image = "\\FoodPhotos\\2.jpg", CategoryID = 8 },
            new Food { FoodID = 72, Name = "Pizza", Calorie = 266, Status = Status.Active, Unit = Unit.Portion, Image = "\\FoodPhotos\\2.jpg", CategoryID = 8 },
            new Food { FoodID = 73, Name = "Doner", Calorie = 239, Status = Status.Active, Unit = Unit.Portion, Image = "\\FoodPhotos\\2.jpg", CategoryID = 8 },
            new Food { FoodID = 74, Name = "French fries", Calorie = 312, Status = Status.Active, Unit = Unit.Portion, Image = "\\FoodPhotos\\2.jpg", CategoryID = 8 },
            new Food { FoodID = 75, Name = "Mac and cheese", Calorie = 164, Status = Status.Active, Unit = Unit.Portion, Image = "\\FoodPhotos\\2.jpg", CategoryID = 8 },
            new Food { FoodID = 76, Name = "Lahmacun", Calorie = 118, Status = Status.Active, Unit = Unit.Portion, Image = "\\FoodPhotos\\2.jpg", CategoryID = 8 },
            new Food { FoodID = 77, Name = "Tantuni", Calorie = 390, Status = Status.Active, Unit = Unit.Portion, Image = "\\FoodPhotos\\2.jpg", CategoryID = 8 },
            new Food { FoodID = 78, Name = "Sandwich", Calorie = 284, Status = Status.Active, Unit = Unit.Portion, Image = "\\FoodPhotos\\2.jpg", CategoryID = 8 },
            new Food { FoodID = 79, Name = "Onion rings", Calorie = 411, Status = Status.Active, Unit = Unit.Portion, Image = "\\FoodPhotos\\2.jpg", CategoryID = 8 },
            new Food { FoodID = 80, Name = "Chicken wing", Calorie = 203, Status = Status.Active, Unit = Unit.Portion, Image = "\\FoodPhotos\\2.jpg", CategoryID = 8 },


            new Food { FoodID = 81, Name = "Adana Kebab", Calorie = 360, Status = Status.Active, Unit = Unit.Portion, Image = "\\FoodPhotos\\2.jpg", CategoryID = 9 },
            new Food { FoodID = 82, Name = "Meatball", Calorie = 235, Status = Status.Active, Unit = Unit.Portion, Image = "\\FoodPhotos\\2.jpg", CategoryID = 9 },
            new Food { FoodID = 83, Name = "Salami", Calorie = 336, Status = Status.Active, Unit = Unit.Portion, Image = "\\FoodPhotos\\2.jpg", CategoryID = 9 },
            new Food { FoodID = 84, Name = "Sausage", Calorie = 300, Status = Status.Active, Unit = Unit.Portion, Image = "\\FoodPhotos\\2.jpg", CategoryID = 9 },
            new Food { FoodID = 85, Name = "Beef Stew", Calorie = 186, Status = Status.Active, Unit = Unit.Portion, Image = "\\FoodPhotos\\2.jpg", CategoryID = 9 },
            new Food { FoodID = 86, Name = "Chicken Marsal", Calorie = 290, Status = Status.Active, Unit = Unit.Portion, Image = "\\FoodPhotos\\2.jpg", CategoryID = 9 },
            new Food { FoodID = 87, Name = "Chicken Tikka Masala", Calorie = 350, Status = Status.Active, Unit = Unit.Portion, Image = "\\FoodPhotos\\2.jpg", CategoryID = 9 },
            new Food { FoodID = 88, Name = "Chimichanga", Calorie = 308, Status = Status.Active, Unit = Unit.Portion, Image = "\\FoodPhotos\\2.jpg", CategoryID = 9 },
            new Food { FoodID = 89, Name = "Fajita", Calorie = 290, Status = Status.Active, Unit = Unit.Portion, Image = "\\FoodPhotos\\2.jpg", CategoryID = 9 },
            new Food { FoodID = 90, Name = "Steak", Calorie = 220, Status = Status.Active, Unit = Unit.Portion, Image = "\\FoodPhotos\\2.jpg", CategoryID = 9 },
            new Food { FoodID = 91, Name = "Bread", Calorie = 264, Status = Status.Active, Unit = Unit.Quantity, Image = "\\FoodPhotos\\2.jpg", CategoryID = 10},
            new Food { FoodID = 92, Name = "Egg", Calorie = 220, Status = Status.Active, Unit = Unit.Portion, Image = "\\FoodPhotos\\2.jpg", CategoryID = 10 }


           );

        }
    }
}

