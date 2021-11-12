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
    public partial class LicniPodaci_Pacijent : Form
    {
        private DBContext db = Baza.baza;
        private Pacijenti _pacijent;

        public LicniPodaci_Pacijent(Pacijenti pacijent)
        {
            _pacijent = pacijent;
            InitializeComponent();
            ličniPodaciToolStripMenuItem.BackColor = Color.DarkGray;
            dgvLicniPodaci.AutoGenerateColumns = false;
            dgvZdravstvenoStanje.AutoGenerateColumns = false;
        }

        private void LicniPodaci_Pacijent_Load(object sender, EventArgs e)
        {
            lblImePrezime.Text = _pacijent.ImePrezime;
            UcitajPodatke();

        }

        private void UcitajPodatke()
        {
            var podaci = db.KartonLicniPodaci.Where(karton => karton.Pacijenti.Id == _pacijent.Id).ToList();
            dgvLicniPodaci.DataSource = null;
            dgvLicniPodaci.DataSource = podaci;
            dgvZdravstvenoStanje.DataSource = null;
            dgvZdravstvenoStanje.DataSource = podaci;

            var podatak = podaci[0];

            rtbKomisija.Text = podatak.MisljenjeKomisije;
            rtbRadnaOrganizacija.Text = podatak.RadnaOrganizacijaNaziv;
            rtbRegistarskiBroj.Text = podatak.RegBrSifraDjelatnosti;
        }

        private void ResetFormState()
        {

            foreach (ToolStripMenuItem item in menuStrip1.Items)
            {
                item.BackColor = Color.LightGray;
            }

        }
        
        private void PrikaziFormu(Form form)
        {
            this.Hide();
            form.ShowDialog();
        }

        private void btnPocetna_Click(object sender, EventArgs e)
        {
            PrikaziFormu(new Izborna_Pacijent(_pacijent));
        }

        private void oboljenjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetFormState();
            (sender as ToolStripMenuItem).BackColor = Color.DarkGray;

            PrikaziFormu(new Oboljenja_Pacijent(_pacijent));
        }

        private void nalaziToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetFormState();
            (sender as ToolStripMenuItem).BackColor = Color.DarkGray;

            PrikaziFormu(new Nalazi_Pacijent(_pacijent));
        }

        private void periodičniPreglediToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetFormState();
            (sender as ToolStripMenuItem).BackColor = Color.DarkGray;

            PrikaziFormu(new PeriodicniPregledi_Pacijent(_pacijent));
        }

        private void IzdataUvjerenjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetFormState();
            (sender as ToolStripMenuItem).BackColor = Color.DarkGray;

            PrikaziFormu(new IzdataUvjerenja_Pacijent(_pacijent));
        }

        private void preventivneMjereToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ResetFormState();
            (sender as ToolStripMenuItem).BackColor = Color.DarkGray;

            PrikaziFormu(new PreventivneMjere_Pacijent(_pacijent));
        }

        private void drugeUstanoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetFormState();
            (sender as ToolStripMenuItem).BackColor = Color.DarkGray;

            PrikaziFormu(new DrugeUstanove_Pacijent(_pacijent));
        }

        private void datumiPosjeteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetFormState();
            (sender as ToolStripMenuItem).BackColor = Color.DarkGray;

            PrikaziFormu(new DatumiPosjeta_Pacijent(_pacijent));
        }
    }
}
