using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Concrete
{
    public class FoodMeal
    {
        public int FoodMealID { get; set; }
        public Food? Food { get; set; }
        public int FoodID { get; set; }
        public Meal? Meal { get; set; }
        public int MealID { get; set; }
    }
}
