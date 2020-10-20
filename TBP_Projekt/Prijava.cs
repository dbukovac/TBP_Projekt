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
    public partial class Prijava : Form
    {
        public Prijava()
        {
            InitializeComponent();
        }

        private void buttonPrijaviSe_Click(object sender, EventArgs e)
        {
            Zaposlenik logirani_korisnik = null;

            using (var db = new TBP_BazeEntities())
            {
                List<Zaposlenik> listaKorisnika = new List<Zaposlenik>(db.Zaposlenik.ToList());
                foreach (var kor in listaKorisnika)
                {
                    if (kor.idZaposlenik == int.Parse(textboxSifra.Text))
                    {
                        if(int.TryParse(textBoxLozinka.Text, out int number) == true)
                        {
                            if (kor.lozinka == number)
                                logirani_korisnik = kor;
                        }
                    }
                }
            }
            if (logirani_korisnik != null)
            {
                GlavnaForm forma = new GlavnaForm(logirani_korisnik);
                this.Hide();
                forma.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Neuspješna prijava");
            }
        }
    }
}
