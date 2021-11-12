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
    public partial class NoviPacijent : Form
    {
        private static DBContext db = Baza.baza;
        
        public NoviPacijent()
        {
            InitializeComponent();
        }

        private void btnSačuvaj_Click(object sender, EventArgs e)
        {

            if (Validator.ValidirajUnos(txtImePacijenta, err2, Validator.povratnaPoruka) &&
                Validator.ValidirajUnos(txtPrezimePacijenta, err2, Validator.povratnaPoruka) &&
                Validator.ValidirajUnos(txtImeRoditeljaPacijenta, err2, Validator.povratnaPoruka) &&
              Validator.ValidirajUnos(txtDtmRodjenja, err2, Validator.povratnaPoruka))
            {
                Pacijenti pacijent = new Pacijenti
                {
                    
                    Ime = txtImePacijenta.Text,
                    Prezime = txtPrezimePacijenta.Text,
                    ImeRoditelja = txtImeRoditeljaPacijenta.Text,
                    AdresaPrebivalista = txtAdresaPrebPacijenta.Text,
                    DatumRodjenja = txtDtmRodjenja.Text,
                    DatumPrvogPrijema = dtpPrijem.Value,
                    BrojKartona = db.Pacijenti.Count() + 1,
                    Napomena = txtNapomenaPac.Text
                };
                db.Pacijenti.Add(pacijent);
                db.SaveChanges();
                MessageBox.Show("Uspješno sačuvano!");

                this.Hide();
                KartonPacijenta karton = new KartonPacijenta(pacijent);
                karton.ShowDialog();
                Close();
                //DialogResult = DialogResult.OK;

            }


        }

        private void btnMinimiye_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void NoviPacijent_Load(object sender, EventArgs e)
        {
            txtBrKartonaPac.Text = (db.Pacijenti.Count() + 1).ToString();
        }
    }
}

