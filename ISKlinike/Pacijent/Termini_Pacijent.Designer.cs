
namespace ISKlinike
{
    partial class Termini_Pacijent
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Termini_Pacijent));
            this.dgvTermini = new System.Windows.Forms.DataGridView();
            this.DatumVrijemePregleda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Doktor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RazlogPosjete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNoviTermin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMinimiye = new System.Windows.Forms.Button();
            this.lblDobrodosliKorisnik = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.dtpPretraga = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOcisti = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTermini)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTermini
            // 
            this.dgvTermini.AllowUserToAddRows = false;
            this.dgvTermini.AllowUserToDeleteRows = false;
            this.dgvTermini.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTermini.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTermini.ColumnHeadersHeight = 34;
            this.dgvTermini.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DatumVrijemePregleda,
            this.Doktor,
            this.RazlogPosjete});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTermini.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTermini.EnableHeadersVisualStyles = false;
            this.dgvTermini.Location = new System.Drawing.Point(34, 157);
            this.dgvTermini.Margin = new System.Windows.Forms.Padding(2);
            this.dgvTermini.Name = "dgvTermini";
            this.dgvTermini.ReadOnly = true;
            this.dgvTermini.RowHeadersVisible = false;
            this.dgvTermini.RowHeadersWidth = 62;
            this.dgvTermini.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvTermini.RowTemplate.Height = 28;
            this.dgvTermini.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTermini.Size = new System.Drawing.Size(597, 250);
            this.dgvTermini.TabIndex = 0;
            this.dgvTermini.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTermini_CellContentClick);
            // 
            // DatumVrijemePregleda
            // 
            this.DatumVrijemePregleda.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DatumVrijemePregleda.DataPropertyName = "DatumVrijemePregleda";
            this.DatumVrijemePregleda.HeaderText = "Datum i vrijeme pregelda";
            this.DatumVrijemePregleda.MinimumWidth = 8;
            this.DatumVrijemePregleda.Name = "DatumVrijemePregleda";
            this.DatumVrijemePregleda.ReadOnly = true;
            // 
            // Doktor
            // 
            this.Doktor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Doktor.DataPropertyName = "Doktor";
            this.Doktor.HeaderText = "Doktor";
            this.Doktor.MinimumWidth = 8;
            this.Doktor.Name = "Doktor";
            this.Doktor.ReadOnly = true;
            // 
            // RazlogPosjete
            // 
            this.RazlogPosjete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RazlogPosjete.DataPropertyName = "RazlogPosjete";
            this.RazlogPosjete.HeaderText = "Razlog posjete";
            this.RazlogPosjete.MinimumWidth = 8;
            this.RazlogPosjete.Name = "RazlogPosjete";
            this.RazlogPosjete.ReadOnly = true;
            // 
            // btnNoviTermin
            // 
            this.btnNoviTermin.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnNoviTermin.FlatAppearance.BorderSize = 2;
            this.btnNoviTermin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNoviTermin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnNoviTermin.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnNoviTermin.Location = new System.Drawing.Point(167, 423);
            this.btnNoviTermin.Margin = new System.Windows.Forms.Padding(2);
            this.btnNoviTermin.Name = "btnNoviTermin";
            this.btnNoviTermin.Size = new System.Drawing.Size(300, 32);
            this.btnNoviTermin.TabIndex = 4;
            this.btnNoviTermin.Text = "Zakaži novi termin";
            this.btnNoviTermin.UseVisualStyleBackColor = true;
            this.btnNoviTermin.Click += new System.EventHandler(this.btnNoviTermin_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.btnMinimiye);
            this.panel1.Controls.Add(this.lblDobrodosliKorisnik);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(667, 56);
            this.panel1.TabIndex = 28;
            // 
            // btnMinimiye
            // 
            this.btnMinimiye.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimiye.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimiye.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnMinimiye.Location = new System.Drawing.Point(617, 12);
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
            this.lblDobrodosliKorisnik.Size = new System.Drawing.Size(212, 27);
            this.lblDobrodosliKorisnik.TabIndex = 0;
            this.lblDobrodosliKorisnik.Text = "Termini pregleda";
            this.lblDobrodosliKorisnik.UseMnemonic = false;
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnClose.Location = new System.Drawing.Point(583, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 30);
            this.btnClose.TabIndex = 5;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dtpPretraga
            // 
            this.dtpPretraga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPretraga.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPretraga.Location = new System.Drawing.Point(34, 108);
            this.dtpPretraga.Margin = new System.Windows.Forms.Padding(2);
            this.dtpPretraga.Name = "dtpPretraga";
            this.dtpPretraga.Size = new System.Drawing.Size(177, 26);
            this.dtpPretraga.TabIndex = 32;
            this.dtpPretraga.ValueChanged += new System.EventHandler(this.dtpPretraga_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(405, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Pretrži termin (ime ili prezime):";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(365, 108);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // txtPretraga
            // 
            this.txtPretraga.BackColor = System.Drawing.Color.White;
            this.txtPretraga.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPretraga.ForeColor = System.Drawing.Color.Black;
            this.txtPretraga.Location = new System.Drawing.Point(408, 108);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(224, 30);
            this.txtPretraga.TabIndex = 29;
            this.txtPretraga.TextChanged += new System.EventHandler(this.txtPretraga_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(31, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Pretrži termin po datumu:";
            // 
            // btnOcisti
            // 
            this.btnOcisti.ForeColor = System.Drawing.Color.Red;
            this.btnOcisti.Location = new System.Drawing.Point(636, 111);
            this.btnOcisti.Name = "btnOcisti";
            this.btnOcisti.Size = new System.Drawing.Size(27, 23);
            this.btnOcisti.TabIndex = 34;
            this.btnOcisti.Text = "X";
            this.btnOcisti.UseVisualStyleBackColor = true;
            this.btnOcisti.Click += new System.EventHandler(this.btnOcisti_Click);
            // 
            // Termini_Pacijent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImage = global::ISKlinike.Properties.Resources.pngtree_vector_white_background_with_abstract_geometric_pattern_or_textu_image_265390;
            this.ClientSize = new System.Drawing.Size(667, 473);
            this.Controls.Add(this.btnOcisti);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpPretraga);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnNoviTermin);
            this.Controls.Add(this.dgvTermini);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Termini_Pacijent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "termini_Pacijent";
            this.Load += new System.EventHandler(this.Termini_Pacijent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTermini)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTermini;
        private System.Windows.Forms.Button btnNoviTermin;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumVrijemePregleda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Doktor;
        private System.Windows.Forms.DataGridViewTextBoxColumn RazlogPosjete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMinimiye;
        private System.Windows.Forms.Label lblDobrodosliKorisnik;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DateTimePicker dtpPretraga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOcisti;
    }
}