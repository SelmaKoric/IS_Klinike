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
    public partial class OboljenjaUredi : Form
    {
        private DBContext db = Baza.baza;
        private Pacijenti Pacijent;

        public OboljenjaUredi()
        {
            InitializeComponent();
        }

        public OboljenjaUredi(Pacijenti pacijent) : this()
        {
            Pacijent = pacijent;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMinimiye_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            KartonOboljenja karton = new KartonOboljenja
            {
                Dijagnoza = txtDijagnoza.Text,
                ŠifraPoMKB = txtSifraPoMKB.Text,
                DatumTerapije = dtpDatumTerapije.Value,
                VrstaTerapije = txtVrstaTerapije.Text,
                VrijemeTerapije = txtVrijemeTerapije.Text,
                Uputnica = txtUputnica.Text,
                NesposobnostZaRadDo = dtpNesposobnZaRadDo.Value,
                NesposobnostZaRadOd = dtpNesposobnostZaRadOd.Value,
                DatumPosjetePonovne = dtpPosjetaPonovna.Value,
                DatumPosjetePrve = dtpPosjetaPrva.Value,
                Pacijenti=Pacijent
            };
            db.KartonOboljenja.Add(karton);
            db.SaveChanges();
            MessageBox.Show("Uspješno sačuvano!");

            Close();
        }

        private void OboljenjaUredi_Load(object sender, EventArgs e)
        {
            lblImePrezimePacijenta.Text = Pacijent.ImePrezime;
            txtBrojKartona.Text = Pacijent.BrojKartona.ToString();
            txtDatumOtvaranja.Text = Pacijent.DatumPrvogPrijema.ToShortDateString();
        }
    }
}
