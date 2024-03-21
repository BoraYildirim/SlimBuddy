using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Abstracts;

namespace DAL.Repositories.Abstract
{
    public interface ICrud<T> where T : BaseEntity
    {
        T Find(int id); 
        bool Update(T entity); 
        bool Delete(T entity); 
        bool Add(T entity); 
        List<T> GetAll();
    }
}
