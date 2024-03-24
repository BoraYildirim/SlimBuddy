using Models.Abstracts;
using Models.Enums;
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
        public Unit Unit { get; set; }

        public Category? Category { get; set; }
        public int CategoryID { get; set; }


        public ICollection<MealSummary>? MealSummary { get; set; }


        public override string ToString()
        {
            return Name+" => "+Calorie.ToString()+" Calorie"+" => "+Unit.ToString()+" x1";
        }
    }



}
