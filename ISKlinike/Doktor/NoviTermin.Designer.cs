
namespace ISKlinike.Doktor
{
    partial class NoviTermin
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
            this.dtpPregled = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMinimiye = new System.Windows.Forms.Button();
            this.lblDobrodosliKorisnik = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.rtbRazlogPosjete = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSačuvaj = new System.Windows.Forms.Button();
            this.cmbPacijenti = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpPregled
            // 
            this.dtpPregled.CalendarForeColor = System.Drawing.Color.Red;
            this.dtpPregled.CalendarMonthBackground = System.Drawing.Color.Red;
            this.dtpPregled.CalendarTitleBackColor = System.Drawing.Color.Red;
            this.dtpPregled.CalendarTitleForeColor = System.Drawing.Color.Red;
            this.dtpPregled.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPregled.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPregled.Location = new System.Drawing.Point(42, 226);
            this.dtpPregled.Name = "dtpPregled";
            this.dtpPregled.Size = new System.Drawing.Size(176, 26);
            this.dtpPregled.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(276, 23);
            this.label3.TabIndex = 23;
            this.label3.Text = "Izaberite datum i vrijeme pregleda.";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 23);
            this.label1.TabIndex = 25;
            this.label1.Text = "Ime i prezime pacijenta:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.btnMinimiye);
            this.panel1.Controls.Add(this.lblDobrodosliKorisnik);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(667, 55);
            this.panel1.TabIndex = 26;
            // 
            // btnMinimiye
            // 
            this.btnMinimiye.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimiye.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimiye.ForeColor = System.Drawing.Color.Red;
            this.btnMinimiye.Location = new System.Drawing.Point(623, 12);
            this.btnMinimiye.Name = "btnMinimiye";
            this.btnMinimiye.Size = new System.Drawing.Size(35, 30);
            this.btnMinimiye.TabIndex = 6;
            this.btnMinimiye.Text = "_";
            this.btnMinimiye.UseVisualStyleBackColor = true;
            this.btnMinimiye.Click += new System.EventHandler(this.btnMinimiye_Click);
            // 
            // lblDobrodosliKorisnik
            // 
            this.lblDobrodosliKorisnik.AutoSize = true;
            this.lblDobrodosliKorisnik.Font = new System.Drawing.Font("Lucida Handwriting", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDobrodosliKorisnik.ForeColor = System.Drawing.Color.White;
            this.lblDobrodosliKorisnik.Location = new System.Drawing.Point(15, 13);
            this.lblDobrodosliKorisnik.Name = "lblDobrodosliKorisnik";
            this.lblDobrodosliKorisnik.Size = new System.Drawing.Size(147, 27);
            this.lblDobrodosliKorisnik.TabIndex = 0;
            this.lblDobrodosliKorisnik.Text = "Novi termin";
            this.lblDobrodosliKorisnik.UseMnemonic = false;
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(589, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 30);
            this.btnClose.TabIndex = 5;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // rtbRazlogPosjete
            // 
            this.rtbRazlogPosjete.Location = new System.Drawing.Point(353, 139);
            this.rtbRazlogPosjete.Margin = new System.Windows.Forms.Padding(2);
            this.rtbRazlogPosjete.Name = "rtbRazlogPosjete";
            this.rtbRazlogPosjete.Size = new System.Drawing.Size(282, 219);
            this.rtbRazlogPosjete.TabIndex = 27;
            this.rtbRazlogPosjete.Text = "";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(349, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 23);
            this.label2.TabIndex = 29;
            this.label2.Text = "Razlog posjete:";
            // 
            // btnSačuvaj
            // 
            this.btnSačuvaj.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.btnSačuvaj.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSačuvaj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSačuvaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSačuvaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSačuvaj.ForeColor = System.Drawing.Color.Red;
            this.btnSačuvaj.Location = new System.Drawing.Point(523, 380);
            this.btnSačuvaj.Name = "btnSačuvaj";
            this.btnSačuvaj.Size = new System.Drawing.Size(135, 29);
            this.btnSačuvaj.TabIndex = 30;
            this.btnSačuvaj.Text = "Sačuvaj";
            this.btnSačuvaj.UseVisualStyleBackColor = false;
            this.btnSačuvaj.Click += new System.EventHandler(this.btnSačuvaj_Click);
            // 
            // cmbPacijenti
            // 
            this.cmbPacijenti.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPacijenti.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPacijenti.FormattingEnabled = true;
            this.cmbPacijenti.Location = new System.Drawing.Point(42, 140);
            this.cmbPacijenti.Name = "cmbPacijenti";
            this.cmbPacijenti.Size = new System.Drawing.Size(176, 26);
            this.cmbPacijenti.TabIndex = 31;
            // 
            // NoviTermin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ISKlinike.Properties.Resources.pngtree_vector_white_background_with_abstract_geometric_pattern_or_textu_image_265390;
            this.ClientSize = new System.Drawing.Size(667, 418);
            this.Controls.Add(this.cmbPacijenti);
            this.Controls.Add(this.btnSačuvaj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtbRazlogPosjete);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpPregled);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NoviTermin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NoviTermin";
            this.Load += new System.EventHandler(this.NoviTermin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpPregled;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMinimiye;
        private System.Windows.Forms.Label lblDobrodosliKorisnik;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.RichTextBox rtbRazlogPosjete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSačuvaj;
        private System.Windows.Forms.ComboBox cmbPacijenti;
    }
}