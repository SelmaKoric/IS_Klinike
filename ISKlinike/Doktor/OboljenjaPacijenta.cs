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
    public partial class OboljenjaPacijenta : Form
    {
        private DBContext db = Baza.baza;
        private Pacijenti Pacijent;

        public OboljenjaPacijenta()
        {
            InitializeComponent();
            
            dgvOboljenja.AutoGenerateColumns = false;
            dgvOboljenja.DataSource = null;
            dgvOboljenja.RowTemplate.Resizable = DataGridViewTriState.True;
            dgvOboljenja.RowTemplate.Height = 35;
        }
        

        public OboljenjaPacijenta(Pacijenti pacijent) : this()
        {
            Pacijent = pacijent;
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            var podaci = db.KartonOboljenja
                   .Where(o => o.Pacijenti.Id == Pacijent.Id)
                   .ToList();

            if (podaci.Count > 0)
            {
                dgvOboljenja.DataSource = null;
                dgvOboljenja.DataSource = podaci;

            }


            foreach (DataGridViewRow row in dgvOboljenja.Rows)
            {
                if (row.Index % 2 == 0)
                {
                    row.DefaultCellStyle.BackColor = Color.LightGray;
                }
            }
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            OboljenjaUredi urediOboljenja = new OboljenjaUredi(Pacijent);
            urediOboljenja.Show();

            UcitajPodatke();
        }

        private void OboljenjaPacijenta_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void btnNesposobnostiZaRad_Click(object sender, EventArgs e)
        {
            NesposobnostZaRadOdDo NesposobnostOdDo = new NesposobnostZaRadOdDo(Pacijent);
            NesposobnostOdDo.Show();
        }

        private void btnDatumiPosjeta_Click(object sender, EventArgs e)
        {
            DatumiDolazaka posjete = new DatumiDolazaka(Pacijent);
            posjete.Show();
        }

        private void dgvOboljenja_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
