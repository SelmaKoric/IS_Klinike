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
    public partial class PeriodicniPreglediUredi : Form
    {
        private DBContext db = Baza.baza;
        private Pacijenti Pacijent;

        public PeriodicniPreglediUredi()
        {
            InitializeComponent();
        }

        public PeriodicniPreglediUredi(Pacijenti pacijent) : this()
        {
            this.Pacijent = pacijent;
        }

        private void PeriodicniPreglediUredi_Load(object sender, EventArgs e)
        {
            lblImePrezimePacijenta.Text = Pacijent.ImePrezime;
            txtBrojKartona.Text = Pacijent.BrojKartona.ToString();
            txtDatumOtvaranja.Text = Pacijent.DatumPrvogPrijema.ToShortDateString();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
           KartonPeriodicniPregledi perPregledi = new KartonPeriodicniPregledi
                {
                    DatumPregleda = dtpDatumPregleda.Value,
                    Visina = float.Parse(txtVisina.Text.Replace('.', ',')),
                    Težina = float.Parse(txtTezina.Text.Replace('.', ',')),
                    ObimGrudi = txtObimGrudi.Text,
                    ObimStruka = txtObimStruka.Text,
                    BMI = float.Parse(txtBMI.Text.Replace('.', ',')),
                    KrvniPritisak = txtKrvniPritisak.Text,
                    Puls = int.Parse(txtPuls.Text.Replace('.', ',')),
                    PromjeneNaKozi = txtKoža.Text,
                    Ekstremiteti = txtEkstremiteti.Text,
                    Cula = txtCula.Text,
                    Tonzile = txtTonzile.Text,
                    Vrat = txtVrat.Text,
                    Pluca = txtPluća.Text,
                    GrudniKos = txtGrudniKoš.Text,
                    Abdomen = txtAbdomen.Text,
                    UroGenOrgani = txtUroGenOrgani.Text,
                    KicmeniStub = txtKicmeniStub.Text,
                    Pacijenti = Pacijent

                };

                db.KartonPeriodičniPregledi.Add(perPregledi);
                db.SaveChanges();
            MessageBox.Show("Uspješno sačuvano!");

            DialogResult = DialogResult.OK;
                Close();
            
        }

        private void IzracunajBMI()
        {
            if (float.TryParse(txtTezina.Text.Replace('.', ','), out float tezina) && float.TryParse(txtVisina.Text.Replace('.', ','), out float visina))
            {
                float bmi = tezina / (visina * 2);
                txtBMI.Text = bmi.ToString();
            }
        }

        private void txtVisina_TextChanged(object sender, EventArgs e)
        {
            IzracunajBMI();
        }

        private void txtTezina_TextChanged(object sender, EventArgs e)
        {
            IzracunajBMI();
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
