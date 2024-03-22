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

    }
}
