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
    public partial class PreventivneMjereUredi : Form
    {
        private Pacijenti Pacijent;
        private DBContext db = Baza.baza;
        public PreventivneMjereUredi()
        {
            InitializeComponent();
        }

        public PreventivneMjereUredi(Pacijenti pacijent):this()
        {
            Pacijent = pacijent;
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            KartonPreventivneMjere mjere = new KartonPreventivneMjere
            {
                DatumPregleda = dtpDatumPregleda.Value,
                PreventivniPregled = rtbPrevPregled.Text,
                Pacijent = Pacijent
            };
            db.KartonPreventivneMjere.Add(mjere);
            db.SaveChanges();
            MessageBox.Show("Uspješno sačuvano!");

            Close();
        }

        private void PreventivneMjereUredi_Load(object sender, EventArgs e)
        {
            lblImePrezimePacijenta.Text = Pacijent.ImePrezime;
            txtBrojKartona.Text = Pacijent.BrojKartona.ToString();
            txtDatumOtvaranja.Text = Pacijent.DatumPrvogPrijema.ToShortDateString();
        }

        private void btnMinimiye_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
