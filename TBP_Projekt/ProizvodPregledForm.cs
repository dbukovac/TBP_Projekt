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
    public partial class ProizvodPregledForm : Form
    {
        Proizvod selektiraniProizvod = null;

        public ProizvodPregledForm()
        {
            InitializeComponent();
        }

        private void ProizvodPregledForm_Load(object sender, EventArgs e)
        {
            PrikaziProizvode();
            PrikaziRobu(proizvodBindingSource.Current as Proizvod);
        }

        private void PrikaziProizvode()
        {
            dataGridViewProizvod.Rows.Clear();
            BindingList<Proizvod> listaProizvoda = null;
            using (var db = new TBP_BazeEntities())
            {
                listaProizvoda = new BindingList<Proizvod>(db.Proizvod.ToList());

            }
            proizvodBindingSource.DataSource = listaProizvoda;
        }

        private void PrikaziRobu(Proizvod proizvod)
        {
            dataGridViewRoba.Rows.Clear();
            if (proizvod != null)
            {
                BindingList<Proizvod_has_Roba> listaProizvod_has_Roba = null;
                BindingList<Roba> listaRoba = new BindingList<Roba>();
                using (var db = new TBP_BazeEntities())
                {
                    db.Proizvod.Attach(proizvod);
                    listaProizvod_has_Roba = new BindingList<Proizvod_has_Roba>(proizvod.Proizvod_has_Roba.ToList());

                    foreach (var F in listaProizvod_has_Roba)
                    {
                        listaRoba.Add(F.Roba as Roba);
                    }
                }
                proizvodhasRobaBindingSource.DataSource = listaProizvod_has_Roba;
                robaBindingSource.DataSource = listaRoba;
            }
        }

        private void buttonNovi_Click(object sender, EventArgs e)
        {
            ProizvodUnosForm proizvodForm = new ProizvodUnosForm();
            proizvodForm.ShowDialog();
            PrikaziProizvode();
        }

        private void buttonBriši_Click(object sender, EventArgs e)
        {
            selektiraniProizvod = proizvodBindingSource.Current as Proizvod;
            if (selektiraniProizvod != null)
            {
                if (MessageBox.Show("Da li ste sigurni?", "Upozorenje!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    using (var db = new TBP_BazeEntities())
                    {
                        db.Proizvod.Attach(selektiraniProizvod);
                        if (selektiraniProizvod.Radni_nalog_has_Proizvod.Count == 0)
                        {
                            db.Proizvod.Remove(selektiraniProizvod);
                            db.SaveChanges();
                        }
                        else
                        {
                            MessageBox.Show("Nije moguće obrisati proizvod koji se koristi");
                        }
                    }
                    PrikaziProizvode();
                }
            }
        }

        private void dataGridViewProizvod_SelectionChanged(object sender, EventArgs e)
        {
            PrikaziRobu(proizvodBindingSource.Current as Proizvod);
        }

        private void buttonIzmjena_Click(object sender, EventArgs e)
        {
            selektiraniProizvod = proizvodBindingSource.Current as Proizvod;
            if (selektiraniProizvod != null)
            {
                ProizvodIzmjenaForm proizvodForm = new ProizvodIzmjenaForm(selektiraniProizvod);
                proizvodForm.ShowDialog();
                PrikaziProizvode();
            }
        }
    }
}
