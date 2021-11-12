using ISKlinike.Doktor;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ISKlinike
{
    public partial class ListaPacijenata : Form
    {
        private DBContext db = Baza.baza;
       
        public ListaPacijenata()
        {
            InitializeComponent();
            dgvListaPacijenata.AutoGenerateColumns = false;
            dgvListaPacijenata.RowTemplate.Resizable = DataGridViewTriState.True;
            dgvListaPacijenata.RowTemplate.Height = 35;

            lblDobrodosliKorisnik.Text += LoginForm.LogiraniKorisnik.KorisničkoIme;
        }

        private void btnNoviPacijent_Click(object sender, EventArgs e)
        {
            NoviPacijent pacijent = new NoviPacijent();
            pacijent.ShowDialog();
            
                LoadData(db.Pacijenti.ToList());
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.ShowDialog();
        }

        private void ListaPacijenata_Load(object sender, EventArgs e)
        {
            LoadData(db.Pacijenti?.ToList());

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string filter = txtPretraga.Text.ToLower();
            List<Pacijenti> rezultat = new List<Pacijenti>();

            foreach(var pacijent in db.Pacijenti)
            {
                if (pacijent.ImePrezime.Contains(filter) || pacijent.BrojKartona.ToString() == filter)
                    rezultat.Add(pacijent);
            }
            LoadData(rezultat);
        }

        private void LoadData(List<Pacijenti> pacijenti)
        {
            dgvListaPacijenata.DataSource = null;
            dgvListaPacijenata.DataSource = pacijenti.ToList();

            foreach(DataGridViewRow row in dgvListaPacijenata.Rows)
            {
                if (row.Index % 2 == 0)
                {
                    row.DefaultCellStyle.BackColor = Color.LightGray;
                }
            }
        }

        private void btnMinimiye_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

      

        private void dgvListaPacijenata_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

           Pacijenti pacijent = dgvListaPacijenata.SelectedRows[0].DataBoundItem as Pacijenti;

            if (pacijent != null)
            {
                if (e.ColumnIndex == 3)
                {
                    var forma = new KartonPacijenta(pacijent);
                    forma?.ShowDialog();
                }
            }
        }

        private void btnTermini_Click(object sender, EventArgs e)
        {
            this.Hide();
            Termini termin = new Termini(LoginForm.LogiraniKorisnik);
            termin.ShowDialog();
        }

        private void btnOcisti_Click(object sender, EventArgs e)
        {
            if (txtPretraga.ToString() != string.Empty)
            {
                txtPretraga.Text = " ";
            }
        }
    }
}
