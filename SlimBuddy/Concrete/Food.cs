using Models.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Concrete
{
    public class Food:BaseEntity
    {
        public int FoodID { get; set; }
        public string Name { get; set; }

        public double Calorie { get; set; }

        public string Image { get; set; }

        public Category? Category { get; set; }
        public int CategoryID { get; set; }

        public ICollection<FoodMeal>? FoodMeals { get; set; }
    }
}
