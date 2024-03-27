using Models.Abstracts;
using Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Concrete
{

   
    public class User:BaseEntity
    {
        public int UserID { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public UserType UserType { get; set; }

        public ICollection<MealSummary>? MealSummary { get; set; }

        public UserDetail? UserDetail { get; set; }

        public override string ToString()
        {
            return Email + "      =>    " + base.Status.ToString();
        }
    }
}
