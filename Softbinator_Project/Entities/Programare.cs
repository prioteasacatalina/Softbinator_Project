using Softbinator_Project.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Softbinator_Project.Entities
{
    public class Programare
    {
        public int Id { get; set; }

        public int PacientId { get; set; }

        public int DoctorId { get; set; }

        public DateTime Data { get; set; }      

        public string Tratament { get; set; }

        public string Observatii { get; set; }

        public Pacient Pacient { get; set; }

        public Doctor Doctor { get; set; }

    }
}
