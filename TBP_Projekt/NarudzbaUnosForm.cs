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
    public partial class NarudzbaUnosForm : Form
    {
        Zaposlenik logirani_korisnik;
        BindingList<RobaSaKolicinom> listaDodanih = new BindingList<RobaSaKolicinom>();
        public NarudzbaUnosForm(Zaposlenik zap)
        {
            InitializeComponent();
            logirani_korisnik = zap;
        }

        private void NarudzbaUnosForm_Load(object sender, EventArgs e)
        {
            PrikaziRobu();
            PrikaziDobavljace();
        }

        private void PrikaziDobavljace()
        {
            BindingList<Dobavljac> listaDobavljaca = null;
            using (var db = new TBP_BazeEntities())
            {
                listaDobavljaca = new BindingList<Dobavljac>(db.Dobavljac.ToList());

            }
            dobavljacBindingSource.DataSource = listaDobavljaca;
        }

        private void PrikaziRobu()
        {
            dataGridViewRoba.Rows.Clear();
            BindingList<Roba> listaRoba = null;
            using (var db = new TBP_BazeEntities())
            {
                listaRoba = new BindingList<Roba>(db.Roba.ToList());

            }
            robaBindingSource.DataSource = listaRoba;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RobaSaKolicinom selektiranaRoba = new RobaSaKolicinom(robaBindingSource.Current as Roba, int.Parse(numKolicina.Value.ToString()));
            if (!listaDodanih.Any(item => item.idRoba == selektiranaRoba.idRoba))
                listaDodanih.Add(selektiranaRoba);

            dataGridView1.DataSource = listaDodanih;
            dataGridView1.AutoGenerateColumns = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new TBP_BazeEntities())
            {
                Narudzba novaNarudzba = new Narudzba
                {
                    datum = DateTime.Now.Date,
                    zaprimljeno = 0,
                    Dobavljac_idDobavljac = int.Parse(comboBox1.SelectedValue.ToString()),
                    Zaposlenik_idZaposlenik = logirani_korisnik.idZaposlenik,
                    opis = textBox1.Text
                };
                db.Narudzba.Add(novaNarudzba);
                Narudzba_has_Roba noviHasRoba = null;
                foreach (RobaSaKolicinom roba in listaDodanih)
                {
                    noviHasRoba = new Narudzba_has_Roba
                    {
                        Roba_idRoba = roba.idRoba,
                        Narudzba_idNarudzba = novaNarudzba.idNarudzba,
                        kolicina = roba.kolicina
                    };
                    db.Narudzba_has_Roba.Add(noviHasRoba);
                }
                if(listaDodanih.Count > 0)
                {
                    db.SaveChanges();
                    MessageBox.Show("Unos je uspješan");
                }
                else
                {
                    MessageBox.Show("Krivi parametri za unos!");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Roba selektiranaRoba = robaBindingSource.Current as Roba;
            int EOQ = 0;
            EOQ = (int)Math.Sqrt((2 * (double)selektiranaRoba.cijena_jedne_nabave * selektiranaRoba.potraznja)/(double)selektiranaRoba.cijena_skladistenja);
            numKolicina.Value = EOQ;
        }
    }
}
