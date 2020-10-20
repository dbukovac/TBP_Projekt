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
    public partial class NarudzbePregledForm : Form
    {
        Narudzba selektiranaNarudzba = null;
        Zaposlenik logirani_korisnik = null;

        public NarudzbePregledForm(Zaposlenik zap)
        {
            InitializeComponent();
            logirani_korisnik = zap;
        }

        private void buttonNovi_Click(object sender, EventArgs e)
        {
            NarudzbaUnosForm narudzbaForm = new NarudzbaUnosForm(logirani_korisnik);
            narudzbaForm.ShowDialog();
            PrikaziNarudzbe();
        }

        private void NarudzbePregledForm_Load(object sender, EventArgs e)
        {
            PrikaziNarudzbe();
            PrikaziRobu(narudzbaBindingSource.Current as Narudzba);
        }

        private void PrikaziNarudzbe()
        {
            dataGridViewNarudzbe.Rows.Clear();
            BindingList<Narudzba> listaNarudzba = null;
            using (var db = new TBP_BazeEntities())
            {
                listaNarudzba = new BindingList<Narudzba>(db.Narudzba.ToList());

            }
            narudzbaBindingSource.DataSource = listaNarudzba;
        }

        private void PrikaziRobu(Narudzba narudzba)
        {
            dataGridViewRoba.Rows.Clear();
            if (narudzba != null)
            {
                BindingList<Narudzba_has_Roba> listaNarudzba_has_Roba = null;
                BindingList<Roba> listaRoba = new BindingList<Roba>();
                using (var db = new TBP_BazeEntities())
                {
                    db.Narudzba.Attach(narudzba);
                    listaNarudzba_has_Roba = new BindingList<Narudzba_has_Roba>(narudzba.Narudzba_has_Roba.ToList());

                    foreach (var F in listaNarudzba_has_Roba)
                    {
                        listaRoba.Add(F.Roba as Roba);
                    }
                }
                narudzbahasRobaBindingSource.DataSource = listaNarudzba_has_Roba;
                robaBindingSource.DataSource = listaRoba;
            }
        }

        private void buttonBriši_Click(object sender, EventArgs e)
        {
            selektiranaNarudzba = narudzbaBindingSource.Current as Narudzba;
            if (selektiranaNarudzba != null)
            {
                if (MessageBox.Show("Da li ste sigurni?", "Upozorenje!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    using (var db = new TBP_BazeEntities())
                    {
                        db.Narudzba.Attach(selektiranaNarudzba);
                        if (selektiranaNarudzba.zaprimljeno == 0)
                        {
                            db.Narudzba.Remove(selektiranaNarudzba);
                            db.SaveChanges();
                        }
                        else
                        {
                            MessageBox.Show("Nije moguće obrisati narudzbu koja je zaprimljena");
                        }
                    }
                    PrikaziNarudzbe();
                }
            }
        }

        private void dataGridViewNarudzbe_SelectionChanged(object sender, EventArgs e)
        {
            PrikaziRobu(narudzbaBindingSource.Current as Narudzba);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            selektiranaNarudzba = narudzbaBindingSource.Current as Narudzba;
            if(selektiranaNarudzba != null)
            {
                using (var db = new TBP_BazeEntities())
                {
                    db.Narudzba.Attach(selektiranaNarudzba);
                    selektiranaNarudzba.zaprimljeno = 1;
                    db.SaveChanges();
                }
                MessageBox.Show("narudžba zaprmiljena");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            selektiranaNarudzba = narudzbaBindingSource.Current as Narudzba;
            if(selektiranaNarudzba != null)
            {
                NarudzbaIzmjeniForm narudzbaForm = new NarudzbaIzmjeniForm(selektiranaNarudzba);
                narudzbaForm.ShowDialog();
                PrikaziNarudzbe();
            }
        }
    }
}
