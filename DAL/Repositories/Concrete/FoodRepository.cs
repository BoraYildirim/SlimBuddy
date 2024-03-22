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
    public class FoodRepository : Crud<Food>
    {
        public FoodRepository(SlimBuddyDBContext dbContext) : base(dbContext)
        {
            _dbContext = new SlimBuddyDBContext();
        }
        SlimBuddyDBContext _dbContext;

        public bool CheckEntries(string foodName)
        {
            var fdName = _dbContext.Foods.FirstOrDefault(x => x.Name == foodName);
            if (fdName == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public List<Food> GetFoodByCategoryName(string categoryName, int userID)
        {
            return _dbContext.Foods.Include(x => x.Category).AsNoTracking().Where(x => x.Category.CategoryName == categoryName && x.Status != Status.Passive && (x.UserID == null || x.UserID == userID)).ToList();
        }
        public List<Food> GetAllFoods(int userID)
        {
            return _dbContext.Foods.Include(x => x.Category).AsNoTracking().Where(x => x.UserID == null || x.UserID == userID).ToList();
        }
        public Food GetFoodByID(int id)
        {
            return _dbContext.Foods.Where(x => x.FoodID == id).ToList().FirstOrDefault();
        }
        public List<Food> GetSearchedFood(int userID, string foodName)
        {
            return _dbContext.Foods.AsNoTracking().Where(x => x.Name.Contains(foodName) && x.Status != Status.Passive && (x.UserID == null || x.UserID == userID)).ToList();
        }
    }
}
