using Softbinator_Project.DTOs;
using Softbinator_Project.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Softbinator_Project.Services.ProgramareServices
{
    public class ProgramareService : IProgramareService
    {
        public readonly Softbinator_ProjectContext _context;

        public ProgramareService(Softbinator_ProjectContext context)
        {
            _context = context;
        }
        public List<ProgramareDto> GetProgramari()
        {
            var programari = _context.Programari.Select(ProgramareDto.Projection).ToList();
            return programari;
        }

        public void CreateProgramare(ProgramareDto model)
        {
            var programare = new Programare
            {
                Data = model.Data,
                Tratament = model.Tratament,
                Observatii = model.Observatii,
                DoctorId = model.DoctorId,
                PacientId = model.PacientId
            };

            _context.Programari.Add(programare);
            _context.SaveChanges();
        }

        public void EditProgramare(ProgramareDto model)
        {
            var programare = _context.Programari.FirstOrDefault(x => x.Id == model.Id);
            programare.Data = model.Data;
            programare.Tratament = model.Tratament;
            programare.Observatii = model.Observatii;
            programare.DoctorId = model.DoctorId;
            programare.PacientId = model.PacientId;

            _context.SaveChanges();
        }

        public void DeleteProgramare(int id)
        {
            var programare = _context.Programari.FirstOrDefault(x => x.Id == id);
            _context.Programari.Remove(programare);
            _context.SaveChanges();
        }

    }
}
