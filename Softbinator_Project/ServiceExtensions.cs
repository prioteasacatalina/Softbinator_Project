using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Softbinator_Project.Seeders;

namespace Softbinator_Project
{
    public static class ServiceExtensions
    {
        public static void AddSeeders(this IServiceCollection services)
        {
            services.AddTransient<InitialSeeder>();
        }
    }
}
