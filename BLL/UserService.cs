using DAL.Repositories.Concrete;
using Microsoft.EntityFrameworkCore;
using Models.Concrete;
using Models.Concrete.Template;
using Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UserService
    {


        public UserService()
        {
            userRepository = new UserRepository(new DAL.Context.SlimBuddyDBContext());
        }
        UserRepository userRepository;

        public bool Add(User user)
        {
            user.CreationDate = DateTime.Now;
            user.Status = Status.Active;

            return userRepository.Add(user);
        }

        public bool Update(User user)
        {
            user.ModifiedDate = DateTime.Now;
            return userRepository.Update(user);
        }

        public bool Delete(int id)
        {
            User user = GetById(id);
            return userRepository.Delete(user);
        }

        public User GetById(int id)
        {
            return userRepository.Find(id);
        }

        public List<User> GetAll()
        {
            return userRepository.GetAll();
        }

        public bool RegisterControl(string email)
        {
            return userRepository.RegisterControl(email);
        }

        public bool CheckEntries(string email)
        {
            return userRepository.CheckEntries(email);          
        }

        public IEnumerable<object> MealOfAllDaily(List<User> users, List<MealSummary> mealSummaries, List<Meal> meals)
        {            
            return userRepository.MealOfAllDaily(users, mealSummaries, meals);
        }

        public IEnumerable<object> MealOfAllWeekly(List<User> users, List<MealSummary> mealSummaries, List<Meal> meals)
        {
            return userRepository.MealOfAllWeekly(users, mealSummaries, meals);
        }

        public IEnumerable<object> MealOfAllDailyThisUser(User user, List<MealSummary> mealSummaries, List<Meal> meals)
        {
            return userRepository.MealOfAllDailyThisUser(user, mealSummaries, meals);
        }

        public IEnumerable<object> MealOfAllWeeklyThisUser(User user, List<MealSummary> mealSummaries, List<Meal> meals)
        {
            return userRepository.MealOfAllWeeklyThisUser(user, mealSummaries, meals);
        }
        public IEnumerable<object> GetFoodAndCalories(List<User> users, List<MealSummary> mealSummaries, List<Meal> meals, List<Food> foods)
        {
            return userRepository.GetFoodAndCalories(users, mealSummaries, meals, foods);
        }
    }
}
