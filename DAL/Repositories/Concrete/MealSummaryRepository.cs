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
    public class MealSummaryRepository : Crud<MealSummary>
    {
        public MealSummaryRepository(SlimBuddyDBContext dbContext) : base(dbContext)
        {      
        }    
    }
}
