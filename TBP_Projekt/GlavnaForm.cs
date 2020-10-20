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
    public partial class GlavnaForm : Form
    {
        delegate void ShowFormDelegate(Form form, Form parentForm);

        private Zaposlenik logirani_korisnik;

        public GlavnaForm(Zaposlenik kor)
        {
            InitializeComponent();
            logirani_korisnik = kor;
        }

        private void GlavnaForm_Load(object sender, EventArgs e)
        {
            if (logirani_korisnik.pozicija == "admin")
            {
                korisniciToolStripMenuItem.Visible = true;
            }
        }

        private void ShowForm(Form form, Form parentForm)
        {
            if (form.InvokeRequired)
            {
                ShowFormDelegate showFormDelegate = new ShowFormDelegate(ShowForm);
                form.BeginInvoke(showFormDelegate, form, parentForm);
            }
            else
            {
                form.MdiParent = parentForm;
                parentForm.Size = new Size(form.Width, form.Height);
                form.WindowState = FormWindowState.Maximized;
                form.Show();
            }
        }

        private void odjavaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void robaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RobaPregledForm robaForm = new RobaPregledForm();
            ShowForm(robaForm, this);
        }

        private void korisniciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZaposleniciPregledForm zaposleniciForm = new ZaposleniciPregledForm();
            ShowForm(zaposleniciForm, this);
        }

        private void dobavljacToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DobavljacPregledForm dobavljacForm = new DobavljacPregledForm();
            ShowForm(dobavljacForm, this);
        }

        private void proizvodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProizvodPregledForm proizvodForm = new ProizvodPregledForm();
            ShowForm(proizvodForm, this);
        }

        private void narudžbeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NarudzbePregledForm narudzbaForm = new NarudzbePregledForm(logirani_korisnik);
            ShowForm(narudzbaForm, this);
        }

        private void radniNalogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RadniNalogPregledForm radniNalogForm = new RadniNalogPregledForm(logirani_korisnik);
            ShowForm(radniNalogForm, this);
        }
    }
}
