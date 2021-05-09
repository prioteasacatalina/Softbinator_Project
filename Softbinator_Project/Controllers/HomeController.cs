using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Softbinator_Project.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Softbinator_Project.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class HomeController : ControllerBase
    {
        public readonly Softbinator_ProjectContext _context;

        public HomeController(Softbinator_ProjectContext context)
        {
            _context = context;
        }

        [HttpGet]
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
    }
}
