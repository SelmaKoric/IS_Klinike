using DocumentFormat.OpenXml.Office2010.Word;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISKlinike
{
    public partial class LoginForm : Form
    {
        public static Korisnik LogiraniKorisnik;
        public static Pacijenti LogiraniPacijent;
        private DBContext db = Baza.baza;
        public LoginForm()
        {

            Thread trd = new Thread(new ThreadStart(formRun));
            trd.Start();
            Thread.Sleep(6000);
            InitializeComponent();
            trd.Abort();
        }

        private void formRun()
        {
            Application.Run(new SplashScreen());
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            string korisnickoIme = txtKorisnickoIme.Text;
            string lozinka = txtLozinka.Text;
            bool postoji = false;
            bool pacijenti = false;

            if (Validator.ValidirajUnos(txtKorisnickoIme, err1, Validator.povratnaPoruka) && Validator.ValidirajUnos(txtLozinka, err1, Validator.povratnaPoruka))
            {
                foreach (var korisnik in db.Korisnici)
                {
                    if (korisnickoIme == korisnik.KorisničkoIme && lozinka == korisnik.Lozinka)
                    {
                        postoji = true;
                        foreach (var pacijent in db.Pacijenti)
                        {
                            if (pacijent.Ime == korisnik.Ime && korisnik.BrojKartona.StartsWith("P"))
                            {
                                pacijenti = true;
                                PrikaziFormu(new Izborna_Pacijent(pacijent));
                            }
                        }
                        if(pacijenti==false)
                        {
                            LogiraniKorisnik = korisnik;
                            PrikaziFormu(new ListaPacijenata());
                        }
                    }
                }

                if (!postoji)
                    MessageBox.Show("Korisnik nije pronađen!");

            }
        }

        void PrikaziFormu(Form forma)
        {
            this.Hide();
            forma.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            char prazan = new char();
            if (txtLozinka.PasswordChar == prazan)
                txtLozinka.PasswordChar = '*';
            else
                txtLozinka.PasswordChar = prazan;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.fit.ba");
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
