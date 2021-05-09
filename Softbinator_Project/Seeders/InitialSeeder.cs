using Softbinator_Project.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Softbinator_Project.Seeders
{
    public class InitialSeeder
    {
        private readonly Softbinator_ProjectContext _context;
        public InitialSeeder(Softbinator_ProjectContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            #region Tutore

            var tutori = _context.Tutori.Any();

            _context.SaveChanges();

            if (!tutori)
            {
                var tutore1 = new Tutore
                {
                    Nume = "Popescu",
                    Prenume = "Vasilica",
                    Telefon = "0729324921",
                    Adresa = "Soseaua Pantelimon, nr 8",
                    Email = "pop_vasi@yahoo.com",
                    CNP = "2981209280854"
                };

                var tutore2 = new Tutore
                {
                    Nume = "Vasilescu",
                    Prenume = "Petronela",
                    Telefon = "0728774321",
                    Adresa = "Soseaua Virtutii, nr 9",
                    Email = "vasi_peto@yahoo.com",
                    CNP = "2981212275943"
                };

                var tutore3 = new Tutore
                {
                    Nume = "Iorgulescu",
                    Prenume = "Amalia",
                    Telefon = "0728778374",
                    Adresa = "Strada Bucuriei, nr 29",
                    Email = "iorgu_ama@yahoo.com",
                    CNP = "2940723758473"
                };

                var tutore4 = new Tutore
                {
                    Nume = "Surdu",
                    Prenume = "Ion",
                    Telefon = "0737837210",
                    Adresa = "Strada Soarelui, nr 28",
                    Email = "surdu_ion@yahoo.com",
                    CNP = "1700812876456"
                };

                var tutore5 = new Tutore
                {
                    Nume = "Paraschiv",
                    Prenume = "Alexandra",
                    Telefon = "0722692691",
                    Adresa = "Strada Dristorului, nr 9",
                    Email = "par_ale@yahoo.com",
                    CNP = "2702703963526"
                };

                _context.Tutori.Add(tutore1);
                _context.Tutori.Add(tutore2);
                _context.Tutori.Add(tutore3);
                _context.Tutori.Add(tutore4);
                _context.Tutori.Add(tutore5);
                _context.SaveChanges();
            }

            #endregion

            #region Pacient

              var pacienti = _context.Pacienti.Any();

              _context.SaveChanges();

              if (!pacienti)
              {
                  var tutoreid = _context.Tutori.FirstOrDefault().Id;

                  var pacient1 = new Pacient
                  {
                      Nume = "Popescu",
                      Prenume = "Aurel",
                      CNP = "1211214278763",
                      Gen = "masculin",
                      Inaltime = 120,
                      Greutate = 30,
                      Alergie = "capsuni",
                      TutoreId = tutoreid
                  };

                  var pacient2 = new Pacient
                  {
                      Nume = "Popescu",
                      Prenume = "Viorel",
                      CNP = "1200814223763",
                      Gen = "masculin",
                      Inaltime = 125,
                      Greutate = 35,
                      Alergie = "kiwi",
                      TutoreId = tutoreid
                  };

                  var pacient3 = new Pacient
                  {
                      Nume = "Vasilescu",
                      Prenume = "Alexandra",
                      CNP = "2201213947283",
                      Gen = "feminin",
                      Inaltime = 130,
                      Greutate = 35,
                      Alergie = "piersici",
                      TutoreId = 2
                  };

                  var pacient4 = new Pacient
                  {
                      Nume = "Iorgulescu",
                      Prenume = "Antonia",
                      CNP = "2202707856394",
                      Gen = "feminin",
                      Inaltime = 130,
                      Greutate = 27,
                      Alergie = "ananas",
                      TutoreId = 3
                  };

                  var pacient5 = new Pacient
                  {
                      Nume = "Surdu",
                      Prenume = "Bianca",
                      CNP = "2210924925342",
                      Gen = "feminin",
                      Inaltime = 128,
                      Greutate = 40,
                      Alergie = "pisici",
                      TutoreId = 4
                  };

                  var pacient6 = new Pacient
                  {
                      Nume = "Paraschiv",
                      Prenume = "Carmen",
                      CNP = "2991214765273",
                      Gen = "feminin",
                      Inaltime = 121,
                      Greutate = 26.5,
                      Alergie = "caini",
                      TutoreId = 5
                  };

                  _context.Pacienti.Add(pacient1);
                  _context.Pacienti.Add(pacient2);
                  _context.Pacienti.Add(pacient3);
                  _context.Pacienti.Add(pacient4);
                  _context.Pacienti.Add(pacient5);
                  _context.Pacienti.Add(pacient6);
                  _context.SaveChanges();
              }

              #endregion

            #region Cabinet

            var cabinete = _context.Cabinete.Any();

            _context.SaveChanges();

            if (!cabinete)
            {
                var cabinet1 = new Cabinet
                {
                    Nume = "Ecografie",
                    Etaj = 1,
                    Numar = 10,
                    Echipament = "ecograf",
                    Palier = "A"
                };

                var cabinet2 = new Cabinet
                {
                    Nume = "RMN",
                    Etaj = 1,
                    Numar = 11,
                    Echipament = "RMN",
                    Palier = "A"
                };

                var cabinet3 = new Cabinet
                {
                    Nume = "ORL",
                    Etaj = 1,
                    Numar = 23,
                    Echipament = "unitate orl",
                    Palier = "B"
                };

                var addCabinete = new List<Cabinet> { cabinet1, cabinet2, cabinet3 };
                _context.Cabinete.AddRange(addCabinete);
                _context.SaveChanges();
            }
            #endregion

            #region Doctor
            var doctori = _context.Doctori.Any();

            _context.SaveChanges();

            if(!doctori)
            {
                var cabinetId = _context.Cabinete.FirstOrDefault().Id;

                var doctor1 = new Doctor
                {
                    Nume = "Popa",
                    Prenume = "Ioan",
                    Telefon = "0743721894",
                    Specializare = "radiolog",
                    CNP = "1741214845037",
                    Email = "popa_ioan@yahoo.com",
                    CabinetId = cabinetId

                };

                var doctor2 = new Doctor
                {
                    Nume = "Popa",
                    Prenume = "Ioan",
                    Telefon = "0743721894",
                    Specializare = "radiolog",
                    CNP = "1741214845037",
                    Email = "popa_ioan@yahoo.com",
                    CabinetId = 2

                };

                var doctor3 = new Doctor
                {
                    Nume = "Musat",
                    Prenume = "Andrei",
                    Telefon = "0728982310",
                    Specializare = "ORL",
                    CNP = "1210910876263",
                    Email = "mus_and@yahoo.com",
                    CabinetId = 3

                };

                 var addDoctori = new List<Doctor> { doctor1, doctor2, doctor3 };
                _context.Doctori.AddRange(addDoctori);
                _context.SaveChanges();
            }
            #endregion

            #region Programare

            var programari = _context.Programari.Any();

            _context.SaveChanges();

            if (!programari)
            {
                var programare1 = new Programare
                {
                    PacientId = 1,
                    DoctorId = 1,
                    Data = "04/20/2021",
                    Tratament = "imobilizare la pat",
                    Observatii = "somn de voie"
                };

                var programare2 = new Programare
                {
                    PacientId = 2,
                    DoctorId = 2,
                    Data = "05/21/2021",
                    Tratament = "ghips",
                    Observatii = "picior fracturat"
                };

                var programare3 = new Programare
                {
                    PacientId = 3,
                    DoctorId = 3,
                    Data = "04/28/2021",
                    Tratament = "Systane Balance",
                    Observatii = "control lunar"              
                };

                var AddProgramari = new List<Programare> { programare1, programare2, programare3 };
                _context.Programari.AddRange(AddProgramari);
                _context.SaveChanges();

            }
            
            #endregion
        }
    }
}
