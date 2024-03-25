using DAL.Repositories.Concrete;
using Microsoft.EntityFrameworkCore;
using Models.Concrete;
using Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UserDetailService
    {


        public UserDetailService()
        {
            userDetailRepository = new UserDetailRepository(new DAL.Context.SlimBuddyDBContext());
        }
        UserDetailRepository userDetailRepository;

        public bool Add(UserDetail userDetail)
        {
            userDetail.CreationDate = DateTime.Now;
            userDetail.Status = Status.Active;

            return userDetailRepository.Add(userDetail);
        }


        public bool Update(UserDetail userDetail)
        {
            userDetail.Status = Status.Modified;
            userDetail.ModifiedDate = DateTime.Now;
            return userDetailRepository.Update(userDetail);
        }

        public bool Delete(int id)
        {
            UserDetail userDetail = GetById(id);
            return userDetailRepository.Delete(userDetail);
        }

        public UserDetail GetById(int id)
        {
            return userDetailRepository.Find(id);
        }


        public List<UserDetail> GetAll()
        {
            return userDetailRepository.GetAll();
        }

        public int GetUserAge(int userId)
        {
            return userDetailRepository.GetUserAge(userId);
        }

        public double GetUserHeight(int userId)
        {
            return userDetailRepository.GetUserHeight(userId);
        }

        public double GetUserWeight(int userId)
        {
            return userDetailRepository.GetUserWeight(userId);
        }

        public string GetUserName(int userId)
        {
           
            return userDetailRepository.GetUserName(userId);
        }

        public string GetUserSurname(int userId)
        {
            return userDetailRepository.GetUserSurname(userId);
        }

        public string GetUserGender(int userId)
        {
           return userDetailRepository.GetUserGender(userId);
        }
    }
}
