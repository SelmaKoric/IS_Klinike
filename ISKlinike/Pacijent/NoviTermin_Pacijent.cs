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

namespace ISKlinike.Pacijent
{
    public partial class NoviTermin_Pacijent : Form
    {
        private Pacijenti _pacijent;
        private DBContext db = Baza.baza;
        //private TerminPregleda termin;
        public NoviTermin_Pacijent(Pacijenti pacijent)
        {
            _pacijent = pacijent;
            InitializeComponent();
        }

        private void NoviTermin_Pacijent_Load(object sender, EventArgs e)
        {
            cmbDoktor.DataSource = db.Korisnici.Where(karton=>karton.BrojKartona.Contains("D")).ToList();
            cmbDoktor.DisplayMember = "ImePrezime";
            cmbDoktor.ValueMember = "Id";
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            PrikaziFormu(new Termini_Pacijent(_pacijent));
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            TerminPregleda termin = new TerminPregleda();
            termin.DatumVrijemePregleda = dtpDatumVrijemePregleda.Value;
            termin.Doktor = cmbDoktor.SelectedItem as Korisnik;
            termin.RazlogPosjete = rtbRatlogPosjete.Text;
            termin.Pacijent = _pacijent;
            db.TerminPregleda.Add(termin);
            MessageBox.Show($"Termin uspjesno dodan!");
            db.SaveChanges();
            Close();
            PrikaziFormu(new Termini_Pacijent(_pacijent));

        }

        private void PrikaziFormu(Form form)
        {
            this.Hide();
            form.ShowDialog();
        }

        private void btnMinimiye_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            PrikaziFormu(new Termini_Pacijent(_pacijent));
        }
    }
}
