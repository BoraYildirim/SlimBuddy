using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Context;
using Models.Concrete;

namespace DAL.Repositories.Concrete
{
    public class MealRepository : Crud<Meal>
    {
        public MealRepository(SlimBuddyDBContext dbContext) : base(dbContext)
        {
        }
    }
}
