using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Softbinator_Project.DTOs
{
    public class PacientDto
    {
        public int Id { get; set; }
        public string Nume { get; set; }

        public string Prenume { get; set; }

        public string CNP { get; set; }

        public string Gen { get; set; }

        public double Inaltime { get; set; }

        public double Greutate { get; set; }

        public string Alergie { get; set; }

        public int TutoreId { get; set; }

        public static Expression<Func<Entities.Pacient, PacientDto>> Projection
        {
            get
            {
                return PacientDB => new PacientDto
                {
                    Id = PacientDB.Id,
                    Nume = PacientDB.Nume,
                    Prenume = PacientDB.Prenume,
                    CNP = PacientDB.CNP,
                    Inaltime = PacientDB.Inaltime,
                    Greutate = PacientDB.Greutate,
                    Alergie = PacientDB.Alergie,
                    Gen = PacientDB.Gen,
                    TutoreId = PacientDB.TutoreId
                };
            }
        }
    }
}
