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
    public partial class RadniNalogUnosForm : Form
    {
        BindingList<ProizvodSaKolicinom> listaDodanih = new BindingList<ProizvodSaKolicinom>();
        Zaposlenik logirani_korisnik;
        public RadniNalogUnosForm(Zaposlenik zap)
        {
            InitializeComponent();
            logirani_korisnik = zap;
        }

        private void RadniNalogUnosForm_Load(object sender, EventArgs e)
        {
            PrikaziProizvode();
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

        private void button2_Click(object sender, EventArgs e)
        {
            ProizvodSaKolicinom selektiraniProizvod = new ProizvodSaKolicinom(proizvodBindingSource.Current as Proizvod, int.Parse(numKolicina.Value.ToString()));
            if (!listaDodanih.Any(item => item.idProizvod == selektiraniProizvod.idProizvod))
                listaDodanih.Add(selektiraniProizvod);

            dataGridView1.DataSource = listaDodanih;
            dataGridView1.AutoGenerateColumns = true;
        }

        private void ProvjeraKolicine(List<int> idProizvodi)
        {
            List<Proizvod_has_Roba> proizvodi = null;
            List<Roba> listaRobe = new List<Roba>();
            using (var db = new TBP_BazeEntities())
            {
                proizvodi = new List<Proizvod_has_Roba>(db.Proizvod_has_Roba.ToList());
                foreach (int id in idProizvodi)
                {
                    foreach (Proizvod_has_Roba p in proizvodi)
                    {
                        if (p.Proizvod_idProizvod == id)
                        {
                            listaRobe.Add(p.Roba);
                        }
                    }
                }
            }
            
            string upozorenje = "";
            bool upozori = false;
            foreach(Roba r in listaRobe)
            {
                if(r.trenutna_kolicina <= r.min_kolicina)
                {
                    upozorenje += "Robu " + r.naziv + " treba naručiti. \r\n";
                    upozori = true;
                }
            }
            upozorenje += "Želite li naručiti robu sada?";

            if(upozori == true)
            {
                if (MessageBox.Show(upozorenje, "Upozorenje!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    NarudzbePregledForm narudzbaForm = new NarudzbePregledForm(logirani_korisnik);
                    narudzbaForm.ShowDialog();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<int> listaIdProizvoda = new List<int>();

            using (var db = new TBP_BazeEntities())
            {
                Radni_nalog noviRadni_nalog = new Radni_nalog
                {
                    datum = DateTime.Now.Date,
                    Zaposlenik_idZaposlenik = logirani_korisnik.idZaposlenik,
                    opis = textBox1.Text
                };
                db.Radni_nalog.Add(noviRadni_nalog);
                Radni_nalog_has_Proizvod noviHasRoba = null;
                foreach (ProizvodSaKolicinom proizvod in listaDodanih)
                {
                    noviHasRoba = new Radni_nalog_has_Proizvod
                    {
                        Proizvod_idProizvod = proizvod.idProizvod,
                        Radni_nalog_idRadni_nalog = noviRadni_nalog.idRadni_nalog,
                        kolicina = proizvod.kolicina
                    };
                    db.Radni_nalog_has_Proizvod.Add(noviHasRoba);
                    /*if(!listaIdProizvoda.Contains(proizvod.IdProizvod))
                        listaIdProizvoda.Add(proizvod.IdProizvod);*/
                    if (!listaIdProizvoda.Any(item => item == proizvod.IdProizvod))
                        listaIdProizvoda.Add(proizvod.IdProizvod);
                }
                if(listaDodanih.Count > 0)
                {
                    try
                    {
                        db.SaveChanges();
                        MessageBox.Show("Unos je uspješan");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Nedovoljna količina traženog materijala");
                    }
                }
                else
                {
                    MessageBox.Show("Krivi parametri za unos!");
                }
            }
            ProvjeraKolicine(listaIdProizvoda);
        }
    }
}
