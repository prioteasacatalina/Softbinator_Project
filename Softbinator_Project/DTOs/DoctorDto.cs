using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Softbinator_Project.DTOs
{
    public class DoctorDto
    {
        public int Id { get; set; }

        public string Nume { get; set; }

        public string Prenume { get; set; }

        public string Telefon { get; set; }

        public string Specializare { get; set; }

        public string Email { get; set; }

        public string CNP { get; set; }

        public int CabinetId { get; set; }

        public static Expression<Func<Entities.Doctor, DoctorDto>> Projection
        {
            get
            {
                return DoctorDB => new DoctorDto
                {
                    Id = DoctorDB.Id,
                    Nume = DoctorDB.Nume,
                    Prenume = DoctorDB.Prenume,
                    Telefon = DoctorDB.Telefon,
                    Specializare = DoctorDB.Specializare,
                    Email = DoctorDB.Email,
                    CNP = DoctorDB.CNP,
                    CabinetId = DoctorDB.CabinetId
                };
            }
        }
    }
}
