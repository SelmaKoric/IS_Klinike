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
    public partial class PeriodicniPregledi : Form
    {
        private DBContext db = Baza.baza;
        private Pacijenti Pacijent;
        KartonIzdataUvjerenja karton;

        public PeriodicniPregledi()
        {
            InitializeComponent();
            
            karton = new KartonIzdataUvjerenja();
        }

        public PeriodicniPregledi(Pacijenti pacijent) : this()
        {
            this.Pacijent = pacijent;
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            PeriodicniPreglediUredi pregledi = new PeriodicniPreglediUredi(Pacijent);
            pregledi.Show();
        }

        private void PeriodicniPregledi_Load(object sender, EventArgs e)
        {
           
        }

        private void dgvOsnovneFunkcije_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtpDatumPregleda_ValueChanged(object sender, EventArgs e)
        {

            var pregled = db.KartonPeriodičniPregledi.Where(x => x.Pacijenti.Id == Pacijent.Id).ToList();
            foreach (var p in pregled)
            {
                if (p.DatumPregleda.Date == dtpDatumPregleda.Value.Date)
                {
                    txtAbdomen.Text = p.Abdomen;
                    txtBMI.Text = p.BMI.ToString();
                    txtCula.Text = p.Cula;
                    txtEkstremiteti.Text=p.Ekstremiteti;
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

        private void dgvTjelesnaGrađa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
