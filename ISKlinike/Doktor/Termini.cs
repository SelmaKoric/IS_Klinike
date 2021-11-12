using ISKlinike.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISKlinike.Doktor
{
    public partial class Termini : Form
    {
        private DBContext db = Baza.baza;
        private Korisnik _korisnik;

        public Termini(Korisnik korisnik)
        {
            _korisnik = korisnik;
            InitializeComponent();
            dgvTermini.AutoGenerateColumns = false;
            dgvTermini.RowTemplate.Resizable = DataGridViewTriState.True;
            dgvTermini.RowTemplate.Height = 35;

        }

        private void Termini_Load(object sender, EventArgs e)
        {     
            UcitajPodatke();        
        }

        private void UcitajPodatke(List<TerminPregleda> lista = null)
        {
            var podaci = db.TerminPregleda.Where(karton => karton.Doktor.Id == _korisnik.Id).ToList();

            dgvTermini.DataSource = null;
            dgvTermini.DataSource = lista ?? podaci;

            foreach (DataGridViewRow row in dgvTermini.Rows)
            {
                if (row.Index % 2 == 0)
                {
                    row.DefaultCellStyle.BackColor = Color.LightGray;
                }
            }
        }

        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            var filter = txtPretraga.Text.ToLower();
            List<TerminPregleda> rezultat = new List<TerminPregleda>();

            foreach (var pacijent in db.TerminPregleda)
            {
                if (pacijent.Pacijent.ImePrezime.Contains(filter))
                    rezultat.Add(pacijent);
                UcitajPodatke(rezultat);
            }
        }

        private void dtpPretraga_ValueChanged(object sender, EventArgs e)
        {
            List<TerminPregleda> pretrage = db.TerminPregleda.Where(x => x.Doktor.Id == _korisnik.Id).ToList();
            List<TerminPregleda> rezultat = new List<TerminPregleda>();

            foreach (var p in pretrage)
            {
                if (p.DatumVrijemePregleda.Date == dtpPretraga.Value.Date)
                    rezultat.Add(p);
                UcitajPodatke(rezultat);
            }

        }

        private void btnMinimiye_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListaPacijenata lista = new ListaPacijenata();
            lista.ShowDialog();

        }

        private void btnNoviTermin_Click(object sender, EventArgs e)
        {
            //this.Hide();
            NoviTermin noviTermin = new NoviTermin(_korisnik);
            noviTermin.ShowDialog();
            UcitajPodatke();
        }

        private void dgvTermini_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnOcisti_Click(object sender, EventArgs e)
        {
            if (txtPretraga.ToString() != string.Empty)
            {
                txtPretraga.Text = " ";
            }
        }
    }
}
