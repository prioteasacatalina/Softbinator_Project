using Softbinator_Project.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Softbinator_Project.DTOs
{
    public class PacientViewModel
    {
        public string Nume { get; set; }

        public string Prenume { get; set; }

        public string CNP { get; set; }

        public string Gen { get; set; }

        public double Inaltime { get; set; }

        public double Greutate { get; set; }

        public string Alergie { get; set; }

        public List<ProgramareViewModel> Programari { get; set; }

        public static Expression<Func<Entities.Pacient, PacientViewModel>> Projection
        {
            get
            {
                return PacientDB => new PacientViewModel
                {
                    Nume = PacientDB.Nume,
                    Prenume = PacientDB.Prenume,
                    CNP = PacientDB.CNP,
                    Inaltime = PacientDB.Inaltime,
                    Greutate = PacientDB.Greutate,
                    Alergie = PacientDB.Alergie,
                };
            }
        }
    }
}
