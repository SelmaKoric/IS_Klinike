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
    public partial class NalaziPacijentaUredi : Form
    {
        private DBContext db = Baza.baza;
        private Pacijenti Pacijent;

        public NalaziPacijentaUredi()
        {
            InitializeComponent();
        }

        public NalaziPacijentaUredi(Pacijenti pacijent) : this()
        {
            this.Pacijent = pacijent;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMinimiye_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void NalaziPacijntaUredi_Load(object sender, EventArgs e)
        {
            lblImePrezimePacijenta.Text = Pacijent.ImePrezime;
            txtBrojKartona.Text = Pacijent.BrojKartona.ToString();
            txtDatumOtvaranja.Text = Pacijent.DatumPrvogPrijema.ToShortDateString();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            var nalazi = db.KartonNalazi.Where(x => x.Pacijenti.Id == Pacijent.Id).ToList();
            foreach (var nalaz in nalazi)
            {
                if (nalaz.DatumIzmjene.Date == dtpDatumIzmjeneAnamneze.Value.Date)
                {
                    MessageBox.Show("Za odabrani datum je već uzeta anamneza od pacijenta.", "Greška");
                    return;
                }
            }

            KartonNalazi noviNalaz = new KartonNalazi
            {
                LicnaAnamneza = txtLicnaAnamn.Text,
                PorodicnaAnamneza = txtPorodicnaAnamn.Text,
                RadnaAnamneza = txtRadnaAnamneza.Text,
                DatumIzmjene = dtpDatumIzmjeneAnamneze.Value.Date,
                Pacijenti = Pacijent
            };
            db.KartonNalazi.Add(noviNalaz);
            db.SaveChanges();
            MessageBox.Show("Uspješno sačuvano!");

            Close();
        }
    }
}
