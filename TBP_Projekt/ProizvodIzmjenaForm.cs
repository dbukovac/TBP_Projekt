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
    public partial class ProizvodIzmjenaForm : Form
    {
        Proizvod odabraniProizvod = null;

        public ProizvodIzmjenaForm(Proizvod pro)
        {
            InitializeComponent();
            odabraniProizvod = pro;
        }

        private void ProizvodIzmjenaForm_Load(object sender, EventArgs e)
        {
            textBox1.Text = odabraniProizvod.naziv;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new TBP_BazeEntities())
            {
                db.Proizvod.Attach(odabraniProizvod);
                odabraniProizvod.naziv = textBox1.Text;
                odabraniProizvod.datum = DateTime.Now.Date;
                if(textBox1.Text != "")
                {
                    db.SaveChanges();
                    MessageBox.Show("Uspješna izmjena imena");
                }
                else
                {
                    MessageBox.Show("Naziv ne može biti prazan!");
                }
            }
        }
    }
}
