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
    public partial class NoviTermin : Form
    {
        private Korisnik _korisnik;
        private DBContext db = Baza.baza;
        //private TerminPregleda termin;
        public NoviTermin(Korisnik korisnik)
        {
            _korisnik = korisnik;
            InitializeComponent();
        }

        private void NoviTermin_Load(object sender, EventArgs e)
        {
            cmbPacijenti.DataSource = db.Pacijenti.ToList();
            cmbPacijenti.DisplayMember = "ImePrezime";
            cmbPacijenti.ValueMember = "Id";
        }

        private void btnSačuvaj_Click(object sender, EventArgs e)
        {
            TerminPregleda termin = new TerminPregleda();
            termin.DatumVrijemePregleda = dtpPregled.Value;
            termin.Pacijent = cmbPacijenti.SelectedItem as Pacijenti;
            termin.RazlogPosjete = rtbRazlogPosjete.Text;
            termin.Doktor = _korisnik;
            db.TerminPregleda.Add(termin);
            MessageBox.Show($"Termin uspjesno dodan!");
            db.SaveChanges();

            this.Close();
            //Termini termini = new Termini(_korisnik);
            //termini.ShowDialog();
        }

        private void btnMinimiye_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            Termini termini = new Termini(_korisnik);
            termini.ShowDialog();
        }
    }
}
