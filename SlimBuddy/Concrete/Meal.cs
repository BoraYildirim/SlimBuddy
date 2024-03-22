using Models.Abstracts;
using Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Concrete
{
    public class Meal:BaseEntity
    {
        public int MealID { get; set; }
        public string MealName { get; set; }
        public double TotalCalorie { get; set; }
      
     

        public ICollection<MealSummary>? MealSummary { get; set; }

    }
}
