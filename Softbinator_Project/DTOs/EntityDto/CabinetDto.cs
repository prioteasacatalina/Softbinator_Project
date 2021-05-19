using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Softbinator_Project.DTOs
{
    public class CabinetDto
    {
        public int Id { get; set; }

        public string Nume { get; set; }

        public int Etaj { get; set; }

        public int Numar { get; set; }

        public string Echipament { get; set; }

        public string Palier { get; set; }

        public static Expression<Func<Entities.Cabinet, CabinetDto>> Projection
        {
            get
            {
                return CabinetDB => new CabinetDto
                {
                    Id = CabinetDB.Id,
                    Nume = CabinetDB.Nume,
                    Etaj = CabinetDB.Etaj,
                    Numar = CabinetDB.Numar,
                    Echipament = CabinetDB.Echipament,
                    Palier = CabinetDB.Palier
                };
            }
        }
    }
}
