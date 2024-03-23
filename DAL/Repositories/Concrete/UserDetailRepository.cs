using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Context;
using Microsoft.EntityFrameworkCore;
using Models.Concrete;

namespace DAL.Repositories.Concrete
{
    public class UserDetailRepository : Crud<UserDetail>
    {
        public UserDetailRepository(SlimBuddyDBContext dbContext) : base(dbContext)
        {
            _dbContext = new SlimBuddyDBContext();

        }
        SlimBuddyDBContext _dbContext;
        public int GetUserAge(int userId)
        {
            var userDetail = _dbContext.UserDetails
                .Where(ud => ud.User.UserID == userId) // Kullanıcıya ait UserDetail kaydını bul
                .Select(ud => ud.Age)
                .FirstOrDefault();

            return userDetail;
        }

        public double GetUserHeight(int userId)
        {
            var userDetail = _dbContext.UserDetails
                .Where(ud => ud.User.UserID == userId) // Kullanıcıya ait UserDetail kaydını bul
                .Select(ud => ud.Height)
                .FirstOrDefault();

            return userDetail;
        }

        public double GetUserWeight(int userId)
        {
            var userDetail = _dbContext.UserDetails
                .Where(ud => ud.User.UserID == userId) // Kullanıcıya ait UserDetail kaydını bul
                .Select(ud => ud.Weight)
                .FirstOrDefault();

            return userDetail;
        }
    }
}
