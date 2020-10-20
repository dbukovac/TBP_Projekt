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
    public partial class ZaposleniciPregledForm : Form
    {
        Zaposlenik selektiraniZaposlenik = null;

        public ZaposleniciPregledForm()
        {
            InitializeComponent();
        }

        private void buttonNovi_Click(object sender, EventArgs e)
        {
            ZaposleniciUnosForm noviZaposlenik = new ZaposleniciUnosForm();
            noviZaposlenik.ShowDialog();
            PrikaziZaposlenike();
        }

        private void ZaposleniciPregledForm_Load(object sender, EventArgs e)
        {
            PrikaziZaposlenike();
        }

        private void PrikaziZaposlenike()
        {
            dataGridView1.Rows.Clear();
            BindingList<Zaposlenik> listaZaposlenika = null;
            using (var db = new TBP_BazeEntities())
            {
                listaZaposlenika = new BindingList<Zaposlenik>(db.Zaposlenik.ToList());

            }
            zaposlenikBindingSource.DataSource = listaZaposlenika;
        }

        private void buttonBriši_Click(object sender, EventArgs e)
        {
            selektiraniZaposlenik = zaposlenikBindingSource.Current as Zaposlenik;
            if (selektiraniZaposlenik != null)
            {
                if (MessageBox.Show("Da li ste sigurni?", "Upozorenje!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    using (var db = new TBP_BazeEntities())
                    {
                        db.Zaposlenik.Attach(selektiraniZaposlenik);
                        if (selektiraniZaposlenik.Narudzba.Count == 0 && selektiraniZaposlenik.Radni_nalog.Count == 0)
                        {
                            db.Zaposlenik.Remove(selektiraniZaposlenik);
                            db.SaveChanges();
                        }
                        else
                        {
                            MessageBox.Show("Nije moguće obrisati zaposlenika koji se koristi");
                        }
                    }
                    PrikaziZaposlenike();
                }
            }
        }

        private void buttonIzmjena_Click(object sender, EventArgs e)
        {
            selektiraniZaposlenik = zaposlenikBindingSource.Current as Zaposlenik;
            ZaposleniciUnosForm noviZaposlenik = new ZaposleniciUnosForm(selektiraniZaposlenik);
            noviZaposlenik.ShowDialog();
            PrikaziZaposlenike();
        }
    }
}
