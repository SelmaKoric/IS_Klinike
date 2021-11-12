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
    public partial class DatumiPosjeta_Pacijent : Form
    {
        private Pacijenti _pacijent;
        private DBContext db = Baza.baza;

        public DatumiPosjeta_Pacijent(Pacijenti pacijent)
        {
            _pacijent = pacijent;
            InitializeComponent();
            datumiPosjeteToolStripMenuItem.BackColor = Color.LightGray;
            dgvDatumiPosjete.AutoGenerateColumns = false;
            dgvDatumiPosjete.RowTemplate.Resizable = DataGridViewTriState.True;
            dgvDatumiPosjete.RowTemplate.Height = 35;
        }

        private void DatumiPosjeta_Pacijent_Load(object sender, EventArgs e)
        {
            lblImePrezime.Text = _pacijent.ImePrezime;


            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            var podaci = db.KartonDatumiPosjeta.Where(karton => karton.Pacijenti.Id == _pacijent.Id).ToList();

            try
            {
                dgvDatumiPosjete.DataSource = null;
                dgvDatumiPosjete.DataSource = podaci;
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

        private void ličniPodaciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetFormState();
            (sender as ToolStripMenuItem).BackColor = Color.DarkGray;

            PrikaziFormu(new LicniPodaci_Pacijent(_pacijent));
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

        private void btnPocetna_Click(object sender, EventArgs e)
        {
            PrikaziFormu(new Izborna_Pacijent(_pacijent));
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

        private void dgvDatumiPosjete_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
