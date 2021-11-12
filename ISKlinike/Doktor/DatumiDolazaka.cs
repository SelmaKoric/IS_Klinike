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
    public partial class DatumiDolazaka : Form
    {
        private DBContext db = Baza.baza;
        private Pacijenti _pacijent;

        public DatumiDolazaka()
        {
            InitializeComponent();
            dgvDatumiPosjeta.AutoGenerateColumns = false;
            dgvDatumiPosjeta.RowTemplate.Resizable = DataGridViewTriState.True;
            dgvDatumiPosjeta.RowTemplate.Height = 35;
        }

        public DatumiDolazaka(Pacijenti pacijent): this()
        {
            this._pacijent = pacijent;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMinimiye_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void DatumiDolazaka_Load(object sender, EventArgs e)
        {
            dgvDatumiPosjeta.DataSource = null;
            dgvDatumiPosjeta.DataSource = db.KartonOboljenja.Where(x => x.Pacijenti.Id == _pacijent.Id).ToList();

            foreach (DataGridViewRow row in dgvDatumiPosjeta.Rows)
            {
                if (row.Index % 2 == 0)
                {
                    row.DefaultCellStyle.BackColor = Color.LightGray;
                }
            }

        }

        private void dgvDatumiPosjeta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
