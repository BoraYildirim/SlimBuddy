using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Context;
using Models.Concrete;

namespace DAL.Repositories.Concrete
{
    public class CategoryRepository : Crud<Category>
    {    
        public CategoryRepository(SlimBuddyDBContext dbContext) : base(dbContext)
        {
            _dbContext = new SlimBuddyDBContext();

        }

        SlimBuddyDBContext _dbContext;
        public List<Category> GetAllCategories()
        {
            return _dbContext.Categories.ToList();
        }

        public Category GetCategoryById(int id)
        {
            return _dbContext.Categories.Where(x => x.CategoryID == id).ToList().FirstOrDefault();
        }
    }
}
