
namespace ISKlinike
{
    partial class IzdataUvjerenjaUredi
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtRadnaSposobnost = new System.Windows.Forms.TextBox();
            this.txtInvaliditet = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDatumUvjerenja = new System.Windows.Forms.DateTimePicker();
            this.btnSacuvaj = new System.Windows.Forms.Button();
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
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(732, 59);
            this.panel1.TabIndex = 5;
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
            this.btnMinimiye.Location = new System.Drawing.Point(691, 24);
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
            this.btnClose.Location = new System.Drawing.Point(657, 24);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 30);
            this.btnClose.TabIndex = 5;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Radna sposobnost:";
            // 
            // txtRadnaSposobnost
            // 
            this.txtRadnaSposobnost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRadnaSposobnost.Location = new System.Drawing.Point(309, 119);
            this.txtRadnaSposobnost.Multiline = true;
            this.txtRadnaSposobnost.Name = "txtRadnaSposobnost";
            this.txtRadnaSposobnost.Size = new System.Drawing.Size(261, 39);
            this.txtRadnaSposobnost.TabIndex = 7;
            // 
            // txtInvaliditet
            // 
            this.txtInvaliditet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvaliditet.Location = new System.Drawing.Point(309, 181);
            this.txtInvaliditet.Multiline = true;
            this.txtInvaliditet.Name = "txtInvaliditet";
            this.txtInvaliditet.Size = new System.Drawing.Size(261, 39);
            this.txtInvaliditet.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(145, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Invaliditet (stepen):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(145, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Datum izmjene:";
            // 
            // dtpDatumUvjerenja
            // 
            this.dtpDatumUvjerenja.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDatumUvjerenja.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatumUvjerenja.Location = new System.Drawing.Point(309, 241);
            this.dtpDatumUvjerenja.Name = "dtpDatumUvjerenja";
            this.dtpDatumUvjerenja.Size = new System.Drawing.Size(261, 29);
            this.dtpDatumUvjerenja.TabIndex = 11;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.btnSacuvaj.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSacuvaj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSacuvaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSacuvaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSacuvaj.ForeColor = System.Drawing.Color.Red;
            this.btnSacuvaj.Location = new System.Drawing.Point(519, 370);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(183, 35);
            this.btnSacuvaj.TabIndex = 12;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = false;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // IzdataUvjerenjaUredi
            // 
            this.AcceptButton = this.btnSacuvaj;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ISKlinike.Properties.Resources.pngtree_vector_white_background_with_abstract_geometric_pattern_or_textu_image_265390;
            this.ClientSize = new System.Drawing.Size(731, 468);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.dtpDatumUvjerenja);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtInvaliditet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRadnaSposobnost);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IzdataUvjerenjaUredi";
            this.Text = "IzdataUvjerenjaUredi";
            //this.Load += new System.EventHandler(this.IzdataUvjerenjaUredi_Load);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRadnaSposobnost;
        private System.Windows.Forms.TextBox txtInvaliditet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDatumUvjerenja;
        private System.Windows.Forms.Button btnSacuvaj;
    }
}