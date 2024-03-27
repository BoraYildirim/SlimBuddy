using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models.Concrete;
using Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Seed
{
    public class SeedAdmin : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData
              (
                  new User { Email = "admin@admin.com", Password = "Admin123*", UserType = UserType.Admin, Status = Status.Active, UserID=1 }
                  );                
        }
    }
}
