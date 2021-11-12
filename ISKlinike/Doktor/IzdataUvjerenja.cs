using ISKlinike.Doktor;
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
    public partial class IzdataUvjerenja : Form
    {
        private Pacijenti pacijenti;
        private DBContext db = Baza.baza;
        public IzdataUvjerenja()
        {
            InitializeComponent();
            dgvIzdataSposobnost.AutoGenerateColumns = false;
            dgvIzdataSposobnost.RowTemplate.Resizable = DataGridViewTriState.True;
            dgvIzdataSposobnost.RowTemplate.Height = 35;
        }

        public IzdataUvjerenja(Pacijenti pac) :this()
        {
            this.pacijenti = pac;
            LoadData();
        }
        private void LoadData()
        {
            dgvIzdataSposobnost.DataSource = null;
            dgvIzdataSposobnost.DataSource = db.KartonIzdataUvjerenja.Where(p => p.Pacijent.Id == pacijenti.Id)?.ToList();


            foreach (DataGridViewRow row in dgvIzdataSposobnost.Rows)
            {
                if (row.Index % 2 == 0)
                {
                    row.DefaultCellStyle.BackColor = Color.LightGray;
                }
            }
        }
        private void KartonIzdataUvjerenja_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            IzdataUvjerenjaUredi uvjerenje = new IzdataUvjerenjaUredi(pacijenti);
            uvjerenje.Show();
            LoadData();
        }

        private void dgvIzdataSposobnost_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            KartonIzdataUvjerenja uvj = dgvIzdataSposobnost.SelectedRows[0].DataBoundItem as KartonIzdataUvjerenja;
            Form forma=null;
            if (uvj != null)
            {
                if (e.ColumnIndex == 3)
                {
                    forma = new IzvjestajIzdataUvjerenja(uvj);
                }
                forma.ShowDialog();
            }


            foreach (DataGridViewRow row in dgvIzdataSposobnost.Rows)
            {
                if (row.Index % 2 == 0)
                {
                    row.DefaultCellStyle.BackColor = Color.Gray;
                }
            }
        }
    }
}
