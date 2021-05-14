using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Softbinator_Project.DTOs;
using Softbinator_Project.Services.DoctorServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Softbinator_Project.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class DoctorController : ControllerBase
    {
        private readonly Softbinator_ProjectContext _context;
        private readonly IDoctorService _doctorService;

        public DoctorController(Softbinator_ProjectContext context, IDoctorService doctorService)
        {
            _context = context;
            _doctorService = doctorService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = _doctorService.GetDoctori();
            return Ok(result);
        }

        [Authorize(Policy = "Admin")]
        [HttpPost]
        public IActionResult Create(DoctorDto model)
        {
            _doctorService.CreateDoctor(model);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Edit([FromRoute] int id, DoctorDto model)
        {
            _doctorService.EditDoctor(id, model);
            return Ok();
        }

    }
}
