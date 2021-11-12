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
    public partial class FormaLičniPodaci : Form
    {
        private DBContext db = Baza.baza;
        private Pacijenti Pacijent;

        public FormaLičniPodaci()
        {
            InitializeComponent();
            dgvLicniPodaci.AutoGenerateColumns = false;
            dgvOpsteStanje.AutoGenerateColumns = false;
            dgvOpsteStanje.DataSource = null;
            dgvLicniPodaci.DataSource = null;
            
        }

        public FormaLičniPodaci(Pacijenti pacijent): this()
        {
            Pacijent = pacijent;

            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            var podaci = db.KartonLicniPodaci
                .Where(karton => karton.Pacijenti.Id == Pacijent.Id)
                .ToList();

            if (podaci.Count > 0)
            {
                dgvLicniPodaci.DataSource = podaci;
                dgvOpsteStanje.DataSource = podaci;

                var podatak = podaci[0];

                txtRadnaOrgNaziv.Text = podatak.RadnaOrganizacijaNaziv;
                txtRegBrSifraDjelatnosti.Text = podatak.RegBrSifraDjelatnosti;
                txtMisljenjeKomisije.Text = podatak.MisljenjeKomisije;
            }
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            LičniPodaciPacijenta licniPodaci = new LičniPodaciPacijenta(Pacijent);
            licniPodaci.ShowDialog();

            UcitajPodatke();
        }

        private void FormaLičniPodaci_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void dgvLicniPodaci_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
