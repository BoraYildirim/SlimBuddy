using DAL.Repositories.Concrete;
using Models.Concrete;
using Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CategoryService
    {

        public CategoryService()
        {
            categoryRepository = new CategoryRepository(new DAL.Context.SlimBuddyDBContext());
        }
        CategoryRepository categoryRepository;

        public bool Add(Category category)
        {
            category.CreationDate = DateTime.Now;
            category.Status = Status.Active;

            return categoryRepository.Add(category);
        }

        public bool Update(Category category)
        {
            category.Status = Status.Modified;
            category.ModifiedDate = DateTime.Now;
            return categoryRepository.Update(category);
        }

        public bool Delete(int id)
        {
            Category category = GetById(id);
            return categoryRepository.Delete(category);
        }

        public Category GetById(int id)
        {
            return categoryRepository.Find(id);
        }

        public List<Category> GetAll()
        {
            return categoryRepository.GetAll();
        }
    }
}
