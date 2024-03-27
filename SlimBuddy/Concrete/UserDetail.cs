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

       
        public int Age { get; set; }
        public Gender Gender { get; set; }

      
        public double Height { get; set; }

     
        public double Weight { get; set; }

        public ActivityLevel ActivityLevel{ get; set; }

        public User? User { get; set; }

    }
}
