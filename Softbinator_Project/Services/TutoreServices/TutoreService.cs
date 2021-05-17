using Softbinator_Project.DTOs;
using Softbinator_Project.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Softbinator_Project.Services
{
    public class TutoreService : ITutoreService
    {
        public readonly Softbinator_ProjectContext _context;

        public TutoreService(Softbinator_ProjectContext context)
        {
            _context = context;
        }

        public List<TutoreDto> GetTutori()
        {
            var tutori = _context.Tutori.Select(TutoreDto.Projection).ToList();
            return tutori;
        }

        public void CreateTutore(TutoreDto model)
        {
            var tutore = new Tutore
            {
                Nume = model.Nume,
                Prenume = model.Prenume,
                Adresa = model.Adresa,
                CNP = model.CNP,
                Email = model.Email,
                Telefon = model.Telefon                  
            };
            _context.Tutori.Add(tutore);
            _context.SaveChanges();
        }
              

        public void EditTutore(int id, TutoreDto model)
        {
            var tutori = _context.Tutori.ToList();
            var tutore = _context.Tutori.FirstOrDefault(x => x.Id == model.Id);
            tutore.Nume = model.Nume;
            tutore.Prenume = model.Prenume;
            tutore.Adresa = model.Adresa;
            tutore.CNP = model.CNP;
            tutore.Email = model.Email;
            tutore.Telefon = model.Telefon;
          
            _context.SaveChanges();
        }

    }
}

