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
    public partial class IzdataUvjerenja_Pacijent : Form
    {
        private Pacijenti _pacijent;
        private DBContext db = Baza.baza;

        public IzdataUvjerenja_Pacijent(Pacijenti pacijent)
        {
            _pacijent = pacijent;
            InitializeComponent();
            IzdataUvjerenjaToolStripMenuItem.BackColor = Color.DarkGray;
            dgvRadnaSposobnost.AutoGenerateColumns = false;
            dgvRadnaSposobnost.RowTemplate.Resizable = DataGridViewTriState.True;
            dgvRadnaSposobnost.RowTemplate.Height = 35;
        }

        private void IzdataUvjerenja_Pacijent_Load(object sender, EventArgs e)
        {
            lblImePrezime.Text = _pacijent.ImePrezime;

            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            var podaci = db.KartonIzdataUvjerenja.Where(karton => karton.Pacijent.Id == _pacijent.Id).ToList();

            try
            {
                dgvRadnaSposobnost.DataSource = null;
                dgvRadnaSposobnost.DataSource = podaci;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}{Environment.NewLine}{ex.InnerException?.Message}");
            }


            foreach (DataGridViewRow row in dgvRadnaSposobnost.Rows)
            {
                if (row.Index % 2 == 0)
                {
                    row.DefaultCellStyle.BackColor = Color.Gray;
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

        private void btnPocetna_Click(object sender, EventArgs e)
        {
            PrikaziFormu(new Izborna_Pacijent(_pacijent));
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

        private void datumiPosjeteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetFormState();
            (sender as ToolStripMenuItem).BackColor = Color.DarkGray;

            PrikaziFormu(new DatumiPosjeta_Pacijent(_pacijent));
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

        private void dgvRadnaSposobnost_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
