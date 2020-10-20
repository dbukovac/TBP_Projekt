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
    public partial class RadniNalogIzmjenaForm : Form
    {
        Radni_nalog odabraniNalog = null;

        public RadniNalogIzmjenaForm(Radni_nalog rad)
        {
            InitializeComponent();
            odabraniNalog = rad;
        }

        private void buttonNovi_Click(object sender, EventArgs e)
        {
            using (var db = new TBP_BazeEntities())
            {
                db.Radni_nalog.Attach(odabraniNalog);
                odabraniNalog.opis = textBox1.Text;
                db.SaveChanges();
            }
            MessageBox.Show("Uspješno izmjenjen opis");
        }

        private void RadniNalogIzmjenaForm_Load(object sender, EventArgs e)
        {
            textBox1.Text = odabraniNalog.opis;
        }
    }
}
