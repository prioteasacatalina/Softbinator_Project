using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Softbinator_Project.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Softbinator_Project.EntityConfigurations
{
    public class TutoreConfiguration : IEntityTypeConfiguration<Tutore>
    {
        public void Configure(EntityTypeBuilder<Tutore> builder)
        {
            builder.Property(a => a.Nume)
                .HasColumnType("varchar(100)")
                .HasMaxLength(100)
                .IsRequired();


            builder.Property(a => a.Prenume)
                    .HasColumnType("varchar(100)")
                    .HasMaxLength(100)
                    .IsRequired();
        }
    }
}
