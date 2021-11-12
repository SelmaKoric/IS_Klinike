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
    public partial class NalaziPacijenta : Form
    {
        private DBContext db = Baza.baza;
        private Pacijenti Pacijent;
        private bool buttonClickedLicna = false;
        private bool buttonClickedPorodicna = false;
        private bool buttonClickedRadna = false;
        public NalaziPacijenta()
        {
            InitializeComponent();
            
        }

        public NalaziPacijenta(Pacijenti pacijent) : this()
        {
            this.Pacijent = pacijent;
        }

        private void NalaziPacijenta_Load(object sender, EventArgs e)
        {

        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            NalaziPacijentaUredi nalazi = new NalaziPacijentaUredi(Pacijent);
            nalazi.Show();
        }

        private void btnLicnaAnamneza_Click(object sender, EventArgs e)
        {
            var nalazi = db.KartonNalazi.Where(x => x.Pacijenti.Id == Pacijent.Id).ToList();
            foreach (var nalaz in nalazi)
            {
                if (nalaz.DatumIzmjene.Date == dateTimePicker1.Value.Date)
                {
                    rtbAnamneze.Text = nalaz.LicnaAnamneza;
                    return;
                }
            }

            rtbAnamneze.Text = "";
            buttonClickedLicna = true;
        }

        private void btnPorodicnaAnamneza_Click(object sender, EventArgs e)
        {
            var nalazi = db.KartonNalazi.Where(x => x.Pacijenti.Id == Pacijent.Id).ToList();
            foreach (var nalaz in nalazi)
            {
                if (nalaz.DatumIzmjene.Date == dateTimePicker1.Value.Date)
                {
                    rtbAnamneze.Text = nalaz.PorodicnaAnamneza;
                    return;
                }
            }

            rtbAnamneze.Text = "";
            buttonClickedPorodicna = true;

        }

        private void btnRadnaAnamn_Click(object sender, EventArgs e)
        {
            var nalazi = db.KartonNalazi.Where(x => x.Pacijenti.Id == Pacijent.Id).ToList();
            foreach (var nalaz in nalazi)
            {
                if (nalaz.DatumIzmjene.Date == dateTimePicker1.Value.Date)
                {
                    rtbAnamneze.Text = nalaz.RadnaAnamneza;
                    return;
                }
            }

            rtbAnamneze.Text = "";
            buttonClickedRadna = true;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            lblInfo.Text = "Klikom na dugmiće otvaraju se podaci o anamnezama u boxu ispod!";
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            lblInfo.Text = "";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            var nalazi = db.KartonNalazi.Where(x => x.Pacijenti.Id == Pacijent.Id).ToList();
            foreach (var n in nalazi)
            {
                if (n.DatumIzmjene.Date == dateTimePicker1.Value.Date && buttonClickedLicna)
                {
                    rtbAnamneze.Text = n.LicnaAnamneza;
                    return;
                }
                else if(n.DatumIzmjene.Date == dateTimePicker1.Value.Date && buttonClickedPorodicna)
                {
                    rtbAnamneze.Text = n.PorodicnaAnamneza;
                    return;
                }
                else if(n.DatumIzmjene.Date == dateTimePicker1.Value.Date && buttonClickedRadna)
                {

                    rtbAnamneze.Text = n.RadnaAnamneza;
                    return;
                }
                rtbAnamneze.Text = "";
            }
        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {

        }
    }
}
