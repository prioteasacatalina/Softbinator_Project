using Microsoft.AspNetCore.Mvc;
using Softbinator_Project.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Softbinator_Project.Services
{
    public interface ITutoreService
    {
        List<TutoreDto> GetTutori();
        void CreateTutore(TutoreDto model);
        void EditTutore(int id, TutoreDto model);
    }
}
