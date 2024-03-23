using Models.Abstracts;
using Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Models.Concrete
{
    public class UserDetail:BaseEntity
    {
        [ForeignKey("User")]
        public int UserDetailID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        [Range(6, 99, ErrorMessage = "Please Enter the years between  6 - 99")]
        public int Age { get; set; }
        public Gender Gender { get; set; }

        [Range(55, 270, ErrorMessage = "Please Enter the years between  55 - 330")]
        public double Height { get; set; }

        [Range(30, 370, ErrorMessage = "Please Enter the years between  30 - 370")]
        public double Weight { get; set; }

        public ActivityLevel ActivityLevel{ get; set; }

        public User? User { get; set; }

    }
}
