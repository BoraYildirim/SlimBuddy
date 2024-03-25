using Models.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Concrete
{
    public class MealSummary:BaseEntity
    {
        public int MealSummaryID { get; set; }

        public Meal? Meal { get; set; }
        public int MealID { get; set; }
        public User? User { get; set; }
        public int UserID { get; set; }
        public Food? Food { get; set; }
        public int FoodID { get; set; }


    }
}
