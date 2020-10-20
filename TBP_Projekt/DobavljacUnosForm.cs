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
    public partial class DobavljacUnosForm : Form
    {
        Dobavljac odabraniDobavljac = null;

        public DobavljacUnosForm()
        {
            InitializeComponent();
        }

        public DobavljacUnosForm(Dobavljac dob)
        {
            InitializeComponent();
            odabraniDobavljac = dob;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new TBP_BazeEntities())
            {
                if(odabraniDobavljac == null)
                {
                    Dobavljac noviDobavljac = new Dobavljac
                    {
                        naziv = textBoxNaziv.Text
                    };
                    db.Dobavljac.Add(noviDobavljac);
                }
                else
                {
                    db.Dobavljac.Attach(odabraniDobavljac);
                    odabraniDobavljac.naziv = textBoxNaziv.Text;
                }
                if(textBoxNaziv.Text != "")
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

        private void DobavljacUnosForm_Load(object sender, EventArgs e)
        {
            if(odabraniDobavljac != null)
            {
                textBoxNaziv.Text = odabraniDobavljac.naziv;
            }
        }
    }
}
