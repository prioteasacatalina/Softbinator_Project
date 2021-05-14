﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Softbinator_Project.DTOs;
using Softbinator_Project.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Softbinator_Project.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class TutoreController : ControllerBase
    {
        private readonly Softbinator_ProjectContext _context;
        private readonly ITutoreService _tutoreService;

        public TutoreController(Softbinator_ProjectContext context, ITutoreService tutoreService)
        {
            _context = context;
            _tutoreService = tutoreService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = _tutoreService.GetTutori();
            return Ok(result);
        }

        [Authorize(Policy = "Admin")]
        [HttpPost]
        public IActionResult Create(TutoreDto model)
        {
            _tutoreService.CreateTutore(model);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Edit([FromRoute] int id, TutoreDto model)
        {
            _tutoreService.EditTutore(id, model);
            return Ok();
        }
    }
}
