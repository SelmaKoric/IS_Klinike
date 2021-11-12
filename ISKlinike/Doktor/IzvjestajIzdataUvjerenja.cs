using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace ISKlinike.Doktor
{
    public partial class IzvjestajIzdataUvjerenja : Form
    {
        private KartonIzdataUvjerenja izdatoUvjerenje;

        public IzvjestajIzdataUvjerenja()
        {
            InitializeComponent();
        }

        public IzvjestajIzdataUvjerenja(KartonIzdataUvjerenja izdatoUvjerenje):this()
        {
            this.izdatoUvjerenje = izdatoUvjerenje;
        }


        private void IzvjestajIzdataUvjerenja_Load(object sender, EventArgs e)
        {
            if (izdatoUvjerenje != null)
            {
                ReportParameterCollection rpc = new ReportParameterCollection();
                rpc.Add(new ReportParameter("ImePacijenta", izdatoUvjerenje.Pacijent.ImePrezime));
                rpc.Add(new ReportParameter("Datum", izdatoUvjerenje.DatumIzmjene.ToString()));
                rpc.Add(new ReportParameter("Stepen", izdatoUvjerenje.Invaliditet));
                rpc.Add(new ReportParameter("RadnaSposobnost", izdatoUvjerenje.RadnaSposobnost));
                rpc.Add(new ReportParameter("Izdavaoc", LoginForm.LogiraniKorisnik.ImePrezime));

                reportViewer1.LocalReport.SetParameters(rpc);

            }
            this.reportViewer1.RefreshReport();
            
        }
    }
}
