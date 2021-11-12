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
    public partial class SplashScreen : Form
    {
        
        public SplashScreen()
        {
            
            InitializeComponent();
        }
       

        private void timer1_Tick(object sender, EventArgs e)
        {
            panelSlider.Width += 2;
            if (panelSlider.Width > 450)
            {
                return;
            }

        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnMinSplashScreen_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnExitSplashScreen_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
