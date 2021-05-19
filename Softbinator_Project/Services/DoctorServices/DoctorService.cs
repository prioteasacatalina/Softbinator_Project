using Softbinator_Project.DTOs;
using Softbinator_Project.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Softbinator_Project.Services.DoctorServices
{
    public class DoctorService : IDoctorService
    {
        public readonly Softbinator_ProjectContext _context;

        public DoctorService(Softbinator_ProjectContext context)
        {
            _context = context;
        }

        public List<DoctorDto> GetDoctori()
        {
            var doctori = _context.Doctori.Select(DoctorDto.Projection).ToList();
            return doctori;
        }

        public void CreateDoctor(DoctorDto model)
        {
            var doctor = new Doctor
            {
                Nume = model.Nume,
                Prenume = model.Prenume,
                Telefon = model.Telefon,
                Specializare = model.Specializare,
                Email = model.Email,
                CNP = model.CNP,
                CabinetId = model.CabinetId,               
            };
            _context.Doctori.Add(doctor);
            _context.SaveChanges();
        }

        public void EditDoctor(DoctorDto model)
        {
            var doctor = _context.Doctori.FirstOrDefault(x => x.Id == model.Id);
            doctor.Nume = model.Nume;
            doctor.Prenume = model.Prenume;
            doctor.Telefon = model.Telefon;
            doctor.Specializare = model.Specializare;
            doctor.Email = model.Email;
            doctor.CabinetId = model.CabinetId;

            _context.SaveChanges();
        }

        public void DeleteDoctor(int id)
        {
            var doctor = _context.Doctori.FirstOrDefault(x => x.Id == id);
            _context.Doctori.Remove(doctor);
            _context.SaveChanges();
        }
    }
}
