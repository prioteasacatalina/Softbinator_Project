using Softbinator_Project.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Softbinator_Project.Services.DoctorServices
{
    public interface IDoctorService
    {
        List<DoctorDto> GetDoctori();
        void CreateDoctor(DoctorDto model);
        void EditDoctor(int id, DoctorDto model);
    }
}
