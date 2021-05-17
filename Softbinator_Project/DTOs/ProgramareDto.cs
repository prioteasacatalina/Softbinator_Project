using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Softbinator_Project.DTOs
{
    public class ProgramareDto
    {
        public int Id { get; set; }

        public int PacientId { get; set; }

        public int DoctorId { get; set; }

        public DateTime Data { get; set; }

        public string Tratament { get; set; }

        public string Observatii { get; set; }

        public static Expression<Func<Entities.Programare, ProgramareDto>> Projection
        {
            get
            {
                return ProgramareDB => new ProgramareDto
                {
                    Id = ProgramareDB.Id,
                    Data = ProgramareDB.Data,
                    Tratament = ProgramareDB.Tratament,
                    Observatii = ProgramareDB.Observatii,
                    DoctorId = ProgramareDB.DoctorId,
                    PacientId = ProgramareDB.PacientId
                };
            }
        }
    }
}
