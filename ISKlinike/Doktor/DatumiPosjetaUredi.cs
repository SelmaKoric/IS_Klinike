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
    public partial class DatumiPosjetaUredi : Form
    {
        private Pacijenti Pacijent;
        private DBContext db = Baza.baza;

        public DatumiPosjetaUredi()
        {
            InitializeComponent();
        }

        public DatumiPosjetaUredi(Pacijenti pacijent):this()
        {
            Pacijent = pacijent;
        }

        private void DatumiPosjeta_Load(object sender, EventArgs e)
        {
            lblImePrezimePacijenta.Text = Pacijent.ImePrezime;
            txtBrojKartona.Text = Pacijent.BrojKartona.ToString();
            txtDatumOtvaranja.Text = Pacijent.DatumPrvogPrijema.ToShortDateString();

            txtImeLjekara.Text += LoginForm.LogiraniKorisnik.ImePrezime;

        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            KartonDatumiPosjeta datumPosjete = new KartonDatumiPosjeta
            {
                DatumPosjete = dtpDatumPosjete.Value,
                VrijemePosjete = dtpVrijemePrijema.Value,
                EvidentiraoZaposleni = txtImeLjekara.Text,
                Pacijenti = Pacijent
            };
            db.KartonDatumiPosjeta.Add(datumPosjete);
            db.SaveChanges();
            MessageBox.Show("Uspješno sačuvano!");
            Close();
        }

        private void txtImeLjekara_TextChanged(object sender, EventArgs e)
        {

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
