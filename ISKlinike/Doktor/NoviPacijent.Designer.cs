
namespace ISKlinike
{
    partial class NoviPacijent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoviPacijent));
            this.btnMinimiye = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDobrodosliKorisnik = new System.Windows.Forms.Label();
            this.lblImePacijenta = new System.Windows.Forms.Label();
            this.txtImePacijenta = new System.Windows.Forms.TextBox();
            this.txtPrezimePacijenta = new System.Windows.Forms.TextBox();
            this.lblPrezimePacijenta = new System.Windows.Forms.Label();
            this.txtImeRoditeljaPacijenta = new System.Windows.Forms.TextBox();
            this.lblImeRoditeljaPacijenta = new System.Windows.Forms.Label();
            this.txtAdresaPrebPacijenta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBrKartonaPac = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNapomenaPac = new System.Windows.Forms.RichTextBox();
            this.btnSačuvaj = new System.Windows.Forms.Button();
            this.err2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtDtmRodjenja = new System.Windows.Forms.TextBox();
            this.dtpPrijem = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMinimiye
            // 
            this.btnMinimiye.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimiye.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimiye.ForeColor = System.Drawing.Color.Red;
            this.btnMinimiye.Location = new System.Drawing.Point(756, 20);
            this.btnMinimiye.Name = "btnMinimiye";
            this.btnMinimiye.Size = new System.Drawing.Size(35, 30);
            this.btnMinimiye.TabIndex = 6;
            this.btnMinimiye.Text = "_";
            this.btnMinimiye.UseVisualStyleBackColor = true;
            this.btnMinimiye.Click += new System.EventHandler(this.btnMinimiye_Click);
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(722, 20);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 30);
            this.btnClose.TabIndex = 5;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.btnMinimiye);
            this.panel1.Controls.Add(this.lblDobrodosliKorisnik);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 59);
            this.panel1.TabIndex = 1;
            // 
            // lblDobrodosliKorisnik
            // 
            this.lblDobrodosliKorisnik.AutoSize = true;
            this.lblDobrodosliKorisnik.Font = new System.Drawing.Font("Lucida Handwriting", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDobrodosliKorisnik.ForeColor = System.Drawing.Color.White;
            this.lblDobrodosliKorisnik.Location = new System.Drawing.Point(3, 20);
            this.lblDobrodosliKorisnik.Name = "lblDobrodosliKorisnik";
            this.lblDobrodosliKorisnik.Size = new System.Drawing.Size(225, 27);
            this.lblDobrodosliKorisnik.TabIndex = 0;
            this.lblDobrodosliKorisnik.Text = "Podaci o pacijentu";
            this.lblDobrodosliKorisnik.UseMnemonic = false;
            // 
            // lblImePacijenta
            // 
            this.lblImePacijenta.BackColor = System.Drawing.Color.Transparent;
            this.lblImePacijenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImePacijenta.Location = new System.Drawing.Point(30, 83);
            this.lblImePacijenta.Name = "lblImePacijenta";
            this.lblImePacijenta.Size = new System.Drawing.Size(100, 23);
            this.lblImePacijenta.TabIndex = 2;
            this.lblImePacijenta.Text = "Ime:";
            // 
            // txtImePacijenta
            // 
            this.txtImePacijenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImePacijenta.Location = new System.Drawing.Point(30, 109);
            this.txtImePacijenta.Multiline = true;
            this.txtImePacijenta.Name = "txtImePacijenta";
            this.txtImePacijenta.Size = new System.Drawing.Size(224, 30);
            this.txtImePacijenta.TabIndex = 3;
            // 
            // txtPrezimePacijenta
            // 
            this.txtPrezimePacijenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrezimePacijenta.Location = new System.Drawing.Point(30, 177);
            this.txtPrezimePacijenta.Multiline = true;
            this.txtPrezimePacijenta.Name = "txtPrezimePacijenta";
            this.txtPrezimePacijenta.Size = new System.Drawing.Size(224, 30);
            this.txtPrezimePacijenta.TabIndex = 5;
            // 
            // lblPrezimePacijenta
            // 
            this.lblPrezimePacijenta.BackColor = System.Drawing.Color.Transparent;
            this.lblPrezimePacijenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrezimePacijenta.Location = new System.Drawing.Point(30, 151);
            this.lblPrezimePacijenta.Name = "lblPrezimePacijenta";
            this.lblPrezimePacijenta.Size = new System.Drawing.Size(100, 23);
            this.lblPrezimePacijenta.TabIndex = 4;
            this.lblPrezimePacijenta.Text = "Prezime:";
            // 
            // txtImeRoditeljaPacijenta
            // 
            this.txtImeRoditeljaPacijenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImeRoditeljaPacijenta.Location = new System.Drawing.Point(30, 245);
            this.txtImeRoditeljaPacijenta.Multiline = true;
            this.txtImeRoditeljaPacijenta.Name = "txtImeRoditeljaPacijenta";
            this.txtImeRoditeljaPacijenta.Size = new System.Drawing.Size(224, 30);
            this.txtImeRoditeljaPacijenta.TabIndex = 7;
            // 
            // lblImeRoditeljaPacijenta
            // 
            this.lblImeRoditeljaPacijenta.BackColor = System.Drawing.Color.Transparent;
            this.lblImeRoditeljaPacijenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImeRoditeljaPacijenta.Location = new System.Drawing.Point(30, 219);
            this.lblImeRoditeljaPacijenta.Name = "lblImeRoditeljaPacijenta";
            this.lblImeRoditeljaPacijenta.Size = new System.Drawing.Size(100, 23);
            this.lblImeRoditeljaPacijenta.TabIndex = 6;
            this.lblImeRoditeljaPacijenta.Text = "Ime roditelja:";
            // 
            // txtAdresaPrebPacijenta
            // 
            this.txtAdresaPrebPacijenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdresaPrebPacijenta.Location = new System.Drawing.Point(30, 313);
            this.txtAdresaPrebPacijenta.Multiline = true;
            this.txtAdresaPrebPacijenta.Name = "txtAdresaPrebPacijenta";
            this.txtAdresaPrebPacijenta.Size = new System.Drawing.Size(224, 30);
            this.txtAdresaPrebPacijenta.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Adresa prebivališta:";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Datum rođenja:";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(342, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "Datum prijema:";
            // 
            // txtBrKartonaPac
            // 
            this.txtBrKartonaPac.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrKartonaPac.Location = new System.Drawing.Point(342, 177);
            this.txtBrKartonaPac.Name = "txtBrKartonaPac";
            this.txtBrKartonaPac.ReadOnly = true;
            this.txtBrKartonaPac.Size = new System.Drawing.Size(228, 30);
            this.txtBrKartonaPac.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(342, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 14;
            this.label4.Text = "Broj kartona:";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(342, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 16;
            this.label5.Text = "Napomena:";
            // 
            // txtNapomenaPac
            // 
            this.txtNapomenaPac.Location = new System.Drawing.Point(342, 245);
            this.txtNapomenaPac.Name = "txtNapomenaPac";
            this.txtNapomenaPac.Size = new System.Drawing.Size(405, 96);
            this.txtNapomenaPac.TabIndex = 17;
            this.txtNapomenaPac.Text = "";
            // 
            // btnSačuvaj
            // 
            this.btnSačuvaj.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.btnSačuvaj.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSačuvaj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSačuvaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSačuvaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSačuvaj.ForeColor = System.Drawing.Color.Red;
            this.btnSačuvaj.Location = new System.Drawing.Point(564, 380);
            this.btnSačuvaj.Name = "btnSačuvaj";
            this.btnSačuvaj.Size = new System.Drawing.Size(183, 35);
            this.btnSačuvaj.TabIndex = 18;
            this.btnSačuvaj.Text = "Sačuvaj";
            this.btnSačuvaj.UseVisualStyleBackColor = false;
            this.btnSačuvaj.Click += new System.EventHandler(this.btnSačuvaj_Click);
            // 
            // err2
            // 
            this.err2.ContainerControl = this;
            // 
            // txtDtmRodjenja
            // 
            this.txtDtmRodjenja.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDtmRodjenja.Location = new System.Drawing.Point(30, 385);
            this.txtDtmRodjenja.Multiline = true;
            this.txtDtmRodjenja.Name = "txtDtmRodjenja";
            this.txtDtmRodjenja.Size = new System.Drawing.Size(224, 30);
            this.txtDtmRodjenja.TabIndex = 19;
            // 
            // dtpPrijem
            // 
            this.dtpPrijem.CalendarForeColor = System.Drawing.Color.Red;
            this.dtpPrijem.CalendarMonthBackground = System.Drawing.Color.Red;
            this.dtpPrijem.CalendarTitleBackColor = System.Drawing.Color.Red;
            this.dtpPrijem.CalendarTitleForeColor = System.Drawing.Color.Red;
            this.dtpPrijem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPrijem.Location = new System.Drawing.Point(342, 109);
            this.dtpPrijem.Name = "dtpPrijem";
            this.dtpPrijem.Size = new System.Drawing.Size(224, 22);
            this.dtpPrijem.TabIndex = 20;
            // 
            // NoviPacijent
            // 
            this.AcceptButton = this.btnSačuvaj;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtpPrijem);
            this.Controls.Add(this.txtDtmRodjenja);
            this.Controls.Add(this.btnSačuvaj);
            this.Controls.Add(this.txtNapomenaPac);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBrKartonaPac);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAdresaPrebPacijenta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtImeRoditeljaPacijenta);
            this.Controls.Add(this.lblImeRoditeljaPacijenta);
            this.Controls.Add(this.txtPrezimePacijenta);
            this.Controls.Add(this.lblPrezimePacijenta);
            this.Controls.Add(this.txtImePacijenta);
            this.Controls.Add(this.lblImePacijenta);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NoviPacijent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NoviPacijent";
            this.Load += new System.EventHandler(this.NoviPacijent_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMinimiye;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDobrodosliKorisnik;
        private System.Windows.Forms.Label lblImePacijenta;
        private System.Windows.Forms.TextBox txtImePacijenta;
        private System.Windows.Forms.TextBox txtPrezimePacijenta;
        private System.Windows.Forms.Label lblPrezimePacijenta;
        private System.Windows.Forms.TextBox txtImeRoditeljaPacijenta;
        private System.Windows.Forms.Label lblImeRoditeljaPacijenta;
        private System.Windows.Forms.TextBox txtAdresaPrebPacijenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBrKartonaPac;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox txtNapomenaPac;
        private System.Windows.Forms.Button btnSačuvaj;
        private System.Windows.Forms.ErrorProvider err2;
        private System.Windows.Forms.TextBox txtDtmRodjenja;
        private System.Windows.Forms.DateTimePicker dtpPrijem;
    }
}