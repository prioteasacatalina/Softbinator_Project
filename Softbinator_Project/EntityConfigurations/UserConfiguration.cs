using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Softbinator_Project.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Softbinator_Project.EntityConfigurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
       
            public void Configure(EntityTypeBuilder<User> builder)
            {
            builder
                .HasOne(a => a.Doctor)
                .WithOne(b => b.User)
                .HasForeignKey<Doctor>(b => b.UserId);

            builder
               .HasOne(a => a.Pacient)
               .WithOne(b => b.User)
                .HasForeignKey<Pacient>(b => b.UserId);

            }
        
    }
}
