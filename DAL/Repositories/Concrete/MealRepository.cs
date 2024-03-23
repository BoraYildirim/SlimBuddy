using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Context;
using Microsoft.EntityFrameworkCore;
using Models.Concrete;
using Models.Enums;

namespace DAL.Repositories.Concrete
{
    public class MealRepository : Crud<Meal>
    {
        public MealRepository(SlimBuddyDBContext dbContext) : base(dbContext)
        {
            _dbContext = new SlimBuddyDBContext();
        }
        SlimBuddyDBContext _dbContext;



        public List<string> GetMealsNames(int userID)
        {
            return _dbContext.MealSummaries
                             .Include(ms => ms.Meal)
                             .AsNoTracking()
                             .Where(ms => (ms.UserID == null || ms.UserID == userID) && ms.Status != Status.Passive)
                             .Select(ms => ms.Meal.MealName)
                             .ToList();
        }

        public int GetMealID(string text)
        {
            return _dbContext.Meals.Where(x => x.MealName == text).Select(x => x.MealID).FirstOrDefault();
        }
        public bool CheckEntries(string mealName)
        {
            var mlName = _dbContext.Meals.FirstOrDefault(x => x.MealName == mealName);
            if (mlName == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

       
        
    }
}
