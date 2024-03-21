﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models.Concrete;

namespace DAL.Configurations
{
    public class User_CFG : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(x => x.Name).HasColumnType("varchar").HasMaxLength(50).IsRequired();
            builder.Property(x => x.Surname).HasColumnType("varchar").HasMaxLength(50).IsRequired();
            builder.Property(x => x.Email).HasColumnType("varchar").HasMaxLength(60).IsRequired();
            builder.Property(x => x.Password).HasColumnType("varchar").HasMaxLength(60).IsRequired();
        }
    }
}
