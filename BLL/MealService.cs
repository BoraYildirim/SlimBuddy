using DAL.Repositories.Concrete;
using Models.Concrete;
using Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class MealService
    {

        public MealService()
        {
            mealRepository = new MealRepository(new DAL.Context.SlimBuddyDBContext());
        }
        MealRepository mealRepository;

        public bool Add(Meal meal)
        {
            meal.CreationDate = DateTime.Now;
            meal.Status = Status.Active;

            return mealRepository.Add(meal);
        }


        public bool Update(Meal meal)
        {
            meal.Status = Status.Modified;
            meal.ModifiedDate = DateTime.Now;
            return mealRepository.Update(meal);
        }

        public bool Delete(int id)
        {
            Meal meal = GetById(id);
            return mealRepository.Delete(meal);
        }

        public Meal GetById(int id)
        {
            return mealRepository.Find(id);
        }


        public List<Meal> GetAll()
        {
            return mealRepository.GetAll();
        }


    }
}
