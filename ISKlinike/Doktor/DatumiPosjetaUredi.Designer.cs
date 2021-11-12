
namespace ISKlinike
{
    partial class DatumiPosjetaUredi
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDatumPosjete = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpVrijemePrijema = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtImeLjekara = new System.Windows.Forms.RichTextBox();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDatumOtvaranja = new System.Windows.Forms.TextBox();
            this.txtBrojKartona = new System.Windows.Forms.TextBox();
            this.lblDatumOtv = new System.Windows.Forms.Label();
            this.lblBrojKartona = new System.Windows.Forms.Label();
            this.btnMinimiye = new System.Windows.Forms.Button();
            this.lblImePrezimePacijenta = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(153, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datum posjete:";
            // 
            // dtpDatumPosjete
            // 
            this.dtpDatumPosjete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDatumPosjete.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatumPosjete.Location = new System.Drawing.Point(156, 135);
            this.dtpDatumPosjete.Name = "dtpDatumPosjete";
            this.dtpDatumPosjete.Size = new System.Drawing.Size(200, 29);
            this.dtpDatumPosjete.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(153, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vrijeme posjete:";
            // 
            // dtpVrijemePrijema
            // 
            this.dtpVrijemePrijema.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpVrijemePrijema.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpVrijemePrijema.Location = new System.Drawing.Point(156, 200);
            this.dtpVrijemePrijema.Name = "dtpVrijemePrijema";
            this.dtpVrijemePrijema.Size = new System.Drawing.Size(200, 29);
            this.dtpVrijemePrijema.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(153, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Evidentiran od:";
            // 
            // txtImeLjekara
            // 
            this.txtImeLjekara.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImeLjekara.Location = new System.Drawing.Point(156, 271);
            this.txtImeLjekara.Name = "txtImeLjekara";
            this.txtImeLjekara.ReadOnly = true;
            this.txtImeLjekara.Size = new System.Drawing.Size(200, 41);
            this.txtImeLjekara.TabIndex = 5;
            this.txtImeLjekara.Text = "";
            this.txtImeLjekara.TextChanged += new System.EventHandler(this.txtImeLjekara_TextChanged);
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.btnSacuvaj.BackColor = System.Drawing.Color.LightGray;
            this.btnSacuvaj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSacuvaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSacuvaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSacuvaj.ForeColor = System.Drawing.Color.Red;
            this.btnSacuvaj.Location = new System.Drawing.Point(323, 373);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(150, 35);
            this.btnSacuvaj.TabIndex = 21;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = false;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.txtDatumOtvaranja);
            this.panel1.Controls.Add(this.txtBrojKartona);
            this.panel1.Controls.Add(this.lblDatumOtv);
            this.panel1.Controls.Add(this.lblBrojKartona);
            this.panel1.Controls.Add(this.btnMinimiye);
            this.panel1.Controls.Add(this.lblImePrezimePacijenta);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 59);
            this.panel1.TabIndex = 22;
            // 
            // txtDatumOtvaranja
            // 
            this.txtDatumOtvaranja.Location = new System.Drawing.Point(118, 32);
            this.txtDatumOtvaranja.Name = "txtDatumOtvaranja";
            this.txtDatumOtvaranja.Size = new System.Drawing.Size(100, 20);
            this.txtDatumOtvaranja.TabIndex = 11;
            // 
            // txtBrojKartona
            // 
            this.txtBrojKartona.Location = new System.Drawing.Point(118, 9);
            this.txtBrojKartona.Name = "txtBrojKartona";
            this.txtBrojKartona.Size = new System.Drawing.Size(100, 20);
            this.txtBrojKartona.TabIndex = 10;
            // 
            // lblDatumOtv
            // 
            this.lblDatumOtv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatumOtv.ForeColor = System.Drawing.Color.White;
            this.lblDatumOtv.Location = new System.Drawing.Point(3, 32);
            this.lblDatumOtv.Name = "lblDatumOtv";
            this.lblDatumOtv.Size = new System.Drawing.Size(125, 23);
            this.lblDatumOtv.TabIndex = 9;
            this.lblDatumOtv.Text = "Datum otvaranja:";
            // 
            // lblBrojKartona
            // 
            this.lblBrojKartona.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrojKartona.ForeColor = System.Drawing.Color.White;
            this.lblBrojKartona.Location = new System.Drawing.Point(3, 9);
            this.lblBrojKartona.Name = "lblBrojKartona";
            this.lblBrojKartona.Size = new System.Drawing.Size(100, 23);
            this.lblBrojKartona.TabIndex = 7;
            this.lblBrojKartona.Text = "Broj kartona:";
            // 
            // btnMinimiye
            // 
            this.btnMinimiye.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimiye.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimiye.ForeColor = System.Drawing.Color.Red;
            this.btnMinimiye.Location = new System.Drawing.Point(453, 19);
            this.btnMinimiye.Name = "btnMinimiye";
            this.btnMinimiye.Size = new System.Drawing.Size(35, 30);
            this.btnMinimiye.TabIndex = 6;
            this.btnMinimiye.Text = "_";
            this.btnMinimiye.UseVisualStyleBackColor = true;
            this.btnMinimiye.Click += new System.EventHandler(this.btnMinimiye_Click);
            // 
            // lblImePrezimePacijenta
            // 
            this.lblImePrezimePacijenta.AutoSize = true;
            this.lblImePrezimePacijenta.Font = new System.Drawing.Font("Lucida Handwriting", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImePrezimePacijenta.ForeColor = System.Drawing.Color.White;
            this.lblImePrezimePacijenta.Location = new System.Drawing.Point(235, 20);
            this.lblImePrezimePacijenta.Name = "lblImePrezimePacijenta";
            this.lblImePrezimePacijenta.Size = new System.Drawing.Size(149, 27);
            this.lblImePrezimePacijenta.TabIndex = 0;
            this.lblImePrezimePacijenta.Text = "ImePrezime";
            this.lblImePrezimePacijenta.UseMnemonic = false;
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(419, 19);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 30);
            this.btnClose.TabIndex = 5;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // DatumiPosjetaUredi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ISKlinike.Properties.Resources.pngtree_vector_white_background_with_abstract_geometric_pattern_or_textu_image_265390;
            this.ClientSize = new System.Drawing.Size(506, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.txtImeLjekara);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpVrijemePrijema);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpDatumPosjete);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DatumiPosjetaUredi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DatumiPosjeta";
            this.Load += new System.EventHandler(this.DatumiPosjeta_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDatumPosjete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpVrijemePrijema;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtImeLjekara;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtDatumOtvaranja;
        private System.Windows.Forms.TextBox txtBrojKartona;
        private System.Windows.Forms.Label lblDatumOtv;
        private System.Windows.Forms.Label lblBrojKartona;
        private System.Windows.Forms.Button btnMinimiye;
        private System.Windows.Forms.Label lblImePrezimePacijenta;
        private System.Windows.Forms.Button btnClose;
    }
}