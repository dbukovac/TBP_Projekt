using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBP_Projekt
{
    class RobaSaKolicinom
    {
        public int kolicina;
        public int idRoba;
        public string naziv;

        public RobaSaKolicinom(Roba r, int kol)
        {
            this.naziv = r.naziv;
            this.idRoba = r.idRoba;
            this.kolicina = kol;
        }

        public int Kolicina
        {
            get { return kolicina; }
            set { kolicina = value; }
        }

        public int IdRoba
        {
            get { return idRoba; }
            set { idRoba = value; }
        }

        public string Naziv
        {
            get { return naziv; }
            set { naziv = value; }
        }
    }
}
