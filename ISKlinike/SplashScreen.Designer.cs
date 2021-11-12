
namespace ISKlinike
{
    partial class SplashScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelSlider = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnExitSplashScreen = new System.Windows.Forms.Button();
            this.btnMinSplashScreen = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Medica :: Dobrodošli";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panelSlider);
            this.panel1.Location = new System.Drawing.Point(64, 227);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 38);
            this.panel1.TabIndex = 2;
            // 
            // panelSlider
            // 
            this.panelSlider.BackColor = System.Drawing.Color.Maroon;
            this.panelSlider.Location = new System.Drawing.Point(0, 0);
            this.panelSlider.Name = "panelSlider";
            this.panelSlider.Size = new System.Drawing.Size(43, 38);
            this.panelSlider.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ISKlinike.Properties.Resources._07022019_15;
            this.pictureBox1.Image = global::ISKlinike.Properties.Resources._07022019_15;
            this.pictureBox1.Location = new System.Drawing.Point(178, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(218, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 5;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(-1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 358);
            this.label2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(600, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 358);
            this.label3.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(608, 10);
            this.label4.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(1, 348);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(608, 10);
            this.label5.TabIndex = 6;
            // 
            // btnExitSplashScreen
            // 
            this.btnExitSplashScreen.ForeColor = System.Drawing.Color.Red;
            this.btnExitSplashScreen.Location = new System.Drawing.Point(570, 13);
            this.btnExitSplashScreen.Name = "btnExitSplashScreen";
            this.btnExitSplashScreen.Size = new System.Drawing.Size(24, 23);
            this.btnExitSplashScreen.TabIndex = 7;
            this.btnExitSplashScreen.Text = "X";
            this.btnExitSplashScreen.UseVisualStyleBackColor = true;
            this.btnExitSplashScreen.Click += new System.EventHandler(this.btnExitSplashScreen_Click);
            // 
            // btnMinSplashScreen
            // 
            this.btnMinSplashScreen.ForeColor = System.Drawing.Color.Red;
            this.btnMinSplashScreen.Location = new System.Drawing.Point(546, 13);
            this.btnMinSplashScreen.Name = "btnMinSplashScreen";
            this.btnMinSplashScreen.Size = new System.Drawing.Size(24, 23);
            this.btnMinSplashScreen.TabIndex = 8;
            this.btnMinSplashScreen.Text = "__";
            this.btnMinSplashScreen.UseVisualStyleBackColor = true;
            this.btnMinSplashScreen.Click += new System.EventHandler(this.btnMinSplashScreen_Click);
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(610, 358);
            this.Controls.Add(this.btnMinSplashScreen);
            this.Controls.Add(this.btnExitSplashScreen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashScreen";
            this.Load += new System.EventHandler(this.SplashScreen_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelSlider;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnExitSplashScreen;
        private System.Windows.Forms.Button btnMinSplashScreen;
    }
}