using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Softbinator_Project.DTOs
{
    public class TutoreDto
    {
        public int Id { get; set; }
        public string Nume { get; set; }

        public string Prenume { get; set; }

        public string Telefon { get; set; }

        public string Adresa { get; set; }

        public string Email { get; set; }

        public string CNP { get; set; }

        public static Expression<Func<Entities.Tutore, TutoreDto>> Projection
        {
            get
            {
                return TutoreDB => new TutoreDto
                {
                    Id = TutoreDB.Id,
                    Nume = TutoreDB.Nume,
                    Prenume = TutoreDB.Prenume,
                    Adresa = TutoreDB.Adresa,
                    CNP = TutoreDB.CNP,
                    Email = TutoreDB.Email,
                    Telefon = TutoreDB.Telefon,
                    
                };
            }
        }
    }
}
