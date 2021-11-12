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
    public partial class NesposobnostZaRadOdDo : Form
    {
        private DBContext db = Baza.baza;
        private Pacijenti pacijent;

        public NesposobnostZaRadOdDo()
        {
            InitializeComponent();
            dgvNesposobnostiZaRad.AutoGenerateColumns = false;
            dgvNesposobnostiZaRad.RowTemplate.Resizable = DataGridViewTriState.True;
            dgvNesposobnostiZaRad.RowTemplate.Height = 35;
        }

        public NesposobnostZaRadOdDo(Pacijenti pacijent): this()
        {
            this.pacijent = pacijent;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMinimiye_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void NesposobnostZaRadOdDo_Load(object sender, EventArgs e)
        {
            dgvNesposobnostiZaRad.DataSource = null;
            dgvNesposobnostiZaRad.DataSource = db.KartonOboljenja.Where(x => x.Pacijenti.Id == pacijent.Id).ToList();


            foreach (DataGridViewRow row in dgvNesposobnostiZaRad.Rows)
            {
                if (row.Index % 2 == 0)
                {
                    row.DefaultCellStyle.BackColor = Color.LightGray;
                }
            }
        }

        private void dgvNesposobnostiZaRad_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
