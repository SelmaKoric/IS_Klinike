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
    public partial class Oboljenja_Pacijent : Form
    {
        private Pacijenti _pacijent;
        private DBContext db = Baza.baza;
        int br1 = 0, br2 = 0;

        public Oboljenja_Pacijent(Pacijenti pacijent)
        {
            _pacijent = pacijent;
            InitializeComponent();

            oboljenjaToolStripMenuItem.BackColor = Color.DarkGray;
            dgvDatumiPosjete.AutoGenerateColumns = false;
            dgvNesposobnostZaRad.AutoGenerateColumns = false;
            dgvOboljenja.AutoGenerateColumns = false;
            dgvDatumiPosjete.Hide();
            dgvNesposobnostZaRad.Hide();

        }

        private void Oboljenja_Pacijent_Load(object sender, EventArgs e)
        {
            lblImePrezime.Text = _pacijent.ImePrezime;

            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            var podaci = db.KartonOboljenja.Where(karton => karton.Pacijenti.Id == _pacijent.Id).ToList();

            try
            {
                dgvDatumiPosjete.DataSource = null;
                dgvDatumiPosjete.DataSource = podaci;
                dgvNesposobnostZaRad.DataSource = null;
                dgvNesposobnostZaRad.DataSource = podaci;
                dgvOboljenja.DataSource = null;
                dgvOboljenja.DataSource = podaci;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}{Environment.NewLine}{ex.InnerException?.Message}");
            }


            foreach (DataGridViewRow row in dgvDatumiPosjete.Rows)
            {
                if (row.Index % 2 == 0)
                {
                    row.DefaultCellStyle.BackColor = Color.LightGray;
                }
            }
        }

        private void btnNesposobnostZaRad_Click(object sender, EventArgs e)
        {
            if (br1 % 2 == 0)
                dgvNesposobnostZaRad.Show();
            else
                dgvNesposobnostZaRad.Hide();

            br1++;
        }

        private void btnDatumiPosjete_Click(object sender, EventArgs e)
        {
            if (br2 % 2 == 0)
                dgvDatumiPosjete.Show();
            else
                dgvDatumiPosjete.Hide();

            br2++;
        }

        private void btnPocetna_Click(object sender, EventArgs e)
        {
            PrikaziFormu(new Izborna_Pacijent(_pacijent));
        }

        private void PrikaziFormu(Form form)
        {
            this.Hide();
            form.ShowDialog();
        }

        private void ličniPodaciToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ResetFormState();
            (sender as ToolStripMenuItem).BackColor = Color.DarkGray;

            PrikaziFormu(new LicniPodaci_Pacijent(_pacijent));
        }

        private void nalaziToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetFormState();
            (sender as ToolStripMenuItem).BackColor = Color.DarkGray;

            PrikaziFormu(new Nalazi_Pacijent(_pacijent));
        }

        private void datumiPosjeteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetFormState();
            (sender as ToolStripMenuItem).BackColor = Color.DarkGray;

            PrikaziFormu(new DatumiPosjeta_Pacijent(_pacijent));
        }

        private void preventivneMjereToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void periodičniPreglediToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetFormState();
            (sender as ToolStripMenuItem).BackColor = Color.DarkGray;

            PrikaziFormu(new PeriodicniPregledi_Pacijent(_pacijent));
        }

        private void dgvOboljenja_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ResetFormState()
        {
            foreach (ToolStripMenuItem item in menuStrip1.Items)
            {
                item.BackColor = Color.LightGray;
            }
        }
    }
}
