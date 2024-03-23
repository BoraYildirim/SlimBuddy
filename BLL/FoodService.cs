﻿using DAL.Repositories.Concrete;
using Models.Concrete;
using Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class FoodService
    {

        public FoodService()
        {
            foodRepository = new FoodRepository(new DAL.Context.SlimBuddyDBContext());
        }
        FoodRepository foodRepository;

        public bool Add(Food food)
        {
            food.CreationDate = DateTime.Now;
            food.Status = Status.Active;

            return foodRepository.Add(food);
        }


        public bool Update(Food food)
        {
            food.Status = Status.Modified;
            food.ModifiedDate = DateTime.Now;
            return foodRepository.Update(food);
        }

        public bool Delete(int id)
        {
            Food food = GetById(id);
            return foodRepository.Delete(food);
        }

        public Food GetById(int id)
        {
            return foodRepository.Find(id);
        }


        public List<Food> GetAll()
        {
            return foodRepository.GetAll();
        }
    }
}