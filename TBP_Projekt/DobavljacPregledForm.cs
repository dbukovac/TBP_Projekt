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
    public partial class DobavljacPregledForm : Form
    {
        Dobavljac selektiraniDobavljac = null;

        public DobavljacPregledForm()
        {
            InitializeComponent();
        }

        private void buttonNovi_Click(object sender, EventArgs e)
        {
            DobavljacUnosForm dobavljacForm = new DobavljacUnosForm();
            dobavljacForm.ShowDialog();
            PrikaziDobavljace();
        }

        private void DobavljacPregledForm_Load(object sender, EventArgs e)
        {
            PrikaziDobavljace();
        }

        private void PrikaziDobavljace()
        {
            dataGridView1.Rows.Clear();
            BindingList<Dobavljac> listaDobavljaca = null;
            using (var db = new TBP_BazeEntities())
            {
                listaDobavljaca = new BindingList<Dobavljac>(db.Dobavljac.ToList());

            }
            dobavljacBindingSource.DataSource = listaDobavljaca;
        }

        private void buttonBriši_Click(object sender, EventArgs e)
        {
            selektiraniDobavljac = dobavljacBindingSource.Current as Dobavljac;
            if (selektiraniDobavljac != null)
            {
                if (MessageBox.Show("Da li ste sigurni?", "Upozorenje!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    using (var db = new TBP_BazeEntities())
                    {
                        db.Dobavljac.Attach(selektiraniDobavljac);
                        if (selektiraniDobavljac.Narudzba.Count == 0)
                        {
                            db.Dobavljac.Remove(selektiraniDobavljac);
                            db.SaveChanges();
                        }
                        else
                        {
                            MessageBox.Show("Nije moguće obrisati dobavljaca koji se koristi");
                        }
                    }
                    PrikaziDobavljace();
                }
            }
        }

        private void buttonIzmjena_Click(object sender, EventArgs e)
        {
            selektiraniDobavljac = dobavljacBindingSource.Current as Dobavljac;
            if (selektiraniDobavljac != null)
            {
                DobavljacUnosForm dobavljacForm = new DobavljacUnosForm(selektiraniDobavljac);
                dobavljacForm.ShowDialog();
                PrikaziDobavljace();
            }
        }
    }
}
