using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBP_Projekt
{
    class ProizvodSaKolicinom
    {
        public int kolicina;
        public int idProizvod;
        public string naziv;

        public ProizvodSaKolicinom(Proizvod r, int kol)
        {
            this.naziv = r.naziv;
            this.idProizvod = r.idProizvod;
            this.kolicina = kol;
        }

        public int Kolicina
        {
            get { return kolicina; }
            set { kolicina = value; }
        }

        public int IdProizvod
        {
            get { return idProizvod; }
            set { idProizvod = value; }
        }

        public string Naziv
        {
            get { return naziv; }
            set { naziv = value; }
        }
    }
}
