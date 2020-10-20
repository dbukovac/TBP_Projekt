using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TBP_Projekt
{
    public partial class RobaPregledForm : Form
    {
        Roba selektiranaRoba = null;

        public RobaPregledForm()
        {
            InitializeComponent();
        }

        private void buttonNovi_Click(object sender, EventArgs e)
        {
            RobaUnosForm robaForm = new RobaUnosForm();
            robaForm.ShowDialog();
            PrikaziRobu();
        }

        private void RobaPregledForm_Load(object sender, EventArgs e)
        {
            PrikaziRobu();
        }

        private void PrikaziRobu()
        {
            dataGridViewRoba.Rows.Clear();
            BindingList<Roba> listaRobe = null;
            using (var db = new TBP_BazeEntities())
            {
                listaRobe = new BindingList<Roba>(db.Roba.ToList());

            }
            robaBindingSource.DataSource = listaRobe;
        }

        private void buttonBriši_Click(object sender, EventArgs e)
        {
            selektiranaRoba = robaBindingSource.Current as Roba;
            if (selektiranaRoba != null)
            {
                if (MessageBox.Show("Da li ste sigurni?", "Upozorenje!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    using (var db = new TBP_BazeEntities())
                    {
                        db.Roba.Attach(selektiranaRoba);
                        if (selektiranaRoba.Narudzba_has_Roba.Count == 0 && selektiranaRoba.Proizvod_has_Roba.Count == 0)
                        {
                            db.Roba.Remove(selektiranaRoba);
                            db.SaveChanges();
                        }
                        else
                        {
                            MessageBox.Show("Nije moguće obrisati robu koji se koristi");
                        }
                    }
                    PrikaziRobu();
                }
            }
        }

        private void buttonIzmjena_Click(object sender, EventArgs e)
        {
            selektiranaRoba = robaBindingSource.Current as Roba;
            if (selektiranaRoba != null)
            {
                RobaUnosForm robaForm = new RobaUnosForm(selektiranaRoba);
                robaForm.ShowDialog();
                PrikaziRobu();
            }
        }

        private void buttonMinKol_Click(object sender, EventArgs e)
        {
            List<Roba> listaRobe = null;
            using (var db = new TBP_BazeEntities())
            {
                listaRobe = new List<Roba>(db.Roba.ToList());
            }
            List<Proizvod_has_Roba> listaProizvoda = new List<Proizvod_has_Roba>();
            using (var db = new TBP_BazeEntities())
            {
                listaProizvoda = new List<Proizvod_has_Roba>(db.Proizvod_has_Roba.ToList());
            }
            List<Radni_nalog_has_Proizvod> listaNaloga = new List<Radni_nalog_has_Proizvod>();
            using (var db = new TBP_BazeEntities())
            {
                listaNaloga = new List<Radni_nalog_has_Proizvod>(db.Radni_nalog_has_Proizvod.ToList());
            }
            foreach (Roba r in listaRobe)
            {
                int ukupnaKolicina = 0;
                foreach(Proizvod_has_Roba pro in listaProizvoda)
                {
                    foreach(Radni_nalog_has_Proizvod rad in listaNaloga)
                    {
                        if(r.idRoba == pro.Roba_idRoba && pro.Proizvod_idProizvod == rad.Proizvod_idProizvod)
                        {
                            ukupnaKolicina += pro.kolicina * rad.kolicina;
                        }
                    }
                }
                int razmak = (DateTime.Now.Date - r.datum).Days;
                double poDanu = 0;
                if(razmak != 0)
                {
                    poDanu = (ukupnaKolicina / razmak);
                }
                else
                {
                    poDanu = ukupnaKolicina;
                }
                double uGodini = poDanu * 365;
                double minKol = poDanu * r.trajanje_dostave;
                minKol += Math.Round(minKol * 0.1);

                using (var db = new TBP_BazeEntities())
                {
                    db.Roba.Attach(r);
                    r.min_kolicina = (int)minKol;
                    r.potraznja = (int)uGodini;
                    db.SaveChanges();
                }
            }
            PrikaziRobu();
        }
    }
}
