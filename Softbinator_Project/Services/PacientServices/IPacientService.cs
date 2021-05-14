using Softbinator_Project.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Softbinator_Project.Services.PacientServices
{
    public interface IPacientService
    {
        List<PacientDto> GetPacienti();
        void CreatePacient(PacientDto model);
        void EditPacient(int id, PacientDto model);
    }
}
