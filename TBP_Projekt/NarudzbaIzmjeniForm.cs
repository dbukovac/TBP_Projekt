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
    public partial class NarudzbaIzmjeniForm : Form
    {
        Narudzba odabranaNarudzba = null;

        public NarudzbaIzmjeniForm(Narudzba nar)
        {
            InitializeComponent();
            odabranaNarudzba = nar;
        }

        private void NarudzbaIzmjeniForm_Load(object sender, EventArgs e)
        {
            textBox1.Text = odabranaNarudzba.opis;
        }

        private void buttonNovi_Click(object sender, EventArgs e)
        {
            using (var db = new TBP_BazeEntities())
            {
                db.Narudzba.Attach(odabranaNarudzba);
                odabranaNarudzba.opis = textBox1.Text;
                db.SaveChanges();
            }
            MessageBox.Show("Uspješno izmjenjen opis");
        }
    }
}
