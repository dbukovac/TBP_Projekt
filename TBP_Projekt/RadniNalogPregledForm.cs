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
    public partial class RadniNalogPregledForm : Form
    {
        Zaposlenik logirani_korisnik = null;
        Radni_nalog selektiraniNalog = null;

        public RadniNalogPregledForm(Zaposlenik zap)
        {
            InitializeComponent();
            logirani_korisnik = zap;
        }

        private void RadniNalogPregledForm_Load(object sender, EventArgs e)
        {
            PrikaziRadneNaloge();
            PrikaziProizvode(radninalogBindingSource.Current as Radni_nalog);
        }

        private void PrikaziRadneNaloge()
        {
            dataGridViewNarudzbe.Rows.Clear();
            BindingList<Radni_nalog> listaNaloga = null;
            using (var db = new TBP_BazeEntities())
            {
                listaNaloga = new BindingList<Radni_nalog>(db.Radni_nalog.ToList());

            }
            radninalogBindingSource.DataSource = listaNaloga;
        }

        private void PrikaziProizvode(Radni_nalog radniNalog)
        {
            dataGridViewRoba.Rows.Clear();
            if (radniNalog != null)
            {
                BindingList<Radni_nalog_has_Proizvod> listaProizvod_has_radni_nalog = null;
                BindingList<Proizvod> listaProizvoda = new BindingList<Proizvod>();
                using (var db = new TBP_BazeEntities())
                {
                    db.Radni_nalog.Attach(radniNalog);
                    listaProizvod_has_radni_nalog = new BindingList<Radni_nalog_has_Proizvod>(radniNalog.Radni_nalog_has_Proizvod.ToList());

                    foreach (var F in listaProizvod_has_radni_nalog)
                    {
                        listaProizvoda.Add(F.Proizvod as Proizvod);
                    }
                }
                radninaloghasProizvodBindingSource.DataSource = listaProizvod_has_radni_nalog;
                proizvodBindingSource.DataSource = listaProizvoda;
            }
        }

        private void buttonNovi_Click(object sender, EventArgs e)
        {
            RadniNalogUnosForm radniNalogForm = new RadniNalogUnosForm(logirani_korisnik);
            radniNalogForm.ShowDialog();
            PrikaziRadneNaloge();
        }

        private void buttonBriši_Click(object sender, EventArgs e)
        {
            selektiraniNalog = radninalogBindingSource.Current as Radni_nalog;
            if (selektiraniNalog != null)
            {
                if (MessageBox.Show("Da li ste sigurni?", "Upozorenje!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    using (var db = new TBP_BazeEntities())
                    {
                        db.Radni_nalog.Attach(selektiraniNalog);
                        if (selektiraniNalog.zavrseno == 0)
                        {
                            db.Radni_nalog.Remove(selektiraniNalog);
                            db.SaveChanges();
                        }
                        else
                        {
                            MessageBox.Show("Nije moguće obrisati radni nalog koji je završen");
                        }
                    }
                    PrikaziRadneNaloge();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            selektiraniNalog = radninalogBindingSource.Current as Radni_nalog;
            if (selektiraniNalog != null)
            {
                using (var db = new TBP_BazeEntities())
                {
                    db.Radni_nalog.Attach(selektiraniNalog);
                    selektiraniNalog.zavrseno = 1;
                    db.SaveChanges();
                }
                MessageBox.Show("Radni nalog zavrsen");
            }
        }

        private void dataGridViewNarudzbe_SelectionChanged(object sender, EventArgs e)
        {
            PrikaziProizvode(radninalogBindingSource.Current as Radni_nalog);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            selektiraniNalog = radninalogBindingSource.Current as Radni_nalog;
            if (selektiraniNalog != null)
            {
                RadniNalogIzmjenaForm nalogForm = new RadniNalogIzmjenaForm(selektiraniNalog);
                nalogForm.ShowDialog();
                PrikaziRadneNaloge();
            }
        }
    }
}
