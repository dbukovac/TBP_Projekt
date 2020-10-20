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
    public partial class RobaUnosForm : Form
    {
        Roba selektiranaRoba = null;

        public RobaUnosForm()
        {
            InitializeComponent();
        }

        public RobaUnosForm(Roba rob)
        {
            InitializeComponent();
            selektiranaRoba = rob;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new TBP_BazeEntities())
            {
                if(selektiranaRoba == null)
                {
                    Roba novaRoba = new Roba
                    {
                        naziv = textBoxNaziv.Text,
                        cijena_skladistenja = numCS.Value,
                        cijena_jedne_nabave = numCJD.Value,
                        trajanje_dostave = (int)numTD.Value,
                        min_kolicina = (int)numMK.Value,
                        potraznja = (int)numP.Value,
                        trenutna_kolicina = 0,
                        datum = DateTime.Now.Date
                    };
                    db.Roba.Add(novaRoba);
                }
                else
                {
                    db.Roba.Attach(selektiranaRoba);
                    selektiranaRoba.naziv = textBoxNaziv.Text;
                    selektiranaRoba.trajanje_dostave = (int) numTD.Value;
                    selektiranaRoba.min_kolicina = (int)numMK.Value;
                    selektiranaRoba.cijena_jedne_nabave = numCJD.Value;
                    selektiranaRoba.cijena_skladistenja = numCS.Value;
                    selektiranaRoba.potraznja = (int)numP.Value;
                }
                if(textBoxNaziv.Text != "" && numCJD.Value > 0 && numCS.Value > 0 && numMK.Value > 0 && numP.Value > 0 && numTD.Value > 0)
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

        private void RobaUnosForm_Load(object sender, EventArgs e)
        {
            if (selektiranaRoba != null)
            {
                textBoxNaziv.Text = selektiranaRoba.naziv;
                numCJD.Value = selektiranaRoba.cijena_jedne_nabave;
                numCS.Value = selektiranaRoba.cijena_skladistenja;
                numMK.Value = selektiranaRoba.min_kolicina;
                numTD.Value = selektiranaRoba.trajanje_dostave;
                numP.Value = selektiranaRoba.potraznja;
            }
        }
    }
}
