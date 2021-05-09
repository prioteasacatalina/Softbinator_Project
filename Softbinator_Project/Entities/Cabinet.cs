using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Softbinator_Project.Entities
{
    public class Cabinet
    {
        public int Id { get; set; }

        public string Nume { get; set; }

        public int Etaj { get; set; }

        public int Numar { get; set; }

        public string Echipament { get; set; }

        public string Palier { get; set; }

        public ICollection<Doctor> Doctori { get; set; }      

    }
}
