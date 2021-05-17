using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Softbinator_Project.Entities
{
    public class Pacient
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

        public Tutore Tutore { get; set; }

        public ICollection<Programare> Programari { get; set; }

        public Guid? UserId { get; set; }

        [ForeignKey("UserId")]

        public User User { get; set; }
    }
}
