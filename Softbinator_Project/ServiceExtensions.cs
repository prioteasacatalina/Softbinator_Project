using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Softbinator_Project.Seeders;
using Softbinator_Project.Services;
using Softbinator_Project.Services.CabinetServices;
using Softbinator_Project.Services.DoctorServices;
using Softbinator_Project.Services.PacientServices;
using Softbinator_Project.Services.ProgramareServices;

namespace Softbinator_Project
{
    public static class ServiceExtensions
    {
        public static void AddSeeders(this IServiceCollection services)
        {
            services.AddTransient<InitialSeeder>();
            services.AddTransient<ITutoreService, TutoreService>();
            services.AddTransient<IPacientService, PacientService>();
            services.AddTransient<ICabinetService, CabinetService>();
            services.AddTransient<IDoctorService, DoctorService>();
            services.AddTransient<IProgramareService, ProgramareService>();
        }
    }
}
