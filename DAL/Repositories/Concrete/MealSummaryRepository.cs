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
    public class MealSummaryRepository : Crud<MealSummary>
    {
        public MealSummaryRepository(SlimBuddyDBContext dbContext) : base(dbContext)
        {
            _dbContext = new SlimBuddyDBContext();
        }
        SlimBuddyDBContext _dbContext;

        public List<object> GetUserMeals(int userId)
        {
            var userMeals = _dbContext.MealSummaries
                .Where(ms => ms.UserID == userId)
                .Select(ms => new
                {
                    MealName = ms.Meal.MealName,
                    Foods = ms.Food.Name
                })
                .ToList<object>();

            return userMeals;
        }
    }
}

