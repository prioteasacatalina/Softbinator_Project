using Softbinator_Project.DTOs;
using Softbinator_Project.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Softbinator_Project.Services.CabinetServices
{
    public interface ICabinetService
    {
        List<CabinetDto> GetCabinete();
        void CreateCabinet(CabinetDto model);
        void EditCabinet(int id, CabinetDto model);
    }
}
