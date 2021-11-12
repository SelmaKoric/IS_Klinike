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
    public partial class DrugeUstanoveUredi : Form
    {
        private Pacijenti Pacijent;
        private DBContext db = Baza.baza;

        public DrugeUstanoveUredi()
        {
            InitializeComponent();
        }

        public DrugeUstanoveUredi(Pacijenti pacijent):this()
        {
            Pacijent = pacijent;
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            KartonDrugeUstanove ustanova = new KartonDrugeUstanove()
            {
                NazivUstanove = rtbNazivUstanove.Text,
                LijecenDo = dtpLijecenDo.Value,
                LijecenOd = dtpLijecenOd.Value,
                OtpusnaDijagnoza = rtbOtpusnaDijagnoza.Text,
                Uputstvo = rtbUputstvoZaTretman.Text,
                Pacijenti=Pacijent
            };
            db.KartonDrugeUstanove.Add(ustanova);
            db.SaveChanges();
            MessageBox.Show("Uspješno sačuvano!");

            Close();
        }

        private void DrugeUstanoveUredi_Load(object sender, EventArgs e)
        {
            lblImePrezimePacijenta.Text = Pacijent.ImePrezime;
            txtBrojKartona.Text = Pacijent.BrojKartona.ToString();
            txtDatumOtvaranja.Text = Pacijent.DatumPrvogPrijema.ToShortDateString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMinimiye_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }
    }
}
