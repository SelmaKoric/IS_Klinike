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
    public partial class PeriodicniPregledi_Pacijent : Form
    {
        private Pacijenti _pacijent;
        private DBContext db = Baza.baza;

        public PeriodicniPregledi_Pacijent(Pacijenti pacijent)
        {
            _pacijent = pacijent;
            InitializeComponent();
            periodičniPreglediToolStripMenuItem.BackColor = Color.DarkGray;
        }

        private void PeriodicniPregledi_Pacijent_Load(object sender, EventArgs e)
        {
            lblImePrezime.Text = _pacijent.ImePrezime;
        }

        private void dtpDatumPregleda_ValueChanged(object sender, EventArgs e)
        {
            var pregled = db.KartonPeriodičniPregledi.Where(x => x.Pacijenti.Id == _pacijent.Id).ToList();
            foreach (var p in pregled)
            {
                if (p.DatumPregleda.Date == dtpDatumPregleda.Value.Date)
                {
                    txtAbdomen.Text = p.Abdomen;
                    txtBMI.Text = p.BMI.ToString();
                    txtCula.Text = p.Cula;
                    txtEkstremiteti.Text = p.Ekstremiteti;
                    txtGrudniKoš.Text = p.GrudniKos;
                    txtKicmeniStub.Text = p.KicmeniStub;
                    txtKoža.Text = p.PromjeneNaKozi;
                    txtKrvniPritisak.Text = p.KrvniPritisak;
                    txtObimGrudi.Text = p.ObimGrudi;
                    txtObimStruka.Text = p.ObimStruka;
                    txtPluća.Text = p.Pluca;
                    txtPuls.Value = p.Puls;
                    txtTezina.Text = p.Težina.ToString();
                    txtTonzile.Text = p.Tonzile;
                    txtUroGenOrgani.Text = p.UroGenOrgani;
                    return;
                }
                txtAbdomen.Text = "";
                txtBMI.Text = "";
                txtCula.Text = "";
                txtEkstremiteti.Text = "";
                txtGrudniKoš.Text = "";
                txtKicmeniStub.Text = "";
                txtKoža.Text = "";
                txtKrvniPritisak.Text = "";
                txtObimGrudi.Text = "";
                txtObimStruka.Text = "";
                txtPluća.Text = "";
                txtPuls.Value = default;
                txtTezina.Text = "";
                txtTonzile.Text = "";
                txtUroGenOrgani.Text = "";
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

        private void nalaziToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetFormState();
            (sender as ToolStripMenuItem).BackColor = Color.DarkGray;

            PrikaziFormu(new Nalazi_Pacijent(_pacijent));
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

        private void datumiPosjeteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetFormState();
            (sender as ToolStripMenuItem).BackColor = Color.DarkGray;

            PrikaziFormu(new DatumiPosjeta_Pacijent(_pacijent));
        }
    }
}
