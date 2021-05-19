using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Softbinator_Project.DTOs;
using Softbinator_Project.Services.ProgramareServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Softbinator_Project.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class ProgramareController : ControllerBase
    {
        private readonly Softbinator_ProjectContext _context;
        private readonly IProgramareService _programareService;

        public ProgramareController(Softbinator_ProjectContext context, IProgramareService programareService)
        {
            _context = context;
            _programareService = programareService;
        }

        [Authorize(Policy = "Admin")]
        [HttpGet]
        public IActionResult Get()
        {
            var result = _programareService.GetProgramari();
            return Ok(result);
        }

        [Authorize(Policy = "Admin")]
        [HttpPost]
        public IActionResult Create(ProgramareDto model)
        {
            _programareService.CreateProgramare(model);
            return Ok();
        }

        [Authorize(Policy = "Admin")]
        [HttpPut] 
        public IActionResult Edit(ProgramareDto model) 
        {
            _programareService.EditProgramare(model);
            return Ok();
        }

        [Authorize(Policy = "Admin")]
        [HttpDelete]
        public IActionResult DeleteProgramare(int id)
        {
            _programareService.DeleteProgramare(id);
            return Ok();
        }
    }
}
