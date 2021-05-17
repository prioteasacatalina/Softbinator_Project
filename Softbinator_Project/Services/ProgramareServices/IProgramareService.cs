using Softbinator_Project.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Softbinator_Project.Services.ProgramareServices
{
    public interface IProgramareService
    {
        List<ProgramareDto> GetProgramari();
        void CreateProgramare(ProgramareDto model);
        void EditProgramare(int id, ProgramareDto model);
    }
}
