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
    public partial class ProizvodUnosForm : Form
    {
        BindingList<RobaSaKolicinom> listaDodanih = new BindingList<RobaSaKolicinom>();
        public ProizvodUnosForm()
        {
            InitializeComponent();
        }

        private void ProizvodUnosForm_Load(object sender, EventArgs e)
        {
            PrikaziRobu();
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
                Proizvod noviProizvod = new Proizvod
                {
                    naziv = textBoxNaziv.Text,
                    datum = DateTime.Now.Date
                };
                db.Proizvod.Add(noviProizvod);
                Proizvod_has_Roba noviHasRoba = null;
                foreach (RobaSaKolicinom roba in listaDodanih)
                {
                    noviHasRoba = new Proizvod_has_Roba
                    {
                        Roba_idRoba = roba.idRoba,
                        Proizvod_idProizvod = noviProizvod.idProizvod,
                        kolicina = roba.kolicina
                    };
                    db.Proizvod_has_Roba.Add(noviHasRoba);
                }
                if(textBoxNaziv.Text != "" && listaDodanih.Count > 0 && numKolicina.Value > 0)
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
    }
}
