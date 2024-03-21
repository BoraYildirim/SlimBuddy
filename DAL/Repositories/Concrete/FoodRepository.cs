﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Context;
using Models.Concrete;

namespace DAL.Repositories.Concrete
{
    public class FoodRepository : Crud<Food>
    {
        public FoodRepository(SlimBuddyDBContext dbContext) : base(dbContext)
        {
        }
    }
}