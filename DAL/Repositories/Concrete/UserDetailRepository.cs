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

        public string GetUserName(int userId) 
        { 
            var userName = _dbContext.UserDetails
                .Where(x=>x.User.UserID==userId)    
                .Select(x=>x.Name)
                .FirstOrDefault();
            return userName;
        }

        public string GetUserSurname(int userId)
        {
            var userSurname = _dbContext.UserDetails
                .Where(x => x.User.UserID == userId)
                .Select(x => x.Surname)
                .FirstOrDefault();
            return userSurname;
        }

        public string GetUserGender(int userId)
        {
            var userGender = _dbContext.UserDetails
                .Where(x => x.User.UserID == userId)
                .Select(x => x.Gender.ToString())
                .FirstOrDefault();
            return userGender;
        }
    }
}
