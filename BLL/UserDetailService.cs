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
    }
}
