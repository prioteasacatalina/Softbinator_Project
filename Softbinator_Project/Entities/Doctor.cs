using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Softbinator_Project.Entities
{
    public class Doctor
    {
        public int Id { get; set; }

        public string Nume { get; set; }

        public string Prenume { get; set; }

        public string Telefon { get; set; }

        public string Specializare { get; set; }

        public string Email { get; set; }

        public string CNP { get; set; }

        public int CabinetId { get; set; }

        public Cabinet Cabinet { get; set; }

        public ICollection<Programare> Programari { get; set; }

    }
}
