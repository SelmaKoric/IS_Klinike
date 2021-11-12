using ISKlinike.Pacijent;
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
    public partial class Izborna_Pacijent : Form
    {
        private Pacijenti _pacijent;
        private DBContext db = Baza.baza;

        public Izborna_Pacijent(Pacijenti pacijent)
        {
            _pacijent = pacijent;
            InitializeComponent();
        }

        private void Izborna_Pacijent_Load(object sender, EventArgs e)
        {
            lblImePrezime.Text = _pacijent.ImePrezime;
        }

        private void PrikaziFormu(Form form)
        {
            this.Hide();
            form.ShowDialog();
        }

        private void btnPregledKartona_Click(object sender, EventArgs e)
        {
            PrikaziFormu(new LicniPodaci_Pacijent(_pacijent));
        }

        private void btnZakazivanjeTermina_Click(object sender, EventArgs e)
        {
            PrikaziFormu(new Termini_Pacijent(_pacijent));
        }

        private void btnOdjaviSe_Click(object sender, EventArgs e)
        {
            PrikaziFormu(new LoginForm());

        }

        
    }
}
