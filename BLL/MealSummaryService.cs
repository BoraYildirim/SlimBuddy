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
    public class MealSummaryService
    {
        public MealSummaryService()
        {
            mealSummaryRepository = new MealSummaryRepository(new DAL.Context.SlimBuddyDBContext());
        }
        MealSummaryRepository mealSummaryRepository;

        public bool Add(MealSummary mealSummary)
        {
            mealSummary.CreationDate = DateTime.Now;
            mealSummary.Status = Status.Active;

            return mealSummaryRepository.Add(mealSummary);
        }

        public bool Update(MealSummary mealSummary)
        {
            mealSummary.Status = Status.Modified;
            mealSummary.ModifiedDate = DateTime.Now;
            return mealSummaryRepository.Update(mealSummary);
        }

        public bool Delete(int id)
        {
            MealSummary mealSummary = GetById(id);
            return mealSummaryRepository.Delete(mealSummary);
        }

        public MealSummary GetById(int id)
        {
            return mealSummaryRepository.Find(id);
        }

        public List<MealSummary> GetAll()
        {
            return mealSummaryRepository.GetAll();
        }
    }
}
