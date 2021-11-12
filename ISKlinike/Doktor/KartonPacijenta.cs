using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISKlinike
{

    public partial class KartonPacijenta : Form
    {
        private DBContext db = Baza.baza;
        private Pacijenti Pacijent;

        OboljenjaPacijenta oboljenja;
        FormaLičniPodaci licniPodaci;
        NalaziPacijenta nalazi;
        PeriodicniPregledi preglediPer;
        IzdataUvjerenja uvjerenja;
        PreventivneMjere mjere;
        DrugeUstanove ustanove;
        DatumiPosjeta posjete;

        public KartonPacijenta(Pacijenti pacijent)
        {
            InitializeComponent();

            this.Pacijent = pacijent;

            oboljenja = new OboljenjaPacijenta(pacijent);
            licniPodaci = new FormaLičniPodaci(pacijent);
            nalazi = new NalaziPacijenta(pacijent);
            preglediPer = new PeriodicniPregledi(pacijent);
            uvjerenja = new IzdataUvjerenja(pacijent);
            mjere = new PreventivneMjere(pacijent);
            ustanove = new DrugeUstanove(pacijent);
            posjete = new DatumiPosjeta(pacijent);
            

            btnLičniPodaci.PerformClick();
        }

        private void KartonPacijenta_Load(object sender, EventArgs e)
        {
            lblImePrezimePacijenta.Text = Pacijent.ImePrezime;
            txtBrojKartona.Text = Pacijent.BrojKartona.ToString();
            txtDatumOtvaranja.Text = Pacijent.DatumPrvogPrijema.ToShortDateString();
        }
        private void ResetFormState()
        {
            oboljenja.Hide();
            nalazi.Hide();
            licniPodaci.Hide();
            preglediPer.Hide();
            uvjerenja.Hide();
            mjere.Hide();
            ustanove.Hide();
            posjete.Hide();

            foreach (ToolStripMenuItem item in menuStrip1.Items)
            {
                item.BackColor = Color.LightGray;
            }
            
        }
        private void ShowChildForm(Form frm)
        {
            frm.MdiParent = this;
            frm.Location = new Point(30, 140);

            frm.Show();
        }

        private void btnLičniPodaci_Click_1(object sender, EventArgs e)
        {
            ResetFormState();
            (sender as ToolStripMenuItem).BackColor = Color.Red;
            // 40, 140);
            ShowChildForm(licniPodaci);
        }


        private void oboljenjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetFormState();
            (sender as ToolStripMenuItem).BackColor = Color.Red;

            ShowChildForm(oboljenja);
        }

        private void nalaziToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetFormState();
            (sender as ToolStripMenuItem).BackColor = Color.Red;

            ShowChildForm(nalazi);
        }


        private void periodičniPreglediToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetFormState();
            (sender as ToolStripMenuItem).BackColor = Color.Red;

            ShowChildForm(preglediPer);
        }

        private void preventivneMjereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetFormState();
            (sender as ToolStripMenuItem).BackColor = Color.Red;
            ShowChildForm(mjere);
        }

        private void drugeUstanoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetFormState();
            (sender as ToolStripMenuItem).BackColor = Color.Red;
            ShowChildForm(ustanove);
        }

        private void ispisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetFormState();
            (sender as ToolStripMenuItem).BackColor = Color.Red;
            ShowChildForm(posjete);
        }

        private void btnIzdataUvjerenja_Click_1(object sender, EventArgs e)
        {
            ResetFormState();
            (sender as ToolStripMenuItem).BackColor = Color.Red;
            ShowChildForm(uvjerenja);
        }
    }
}
