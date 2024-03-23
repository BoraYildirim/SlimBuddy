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
    public class UserService
    {


        public UserService()
        {
            userRepository = new UserRepository(new DAL.Context.SlimBuddyDBContext());
        }
        UserRepository userRepository;

        public bool Add(User user)
        {
            user.CreationDate = DateTime.Now;
            user.Status = Status.Active;

            return userRepository.Add(user);
        }


        public bool Update(User user)
        {
            user.Status = Status.Modified;
            user.ModifiedDate = DateTime.Now;
            return userRepository.Update(user);
        }

        public bool Delete(int id)
        {
            User user = GetById(id);
            return userRepository.Delete(user);
        }

        public User GetById(int id)
        {
            return userRepository.Find(id);
        }


        public List<User> GetAll()
        {
            return userRepository.GetAll();
        }

        public bool RegisterControl(string email)
        {
            return userRepository.RegisterControl(email);
        }
    }
}
