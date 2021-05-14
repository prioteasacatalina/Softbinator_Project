using Softbinator_Project.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Softbinator_Project.Entities
{
    public class Tutore
    {
        public int Id { get; set; }

        public string Nume { get; set; }

        public string Prenume { get; set; }

        public string Telefon { get; set; }

        public string Adresa { get; set; }

        public string Email { get; set; }

        public string CNP { get; set; }

        public ICollection<Pacient> Pacienti { get; set; }
  
    }
}
