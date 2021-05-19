using Softbinator_Project.DTOs;
using Softbinator_Project.Entities;
using Softbinator_Project.Services.CabinetServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Softbinator_Project.Services
{
    public class CabinetService : ICabinetService
    {
        public readonly Softbinator_ProjectContext _context;

        public CabinetService(Softbinator_ProjectContext context)
        {
            _context = context;
        }

        public void CreateCabinet(CabinetDto model)
        {
            var cabinet = new Cabinet
            {
                Nume = model.Nume,
                Etaj = model.Etaj,
                Numar = model.Numar,
                Echipament = model.Echipament,
                Palier = model.Palier
            };
            _context.Cabinete.Add(cabinet);
            _context.SaveChanges();
        }

        public void EditCabinet(CabinetDto model)
        {
            var cabinet = _context.Cabinete.FirstOrDefault(x => x.Id == model.Id);
            cabinet.Nume = model.Nume;
            cabinet.Etaj = model.Etaj;
            cabinet.Numar = model.Numar;
            cabinet.Echipament = model.Echipament;
            cabinet.Palier = model.Palier;

            _context.SaveChanges();
        }

        public List<CabinetDto> GetCabinete()
        {
            var cabinete = _context.Cabinete.Select(CabinetDto.Projection).ToList();
            return cabinete;
        }

        public void DeleteCabinet(int id)
        {
            var cabinet = _context.Cabinete.FirstOrDefault(x => x.Id == id);
            _context.Cabinete.Remove(cabinet);
            _context.SaveChanges();
        }

    }
}
