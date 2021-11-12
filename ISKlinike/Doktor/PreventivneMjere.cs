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
    public partial class PreventivneMjere : Form
    {
        private Pacijenti Pacijent;
        private DBContext db = Baza.baza;
        public PreventivneMjere()
        {
            InitializeComponent();
        }

        public PreventivneMjere(Pacijenti pacijent):this()
        {
            Pacijent = pacijent;
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            PreventivneMjereUredi pregled = new PreventivneMjereUredi(Pacijent);
            pregled.Show();
        }

        private void dtpDatumPregleda_ValueChanged(object sender, EventArgs e)
        {
            var mjere = db.KartonPreventivneMjere.Where(x => x.Pacijent.Id == Pacijent.Id).ToList();
            foreach (var m in mjere)
            {
                if (m.DatumPregleda.Date == dtpDatumPregleda.Value.Date)
                {
                    rtbPreventivneMjere.Text = m.PreventivniPregled;
                    return;
                }
                rtbPreventivneMjere.Text = "";
            }
        }
    }
}
