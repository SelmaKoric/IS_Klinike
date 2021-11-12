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
    public partial class Nalazi_Pacijent : Form
    {
        private Pacijenti _pacijent;
        private DBContext db = Baza.baza;
        private bool buttonClickedLicna;
        private bool buttonClickedPorodicna;
        private bool buttonClickedRadna;

        public Nalazi_Pacijent(Pacijenti pacijent)
        {
            _pacijent = pacijent;
            InitializeComponent();
            nalaziToolStripMenuItem.BackColor = Color.DarkGray;
        }

        private void Nalazi_Pacijent_Load(object sender, EventArgs e)
        {
            lblImePrezime.Text = _pacijent.ImePrezime;
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

        private void ResetFormState()
        {
            foreach (ToolStripMenuItem item in menuStrip1.Items)
            {
                item.BackColor = Color.LightGray;
            }
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

        private void btnLicnaAnamneza_Click(object sender, EventArgs e)
        {
            var nalazi = db.KartonNalazi.Where(x => x.Pacijenti.Id == _pacijent.Id).ToList();
            foreach (var nalaz in nalazi)
            {
                if (nalaz.DatumIzmjene.Date == dtpDatumPregleda.Value.Date)
                {
                    rtbAnamneza.Text = nalaz.LicnaAnamneza;
                    return;
                }
            }

            buttonClickedLicna = true;
            rtbAnamneza.Text = "";
        }

        private void btnPorodcnaAnamneza_Click(object sender, EventArgs e)
        {
            var nalazi = db.KartonNalazi.Where(x => x.Pacijenti.Id == _pacijent.Id).ToList();
            foreach (var nalaz in nalazi)
            {
                if (nalaz.DatumIzmjene.Date == dtpDatumPregleda.Value.Date)
                {
                    rtbAnamneza.Text = nalaz.PorodicnaAnamneza;
                    return;
                }
            }

            buttonClickedPorodicna = true;
            rtbAnamneza.Text = "";
        }

        private void btnRadnaAnamneza_Click(object sender, EventArgs e)
        {
            var nalazi = db.KartonNalazi.Where(x => x.Pacijenti.Id == _pacijent.Id).ToList();
            foreach (var nalaz in nalazi)
            {
                if (nalaz.DatumIzmjene.Date == dtpDatumPregleda.Value.Date)
                {
                    rtbAnamneza.Text = nalaz.RadnaAnamneza;
                    return;
                }
            }
            buttonClickedRadna = true;
            rtbAnamneza.Text = "";
        }

        private void btnInfo_MouseHover(object sender, EventArgs e)
        {
            lblInfo.Text = "Klikom na dugmiće otvaraju se podaci o anamnezama u boxu ispod!";
        }

        private void btnInfo_MouseLeave(object sender, EventArgs e)
        {
            lblInfo.Text = "";

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

        private void dtpDatumPregleda_ValueChanged(object sender, EventArgs e)
        {
            var nalazi = db.KartonNalazi.Where(x => x.Pacijenti.Id == _pacijent.Id).ToList();
            foreach (var n in nalazi)
            {
                if (n.DatumIzmjene.Date == dtpDatumPregleda.Value.Date && buttonClickedLicna)
                {
                    rtbAnamneza.Text = n.LicnaAnamneza;
                    return;
                }
                else if (n.DatumIzmjene.Date == dtpDatumPregleda.Value.Date && buttonClickedPorodicna)
                {
                    dtpDatumPregleda.Text = n.PorodicnaAnamneza;
                    return;
                }
                else if (n.DatumIzmjene.Date == dtpDatumPregleda.Value.Date && buttonClickedRadna)
                {

                    rtbAnamneza.Text = n.RadnaAnamneza;
                    return;
                }
                rtbAnamneza.Text = "";
            }
        }

        private void rtbAnamneza_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
