using Softbinator_Project.DTOs;
using Softbinator_Project.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Softbinator_Project.Services.PacientServices
{
    public class PacientService : IPacientService
    {
        public readonly Softbinator_ProjectContext _context;

        public PacientService(Softbinator_ProjectContext context)
        {
            _context = context;
        }

        public void CreatePacient(PacientDto model)
        {
            var pacient = new Pacient
            {
                Nume = model.Nume,
                Prenume = model.Prenume,
                CNP = model.CNP,
                Inaltime = model.Inaltime,
                Alergie = model.Alergie,
                Gen = model.Gen,
                Greutate = model.Greutate,
                TutoreId = model.TutoreId,
            };
            _context.Pacienti.Add(pacient);
            _context.SaveChanges();
        }

        public void EditPacient(int id, PacientDto model)
        {
            var pacienti = _context.Pacienti.ToList();
            var pacient = _context.Pacienti.FirstOrDefault(x => x.Id == model.Id);
            pacient.Nume = model.Nume;
            pacient.Prenume = model.Prenume;
            pacient.CNP = model.CNP;
            pacient.Inaltime = model.Inaltime;
            pacient.Alergie = model.Alergie;
            pacient.Gen = model.Gen;
            pacient.Greutate = model.Greutate;
            pacient.TutoreId = model.TutoreId;
          
            _context.SaveChanges(); 
        }

        public List<PacientDto> GetPacienti()
        {
            var pacienti = _context.Pacienti.Select(PacientDto.Projection).ToList();          
            return pacienti;
        }

    }
}

