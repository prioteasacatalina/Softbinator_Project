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

        [Authorize(Policy = "Admin")]
        [HttpGet]
        public IActionResult Get()
        {
            var result = _doctorService.GetDoctori();
            return Ok(result);
        }

        [Authorize(Policy = "Doctor")]
        [HttpPost]
        public IActionResult Create(DoctorDto model)
        {
            _doctorService.CreateDoctor(model);
            return Ok();
        }

        [Authorize(Policy = "Doctor")]
        [HttpPut] //("{id}")
        public IActionResult Edit(int id, DoctorDto model) //[FromRoute]
        {
            _doctorService.EditDoctor(id, model);
            return Ok();
        }

    }
}
