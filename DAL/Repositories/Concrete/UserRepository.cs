using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Context;
using Microsoft.EntityFrameworkCore;
using Models.Concrete;
using Models.Concrete.Template;
using Models.Enums;

namespace DAL.Repositories.Concrete
{
    public class UserRepository : Crud<User>
    {
        public UserRepository(SlimBuddyDBContext dbContext) : base(dbContext)
        {
            _dbContext = new SlimBuddyDBContext();
        }
        SlimBuddyDBContext _dbContext;


        public User Control(string email, string password)
        {
            return _dbContext.Users.Include(x => x.UserDetail).AsNoTracking().FirstOrDefault(x => x.Email == email && x.Password == password);
        }
        public User UserByUserId(int userId)
        {
            return _dbContext.Users.FirstOrDefault(x => x.UserID == userId);
        }
        public bool RegisterControl(string email)
        {
            return _dbContext.Users.AsNoTracking().Any(x => x.Email == email);
        }
        public List<User> GetUsers()
        {
            return _dbContext.Users.Where(x => x.Status == Status.Active).ToList();
        }

        public IEnumerable<object> MealOfAllDaily(List<User> users, List<MealSummary> mealSummaries, List<Meal> meals)
        {
            var result = users
    .Join(mealSummaries, user => user.UserID, ms => ms.UserID, (user, ms) => new { user, ms })
    .Join(meals.Where(meal => meal.CreationDate.Day == DateTime.Now.Day), x => x.ms.MealID, meal => meal.MealID, (x, meal) =>
        new MealsAllTemplate
        {
            Email = x.user.Email,
            MealName = meal.MealName,
            TotalCalorie = meal.TotalCalorie
        }
    );
            return result.Cast<object>();
        }


        public IEnumerable<object> MealOfAllWeekly(List<User> users, List<MealSummary> mealSummaries, List<Meal> meals)
        {
            var result = users
    .Join(mealSummaries, user => user.UserID, ms => ms.UserID, (user, ms) => new { user, ms })
    .Join(meals.Where(meal => meal.CreationDate.Month == DateTime.Now.Month), x => x.ms.MealID, meal => meal.MealID, (x, meal) =>
        new MealsAllTemplate
        {
            Email = x.user.Email,
            MealName = meal.MealName,
            TotalCalorie = meal.TotalCalorie
        }
    );
            return result.Cast<object>();
        }

        public IEnumerable<object> MealOfAllWeeklyThisUser(User user, List<MealSummary> mealSummaries, List<Meal> meals)
        {
            var result = mealSummaries
                .Where(ms => ms.UserID == user.UserID)
                .Join(meals.Where(meal => meal.CreationDate.Month == DateTime.Now.Month),
                      ms => ms.MealID,
                      meal => meal.MealID,
                      (ms, meal) =>
                    new MealsAllTemplate
                    {
                        Email = user.Email,
                        MealName = meal.MealName,
                        TotalCalorie = meal.TotalCalorie
                    }
                );

            return result.Cast<object>();
        }

        public IEnumerable<object> MealOfAllDailyThisUser(User user, List<MealSummary> mealSummaries, List<Meal> meals)
        {
            var result = mealSummaries
                .Where(ms => ms.UserID == user.UserID)
                .Join(meals.Where(meal => meal.CreationDate.Day == DateTime.Now.Day),
                      ms => ms.MealID,
                      meal => meal.MealID,
                      (ms, meal) =>
                    new MealsAllTemplate
                    {
                        Email = user.Email,
                        MealName = meal.MealName,
                        TotalCalorie = meal.TotalCalorie
                    }
                );

            return result.Cast<object>();
        }

        public IEnumerable<object> GetFoodAndCalories(List<User> users, List<MealSummary> mealSummaries, List<Meal> meals, List<Food> foods)
        {
            var result = from u in users
                         join ms in mealSummaries on u.UserID equals ms.UserID
                         join mm in meals on ms.MealID equals mm.MealID
                         join f in foods on ms.FoodID equals f.FoodID
                         select new FoodCalorieTemplate
                         {
                             Name = f.Name,
                             Calorie = f.Calorie
                         };

            return result.Cast<object>();
        }


    }
}
