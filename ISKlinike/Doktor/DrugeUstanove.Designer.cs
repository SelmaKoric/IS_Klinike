
namespace ISKlinike
{
    partial class DrugeUstanove
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
            this.btnUredi = new System.Windows.Forms.Button();
            this.dgvDrugeUstanove = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OtpusnaDijagnoza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uputstvo = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbUputstvoZaTretman = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrugeUstanove)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUredi
            // 
            this.btnUredi.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.btnUredi.BackColor = System.Drawing.Color.LightGray;
            this.btnUredi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUredi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUredi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUredi.ForeColor = System.Drawing.Color.Red;
            this.btnUredi.Location = new System.Drawing.Point(1064, 791);
            this.btnUredi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(225, 54);
            this.btnUredi.TabIndex = 21;
            this.btnUredi.Text = "Uredi";
            this.btnUredi.UseVisualStyleBackColor = false;
            this.btnUredi.Click += new System.EventHandler(this.btnUredi_Click);
            // 
            // dgvDrugeUstanove
            // 
            this.dgvDrugeUstanove.AllowUserToAddRows = false;
            this.dgvDrugeUstanove.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvDrugeUstanove.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDrugeUstanove.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDrugeUstanove.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDrugeUstanove.ColumnHeadersHeight = 40;
            this.dgvDrugeUstanove.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDrugeUstanove.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.OtpusnaDijagnoza,
            this.Uputstvo});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDrugeUstanove.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDrugeUstanove.EnableHeadersVisualStyles = false;
            this.dgvDrugeUstanove.Location = new System.Drawing.Point(40, 83);
            this.dgvDrugeUstanove.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvDrugeUstanove.Name = "dgvDrugeUstanove";
            this.dgvDrugeUstanove.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDrugeUstanove.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDrugeUstanove.RowHeadersVisible = false;
            this.dgvDrugeUstanove.RowHeadersWidth = 62;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvDrugeUstanove.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDrugeUstanove.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDrugeUstanove.Size = new System.Drawing.Size(1248, 422);
            this.dgvDrugeUstanove.TabIndex = 22;
            this.dgvDrugeUstanove.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDrugeUstanove_CellContentClick);
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "NazivUstanove";
            this.dataGridViewTextBoxColumn6.HeaderText = "Naziv ustanove";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "LijecenOd";
            this.dataGridViewTextBoxColumn7.HeaderText = "Liječen od";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "LijecenDo";
            this.dataGridViewTextBoxColumn8.HeaderText = "Liječen do";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // OtpusnaDijagnoza
            // 
            this.OtpusnaDijagnoza.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OtpusnaDijagnoza.DataPropertyName = "OtpusnaDijagnoza";
            this.OtpusnaDijagnoza.HeaderText = "Otpusna dijagnoza";
            this.OtpusnaDijagnoza.MinimumWidth = 8;
            this.OtpusnaDijagnoza.Name = "OtpusnaDijagnoza";
            this.OtpusnaDijagnoza.ReadOnly = true;
            // 
            // Uputstvo
            // 
            this.Uputstvo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Uputstvo.DataPropertyName = "none";
            this.Uputstvo.HeaderText = "Uputstvo za daljnji tretman";
            this.Uputstvo.MinimumWidth = 8;
            this.Uputstvo.Name = "Uputstvo";
            this.Uputstvo.ReadOnly = true;
            this.Uputstvo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Uputstvo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Uputstvo.Text = "UPUTSTVO";
            this.Uputstvo.UseColumnTextForButtonValue = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(491, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "Podaci o boravku pacijenta u drugim ustanovama:";
            // 
            // rtbUputstvoZaTretman
            // 
            this.rtbUputstvoZaTretman.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbUputstvoZaTretman.Location = new System.Drawing.Point(40, 558);
            this.rtbUputstvoZaTretman.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtbUputstvoZaTretman.Name = "rtbUputstvoZaTretman";
            this.rtbUputstvoZaTretman.ReadOnly = true;
            this.rtbUputstvoZaTretman.Size = new System.Drawing.Size(1246, 193);
            this.rtbUputstvoZaTretman.TabIndex = 32;
            this.rtbUputstvoZaTretman.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(36, 526);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(437, 29);
            this.label6.TabIndex = 31;
            this.label6.Text = "Uputstvo ustanove za daljnji tretman:";
            // 
            // DrugeUstanove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ISKlinike.Properties.Resources.pngtree_vector_white_background_with_abstract_geometric_pattern_or_textu_image_265390;
            this.ClientSize = new System.Drawing.Size(1323, 886);
            this.Controls.Add(this.rtbUputstvoZaTretman);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDrugeUstanove);
            this.Controls.Add(this.btnUredi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DrugeUstanove";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "DrugeUstanove";
            this.Load += new System.EventHandler(this.DrugeUstanove_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrugeUstanove)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.DataGridView dgvDrugeUstanove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbUputstvoZaTretman;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn OtpusnaDijagnoza;
        private System.Windows.Forms.DataGridViewButtonColumn Uputstvo;
    }
}