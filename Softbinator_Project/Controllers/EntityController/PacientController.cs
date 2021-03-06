using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Softbinator_Project.DTOs;
using Softbinator_Project.Services.PacientServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Softbinator_Project.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class PacientController : ControllerBase
    {
        private readonly Softbinator_ProjectContext _context;
        private readonly IPacientService _pacientService;

        public PacientController(Softbinator_ProjectContext context, IPacientService pacientService)
        {
            _context = context;
            _pacientService = pacientService;
        }

        [Authorize(Policy = "Admin")]
        [HttpGet]
        public IActionResult Get()
        {
            var result = _pacientService.GetPacienti();
            return Ok(result);
        }

        [Authorize(Policy = "Pacient")]
        [HttpPost]
        public IActionResult Create(PacientDto model)
        {
            _pacientService.CreatePacient(model);
            return Ok();
        }

        [Authorize(Policy = "Pacient")]
        [HttpPut] 
        public IActionResult Edit(PacientDto model) 
        {
            _pacientService.EditPacient(model);
            return Ok();
        }

        [Authorize(Policy = "Admin")]
        [HttpDelete]
        public IActionResult DeletePacient(int id)
        {
            _pacientService.DeletePacient(id);
            return Ok();
        }

    }
}

