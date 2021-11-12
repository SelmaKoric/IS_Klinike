
namespace ISKlinike.Doktor
{
    partial class Termini
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Termini));
            this.dgvTermini = new System.Windows.Forms.DataGridView();
            this.DatumVrijemePregleda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pacijent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RazlogPosjete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNoviTermin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.dtpPretraga = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMinimiye = new System.Windows.Forms.Button();
            this.lblDobrodosliKorisnik = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOcisti = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTermini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTermini
            // 
            this.dgvTermini.AllowUserToAddRows = false;
            this.dgvTermini.AllowUserToDeleteRows = false;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvTermini.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvTermini.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTermini.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvTermini.ColumnHeadersHeight = 40;
            this.dgvTermini.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTermini.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DatumVrijemePregleda,
            this.Pacijent,
            this.RazlogPosjete});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTermini.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgvTermini.EnableHeadersVisualStyles = false;
            this.dgvTermini.Location = new System.Drawing.Point(29, 168);
            this.dgvTermini.Name = "dgvTermini";
            this.dgvTermini.ReadOnly = true;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTermini.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgvTermini.RowHeadersVisible = false;
            this.dgvTermini.RowHeadersWidth = 62;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvTermini.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dgvTermini.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTermini.Size = new System.Drawing.Size(683, 250);
            this.dgvTermini.TabIndex = 14;
            this.dgvTermini.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTermini_CellContentClick);
            // 
            // DatumVrijemePregleda
            // 
            this.DatumVrijemePregleda.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DatumVrijemePregleda.DataPropertyName = "DatumVrijemePregleda";
            this.DatumVrijemePregleda.HeaderText = "Datum i vrijeme pregleda";
            this.DatumVrijemePregleda.MinimumWidth = 8;
            this.DatumVrijemePregleda.Name = "DatumVrijemePregleda";
            this.DatumVrijemePregleda.ReadOnly = true;
            // 
            // Pacijent
            // 
            this.Pacijent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Pacijent.DataPropertyName = "Pacijent";
            this.Pacijent.HeaderText = "Pacijent";
            this.Pacijent.MinimumWidth = 8;
            this.Pacijent.Name = "Pacijent";
            this.Pacijent.ReadOnly = true;
            // 
            // RazlogPosjete
            // 
            this.RazlogPosjete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RazlogPosjete.DataPropertyName = "RazlogPosjete";
            this.RazlogPosjete.HeaderText = "RazlogPosjete";
            this.RazlogPosjete.MinimumWidth = 8;
            this.RazlogPosjete.Name = "RazlogPosjete";
            this.RazlogPosjete.ReadOnly = true;
            // 
            // btnNoviTermin
            // 
            this.btnNoviTermin.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.btnNoviTermin.BackColor = System.Drawing.Color.Gainsboro;
            this.btnNoviTermin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNoviTermin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNoviTermin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNoviTermin.ForeColor = System.Drawing.Color.Red;
            this.btnNoviTermin.Location = new System.Drawing.Point(213, 424);
            this.btnNoviTermin.Name = "btnNoviTermin";
            this.btnNoviTermin.Size = new System.Drawing.Size(280, 35);
            this.btnNoviTermin.TabIndex = 15;
            this.btnNoviTermin.Text = "Zakaži novi termin";
            this.btnNoviTermin.UseVisualStyleBackColor = false;
            this.btnNoviTermin.Click += new System.EventHandler(this.btnNoviTermin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(487, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Pretrži termin (ime ili prezime):";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(436, 115);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // txtPretraga
            // 
            this.txtPretraga.BackColor = System.Drawing.Color.White;
            this.txtPretraga.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPretraga.ForeColor = System.Drawing.Color.Black;
            this.txtPretraga.Location = new System.Drawing.Point(489, 115);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(224, 30);
            this.txtPretraga.TabIndex = 17;
            this.txtPretraga.TextChanged += new System.EventHandler(this.txtPretraga_TextChanged);
            // 
            // dtpPretraga
            // 
            this.dtpPretraga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPretraga.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPretraga.Location = new System.Drawing.Point(45, 115);
            this.dtpPretraga.Margin = new System.Windows.Forms.Padding(2);
            this.dtpPretraga.Name = "dtpPretraga";
            this.dtpPretraga.Size = new System.Drawing.Size(175, 26);
            this.dtpPretraga.TabIndex = 20;
            this.dtpPretraga.ValueChanged += new System.EventHandler(this.dtpPretraga_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.btnMinimiye);
            this.panel1.Controls.Add(this.lblDobrodosliKorisnik);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(739, 54);
            this.panel1.TabIndex = 27;
            // 
            // btnMinimiye
            // 
            this.btnMinimiye.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimiye.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimiye.ForeColor = System.Drawing.Color.Red;
            this.btnMinimiye.Location = new System.Drawing.Point(681, 13);
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
            this.lblDobrodosliKorisnik.Location = new System.Drawing.Point(9, 13);
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
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(647, 13);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 30);
            this.btnClose.TabIndex = 5;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOcisti
            // 
            this.btnOcisti.ForeColor = System.Drawing.Color.Red;
            this.btnOcisti.Location = new System.Drawing.Point(714, 120);
            this.btnOcisti.Name = "btnOcisti";
            this.btnOcisti.Size = new System.Drawing.Size(22, 23);
            this.btnOcisti.TabIndex = 28;
            this.btnOcisti.Text = "X";
            this.btnOcisti.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnOcisti.UseVisualStyleBackColor = true;
            this.btnOcisti.Click += new System.EventHandler(this.btnOcisti_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Pretraži po datumu pregleda:";
            // 
            // Termini
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ISKlinike.Properties.Resources.pngtree_vector_white_background_with_abstract_geometric_pattern_or_textu_image_265390;
            this.ClientSize = new System.Drawing.Size(737, 473);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOcisti);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtpPretraga);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.btnNoviTermin);
            this.Controls.Add(this.dgvTermini);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Termini";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Termini";
            this.Load += new System.EventHandler(this.Termini_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTermini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTermini;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumVrijemePregleda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pacijent;
        private System.Windows.Forms.DataGridViewTextBoxColumn RazlogPosjete;
        private System.Windows.Forms.Button btnNoviTermin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.DateTimePicker dtpPretraga;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMinimiye;
        private System.Windows.Forms.Label lblDobrodosliKorisnik;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOcisti;
        private System.Windows.Forms.Label label2;
    }
}