using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Softbinator_Project.DTOs;
using Softbinator_Project.Entities;
using Softbinator_Project.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Softbinator_Project.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class HomeController : ControllerBase
    {
        public readonly Softbinator_ProjectContext _context;
        private readonly ITutoreService _tutoreService;

        public HomeController(Softbinator_ProjectContext context, ITutoreService tutoreService)
        {
            _context = context;
            _tutoreService = tutoreService;
        }

        [HttpGet]
        [Authorize(Policy = "Admin")]
        public IActionResult Get()
        {
            var pacientiDB = _context.Pacienti;

            var pacienti = pacientiDB
                .OrderBy(d => d.Nume)
                .Select(PacientViewModel.Projection);

            var afisarepacienti = _context.Pacienti.Include(d => d.Programari).ThenInclude(d => d.Doctor).Select(PacientDB => new PacientViewModel
            {
                Nume = PacientDB.Nume,
                Prenume = PacientDB.Prenume,
                CNP = PacientDB.CNP,
                Gen = PacientDB.Gen,
                Inaltime = PacientDB.Inaltime,
                Greutate = PacientDB.Greutate,
                Alergie = PacientDB.Alergie,
                Programari = PacientDB.Programari.Select(x => new ProgramareViewModel
                {
                    Data = x.Data,
                    Observatii = x.Observatii,
                    Tratament = x.Tratament
                }).ToList()
            });


            // var result = pacienti;
            var result = afisarepacienti;


            return Ok(result);
        }

        
        /*[HttpPost]
       // [Authorize(Policy = "Admin")]
        public IActionResult CreateTutoreQuery([FromQuery] TutoreDto model)
        {
            _tutoreService.CreateTutore(model);
            return Ok();
        }*/
     
    }
}
