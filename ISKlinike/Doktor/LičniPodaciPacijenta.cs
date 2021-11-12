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
    public partial class LičniPodaciPacijenta : Form
    {
        private DBContext db = Baza.baza;
        private Pacijenti Pacijent;
        private KartonLicniPodaci podaci;

        public LičniPodaciPacijenta()
        {
            InitializeComponent();
            
        }

        public LičniPodaciPacijenta(Pacijenti pacijent) : this()
        {
            this.Pacijent = pacijent;

            podaci = db.KartonLicniPodaci
                .Where(karton => karton.Pacijenti.Id == Pacijent.Id)
                .FirstOrDefault();

            if (podaci != null)
            {
                txtImePrezime.Text = podaci.ImePrezime;
                txtSpol.Text = podaci.Spol;
                txtDatumRodjenja.Text = podaci.DatumRodjenja;

                txtPrebivaliste.Text = podaci.Prebivalište;
                txtJMBG.Text = podaci.JMBG;
                txtKrvnaGrupa.Text = podaci.KrvnaGrupa;
                txtRhFaktor.Text = podaci.RhFaktor;
                txtKoagulopatije.Text = podaci.Koagulopatije;
                txtAlergican.Text = podaci.Alergičan;
                txtHronicneBolesti.Text = podaci.HroničneBolesti;
                txtRadnaOrgNaziv.Text = podaci.RadnaOrganizacijaNaziv;
                txtRegBrSifraDjelatnosti.Text = podaci.RegBrSifraDjelatnosti;
                txtMisljenjeKomisije.Text = podaci.MisljenjeKomisije;
            }
            else
                podaci = new KartonLicniPodaci();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            podaci.ImePrezime = txtImePrezime.Text;
            podaci.Spol = txtSpol.Text;
            podaci.DatumRodjenja = txtDatumRodjenja.Text;

            podaci.Prebivalište = txtPrebivaliste.Text;
            podaci.JMBG = txtJMBG.Text;
            podaci.KrvnaGrupa = txtKrvnaGrupa.Text;
            podaci.RhFaktor = txtRhFaktor.Text;
            podaci.Koagulopatije = txtKoagulopatije.Text;
            podaci.Alergičan = txtAlergican.Text;
            podaci.HroničneBolesti = txtHronicneBolesti.Text;
            podaci.RadnaOrganizacijaNaziv = txtRadnaOrgNaziv.Text;
            podaci.RegBrSifraDjelatnosti = txtRegBrSifraDjelatnosti.Text;
            podaci.MisljenjeKomisije = txtMisljenjeKomisije.Text;
            podaci.Pacijenti = Pacijent;

            if(podaci.Id == 0)
                db.KartonLicniPodaci.Add(podaci);

            db.SaveChanges();
            MessageBox.Show("Uspješno sačuvano!");

            Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMinimiye_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void LičniPodaciPacijenta_Load(object sender, EventArgs e)
        {
            lblImePrezimePacijenta.Text = Pacijent.ImePrezime;
            txtBrojKartona.Text = Pacijent.BrojKartona.ToString();
            txtDatumOtvaranja.Text = Pacijent.DatumPrvogPrijema.ToShortDateString();
        }
    }
}
