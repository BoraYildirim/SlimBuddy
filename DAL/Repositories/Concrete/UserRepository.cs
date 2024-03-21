using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Context;
using Models.Concrete;

namespace DAL.Repositories.Concrete
{
    public class UserRepository : Crud<User>
    {
        public UserRepository(SlimBuddyDBContext dbContext) : base(dbContext)
        {
        }
    }
}
