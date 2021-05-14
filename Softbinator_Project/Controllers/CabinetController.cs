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

        [HttpPut("{id}")]
        public IActionResult Edit([FromRoute] int id, CabinetDto model)
        {
            _cabinetService.EditCabinet(id, model);
            return Ok();
        }
    }
}
