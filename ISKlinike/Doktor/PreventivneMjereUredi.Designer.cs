
namespace ISKlinike
{
    partial class PreventivneMjereUredi
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDatumOtvaranja = new System.Windows.Forms.TextBox();
            this.txtBrojKartona = new System.Windows.Forms.TextBox();
            this.lblDatumOtv = new System.Windows.Forms.Label();
            this.lblBrojKartona = new System.Windows.Forms.Label();
            this.btnMinimiye = new System.Windows.Forms.Button();
            this.lblImePrezimePacijenta = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDatumPregleda = new System.Windows.Forms.DateTimePicker();
            this.rtbPrevPregled = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(883, 59);
            this.panel1.TabIndex = 4;
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
            this.btnMinimiye.Location = new System.Drawing.Point(836, 22);
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
            this.lblImePrezimePacijenta.Location = new System.Drawing.Point(398, 22);
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
            this.btnClose.Location = new System.Drawing.Point(802, 22);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 30);
            this.btnClose.TabIndex = 5;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.btnSacuvaj.BackColor = System.Drawing.Color.LightGray;
            this.btnSacuvaj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSacuvaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSacuvaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSacuvaj.ForeColor = System.Drawing.Color.Red;
            this.btnSacuvaj.Location = new System.Drawing.Point(691, 448);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(150, 35);
            this.btnSacuvaj.TabIndex = 20;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = false;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(638, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Datum pregleda:";
            // 
            // dtpDatumPregleda
            // 
            this.dtpDatumPregleda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDatumPregleda.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatumPregleda.Location = new System.Drawing.Point(641, 98);
            this.dtpDatumPregleda.Name = "dtpDatumPregleda";
            this.dtpDatumPregleda.Size = new System.Drawing.Size(200, 29);
            this.dtpDatumPregleda.TabIndex = 18;
           // this.dtpDatumPregleda.ValueChanged += new System.EventHandler(this.dtpDatumPregleda_ValueChanged);
            // 
            // rtbPrevPregled
            // 
            this.rtbPrevPregled.BackColor = System.Drawing.Color.White;
            this.rtbPrevPregled.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbPrevPregled.ForeColor = System.Drawing.Color.Black;
            this.rtbPrevPregled.Location = new System.Drawing.Point(28, 147);
            this.rtbPrevPregled.Name = "rtbPrevPregled";
            this.rtbPrevPregled.Size = new System.Drawing.Size(813, 268);
            this.rtbPrevPregled.TabIndex = 17;
            this.rtbPrevPregled.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "Na preventivnom pregledu utvrđeno:";
            // 
            // PreventivneMjereUredi
            // 
            this.AcceptButton = this.btnSacuvaj;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ISKlinike.Properties.Resources.pngtree_vector_white_background_with_abstract_geometric_pattern_or_textu_image_265390;
            this.ClientSize = new System.Drawing.Size(882, 535);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpDatumPregleda);
            this.Controls.Add(this.rtbPrevPregled);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PreventivneMjereUredi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PreventivneMjereUredi";
            this.Load += new System.EventHandler(this.PreventivneMjereUredi_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtDatumOtvaranja;
        private System.Windows.Forms.TextBox txtBrojKartona;
        private System.Windows.Forms.Label lblDatumOtv;
        private System.Windows.Forms.Label lblBrojKartona;
        private System.Windows.Forms.Button btnMinimiye;
        private System.Windows.Forms.Label lblImePrezimePacijenta;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDatumPregleda;
        private System.Windows.Forms.RichTextBox rtbPrevPregled;
        private System.Windows.Forms.Label label1;
    }
}