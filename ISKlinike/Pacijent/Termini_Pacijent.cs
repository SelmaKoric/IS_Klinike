using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ISKlinike.Model;
using ISKlinike.Pacijent;

namespace ISKlinike
{
    public partial class Termini_Pacijent : Form
    {
        private Pacijenti _pacijent;
        private DBContext db = Baza.baza;
        public Termini_Pacijent(Pacijenti pacijent)
        {
            _pacijent = pacijent;
            InitializeComponent();
            dgvTermini.AutoGenerateColumns = false;
            dgvTermini.RowTemplate.Resizable = DataGridViewTriState.True;
            dgvTermini.RowTemplate.Height = 35;
        }

        private void Termini_Pacijent_Load(object sender, EventArgs e)
        {

            UcitajPodatke();

        }

        private void UcitajPodatke(List<TerminPregleda> lista = null)
        {
            var podaci = db.TerminPregleda.Where(karton => karton.Pacijent.Id == _pacijent.Id).ToList();
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

        private void PrikaziFormu(Form form)
        {
            this.Hide();
            form.ShowDialog();
        }
        private void btnNoviTermin_Click(object sender, EventArgs e)
        {
            PrikaziFormu(new NoviTermin_Pacijent(_pacijent));
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            PrikaziFormu(new Izborna_Pacijent(_pacijent));
        }

        private void btnMinimiye_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            var filter = txtPretraga.Text;
            List<TerminPregleda> rezultat = new List<TerminPregleda>();
            //var rezultat = db.TerminPregleda.Where(karton => karton.Doktor.Ime.ToLower().Contains(filter.ToLower()) || karton.Doktor.Prezime.ToLower().Contains(filter.ToLower())).ToList();
            foreach (var doktor in db.TerminPregleda.ToList())
            {
                if (doktor.Doktor.ImePrezime.Contains(filter))
                    rezultat.Add(doktor);
            }

            UcitajPodatke(rezultat);
        }

        private void dtpPretraga_ValueChanged(object sender, EventArgs e)
        {
            List<TerminPregleda> rezultat = new List<TerminPregleda>();
            foreach (var p in db.TerminPregleda.ToList())
            {
                if (p.DatumVrijemePregleda.Date == dtpPretraga.Value.Date)
                {
                    rezultat.Add(p);
                   
                }
                UcitajPodatke(rezultat);
            }
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
