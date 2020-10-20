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
    public partial class ZaposleniciUnosForm : Form
    {
        Zaposlenik odabraniZaposlenik = null;

        public ZaposleniciUnosForm()
        {
            InitializeComponent();
        }

        public ZaposleniciUnosForm(Zaposlenik zap)
        {
            InitializeComponent();
            odabraniZaposlenik = zap;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new TBP_BazeEntities())
            {
                if(odabraniZaposlenik == null)
                {
                    Zaposlenik noviZaposlenik = new Zaposlenik
                    {
                        ime = textBoxIme.Text,
                        prezime = textBoxPrezime.Text,
                        pozicija = comboBoxPozicija.Text,
                        lozinka = int.Parse(textBoxLozinka.Text)
                    };
                    db.Zaposlenik.Add(noviZaposlenik);
                }
                else
                {
                    db.Zaposlenik.Attach(odabraniZaposlenik);
                    odabraniZaposlenik.ime = textBoxIme.Text;
                    odabraniZaposlenik.prezime = textBoxPrezime.Text;
                    odabraniZaposlenik.pozicija = comboBoxPozicija.Text;
                    odabraniZaposlenik.lozinka = int.Parse(textBoxLozinka.Text);
                }
                if(textBoxIme.Text != "" && textBoxLozinka.Text != "" && textBoxPrezime.Text != "" && comboBoxPozicija.Text != "")
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

        private void ZaposleniciUnosForm_Load(object sender, EventArgs e)
        {
            if (odabraniZaposlenik != null)
            {
                textBoxIme.Text = odabraniZaposlenik.ime;
                textBoxPrezime.Text = odabraniZaposlenik.prezime;
                textBoxLozinka.Text = odabraniZaposlenik.lozinka.ToString();
                comboBoxPozicija.Text = odabraniZaposlenik.pozicija;
            }
        }
    }
}
