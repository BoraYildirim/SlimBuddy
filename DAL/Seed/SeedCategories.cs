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
    internal class SeedCategories : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData
                (
                  
                    new Category { CategoryID = 1, CategoryName = "Fruit" },
                    new Category { CategoryID = 2, CategoryName = "Drink" },
                    new Category { CategoryID = 3, CategoryName = "Snack" },
                    new Category { CategoryID = 4, CategoryName = "Dessert" },
                    new Category { CategoryID = 5, CategoryName = "Salad" },
                    new Category { CategoryID = 6, CategoryName = "Dairy" },
                    new Category { CategoryID = 7, CategoryName = "Fish and Seafood" },
                    new Category { CategoryID = 8, CategoryName = "Fast Food" },
                    new Category { CategoryID = 9, CategoryName = "Meat or Poultry" },
                    new Category { CategoryID = 10, CategoryName = "Grain, Bean and Nuts" },
                    new Category { CategoryID = 11, CategoryName = "Others" }
                );
        }
    }
}
