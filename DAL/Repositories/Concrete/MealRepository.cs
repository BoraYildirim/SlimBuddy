using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Context;
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
            return _dbContext.Meals.Where(x => x.UserID == null || x.UserID == userID && x.Status != Status.Passive).Select(x => x.MealName).ToList();
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

        public double TotalCalorieOfDay(User user, DateTime date)
        {
            double totalCalorie = 0;
            foreach (Meal meal in GetAllMealsOfDay(date, user))
            {
                totalCalorie += GetMealCalorie(user, meal, date);
            }
            return totalCalorie;
        }
        public List<Meal> GetAllMealsOfDay(DateTime date, User user)
        {
            return _dbContext.Meals
                .Where(x => x.UserID == user.UserID && x.CreationDate.Date == date.Date && x.Status != Status.Passive)
                .Distinct()
                .ToList();
        }
        public double GetMealCalorie(User user, Meal meal, DateTime date)
        {
            double calorie = 0;
            foreach (Meal item in _dbContext.Meals.Where(x => x.UserID == user.UserID && x.CreationDate.Date == date.Date && x.MealID == meal.MealID && x.Status != Status.Passive).ToList())
            {
                //calorie += (item.NumberOfNutritions) * item.TotalCalorie;
                
            }
            return calorie;
        }
    }
}
