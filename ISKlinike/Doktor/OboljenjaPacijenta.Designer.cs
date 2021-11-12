
namespace ISKlinike
{
    partial class OboljenjaPacijenta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnDatumiPosjeta = new System.Windows.Forms.Button();
            this.btnNesposobnostiZaRad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvOboljenja = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uputnica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUredi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOboljenja)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDatumiPosjeta
            // 
            this.btnDatumiPosjeta.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.btnDatumiPosjeta.BackColor = System.Drawing.Color.LightGray;
            this.btnDatumiPosjeta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDatumiPosjeta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatumiPosjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatumiPosjeta.ForeColor = System.Drawing.Color.Red;
            this.btnDatumiPosjeta.Location = new System.Drawing.Point(441, 55);
            this.btnDatumiPosjeta.Name = "btnDatumiPosjeta";
            this.btnDatumiPosjeta.Size = new System.Drawing.Size(192, 48);
            this.btnDatumiPosjeta.TabIndex = 7;
            this.btnDatumiPosjeta.Text = "Datumi dolazaka";
            this.btnDatumiPosjeta.UseVisualStyleBackColor = false;
            this.btnDatumiPosjeta.Click += new System.EventHandler(this.btnDatumiPosjeta_Click);
            // 
            // btnNesposobnostiZaRad
            // 
            this.btnNesposobnostiZaRad.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.btnNesposobnostiZaRad.BackColor = System.Drawing.Color.LightGray;
            this.btnNesposobnostiZaRad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNesposobnostiZaRad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNesposobnostiZaRad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNesposobnostiZaRad.ForeColor = System.Drawing.Color.Red;
            this.btnNesposobnostiZaRad.Location = new System.Drawing.Point(224, 55);
            this.btnNesposobnostiZaRad.Name = "btnNesposobnostiZaRad";
            this.btnNesposobnostiZaRad.Size = new System.Drawing.Size(193, 48);
            this.btnNesposobnostiZaRad.TabIndex = 8;
            this.btnNesposobnostiZaRad.Text = "Nesposobnosti za rad";
            this.btnNesposobnostiZaRad.UseVisualStyleBackColor = false;
            this.btnNesposobnostiZaRad.Click += new System.EventHandler(this.btnNesposobnostiZaRad_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Evidencija o oboljenjima:";
            // 
            // dgvOboljenja
            // 
            this.dgvOboljenja.AllowUserToAddRows = false;
            this.dgvOboljenja.AllowUserToDeleteRows = false;
            this.dgvOboljenja.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvOboljenja.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOboljenja.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOboljenja.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOboljenja.ColumnHeadersHeight = 40;
            this.dgvOboljenja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvOboljenja.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.Uputnica});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOboljenja.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvOboljenja.EnableHeadersVisualStyles = false;
            this.dgvOboljenja.Location = new System.Drawing.Point(12, 147);
            this.dgvOboljenja.Name = "dgvOboljenja";
            this.dgvOboljenja.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOboljenja.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvOboljenja.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvOboljenja.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvOboljenja.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOboljenja.Size = new System.Drawing.Size(832, 282);
            this.dgvOboljenja.TabIndex = 13;
            this.dgvOboljenja.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOboljenja_CellContentClick);
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Dijagnoza";
            this.dataGridViewTextBoxColumn6.HeaderText = "Dijagnoza (radna i konačna):";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ŠifraPoMKB";
            this.dataGridViewTextBoxColumn7.HeaderText = "Šifra oboljenja po MKB:";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "DatumTerapije";
            this.dataGridViewTextBoxColumn8.HeaderText = "Datum terapije:";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "VrstaTerapije";
            this.dataGridViewTextBoxColumn9.HeaderText = "Vrsta terapije:";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn10.DataPropertyName = "VrijemeTerapije";
            this.dataGridViewTextBoxColumn10.HeaderText = "Vrijeme uzimanja terapije:";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // Uputnica
            // 
            this.Uputnica.DataPropertyName = "Uputnica";
            this.Uputnica.HeaderText = "Uputnica:";
            this.Uputnica.Name = "Uputnica";
            this.Uputnica.ReadOnly = true;
            // 
            // btnUredi
            // 
            this.btnUredi.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.btnUredi.BackColor = System.Drawing.Color.LightGray;
            this.btnUredi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUredi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUredi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUredi.ForeColor = System.Drawing.Color.Red;
            this.btnUredi.Location = new System.Drawing.Point(715, 458);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(124, 35);
            this.btnUredi.TabIndex = 14;
            this.btnUredi.Text = "Uredi";
            this.btnUredi.UseVisualStyleBackColor = false;
            this.btnUredi.Click += new System.EventHandler(this.btnUredi_Click);
            // 
            // OboljenjaPacijenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ISKlinike.Properties.Resources.pngtree_vector_white_background_with_abstract_geometric_pattern_or_textu_image_265390;
            this.ClientSize = new System.Drawing.Size(851, 509);
            this.Controls.Add(this.btnUredi);
            this.Controls.Add(this.dgvOboljenja);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNesposobnostiZaRad);
            this.Controls.Add(this.btnDatumiPosjeta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OboljenjaPacijenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "OboljenjaPacijenta";
            this.Load += new System.EventHandler(this.OboljenjaPacijenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOboljenja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDatumiPosjeta;
        private System.Windows.Forms.Button btnNesposobnostiZaRad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvOboljenja;
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Uputnica;
    }
}