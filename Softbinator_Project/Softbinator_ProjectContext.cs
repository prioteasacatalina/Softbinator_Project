using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Softbinator_Project.Entities;
using Softbinator_Project.EntityConfigurations;

#nullable disable

namespace Softbinator_Project
{
    public partial class Softbinator_ProjectContext : IdentityDbContext<User, Role, Guid, IdentityUserClaim<Guid>,
            UserRole, IdentityUserLogin<Guid>,
            IdentityRoleClaim<Guid>, IdentityUserToken<Guid>>
    { 

        public Softbinator_ProjectContext(DbContextOptions<Softbinator_ProjectContext> options) : base(options)
        {
        }

        public DbSet<Tutore> Tutori { get; set; }
        public DbSet<Pacient> Pacienti { get; set; }
        public DbSet<Cabinet> Cabinete { get; set; }
        public DbSet<Doctor> Doctori { get; set; }
        public DbSet<Programare> Programari { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new TutoreConfiguration());
            modelBuilder.ApplyConfiguration(new PacientConfiguration());
            modelBuilder.ApplyConfiguration(new CabinetConfiguration());
            modelBuilder.ApplyConfiguration(new DoctorConfiguration());
        }
    }
}
