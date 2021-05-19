using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Softbinator_Project.DTOs;
using Softbinator_Project.Services.CabinetServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Softbinator_Project.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class CabinetController : ControllerBase
    {
        private readonly Softbinator_ProjectContext _context;
        private readonly ICabinetService _cabinetService;

        public CabinetController(Softbinator_ProjectContext context, ICabinetService cabinetService)
        {
            _context = context;
            _cabinetService = cabinetService;
        }

        [Authorize(Policy = "Admin")]
        [HttpGet]
        public IActionResult Get()
        {
            var result = _cabinetService.GetCabinete();
            return Ok(result);
        }

        [Authorize(Policy = "Admin")]
        [HttpPost]
        public IActionResult Create(CabinetDto model)
        {
            _cabinetService.CreateCabinet(model);
            return Ok();
        }

        [Authorize(Policy = "Admin")]
        [HttpPut] 
        public IActionResult Edit(CabinetDto model) 
        {
            _cabinetService.EditCabinet(model);
            return Ok();
        }

        [Authorize(Policy = "Admin")]
        [HttpDelete]
        public IActionResult DeleteCabinet(int id)
        {
            _cabinetService.DeleteCabinet(id);
            return Ok();
        }
    }
}
