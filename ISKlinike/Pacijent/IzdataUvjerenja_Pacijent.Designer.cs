
namespace ISKlinike.Pacijent
{
    partial class IzdataUvjerenja_Pacijent
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
            this.lblImePrezime = new System.Windows.Forms.Label();
            this.btnPocetna = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ličniPodaciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oboljenjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nalaziToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.periodičniPreglediToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IzdataUvjerenjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preventivneMjereToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.drugeUstanoveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datumiPosjeteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvRadnaSposobnost = new System.Windows.Forms.DataGridView();
            this.RadnaSposobnost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Invaliditet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumIzmjene = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRadnaSposobnost)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblImePrezime
            // 
            this.lblImePrezime.Font = new System.Drawing.Font("Lucida Handwriting", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImePrezime.ForeColor = System.Drawing.Color.White;
            this.lblImePrezime.Location = new System.Drawing.Point(225, 6);
            this.lblImePrezime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblImePrezime.Name = "lblImePrezime";
            this.lblImePrezime.Size = new System.Drawing.Size(284, 32);
            this.lblImePrezime.TabIndex = 41;
            this.lblImePrezime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPocetna
            // 
            this.btnPocetna.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnPocetna.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnPocetna.Location = new System.Drawing.Point(8, 8);
            this.btnPocetna.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPocetna.Name = "btnPocetna";
            this.btnPocetna.Size = new System.Drawing.Size(93, 26);
            this.btnPocetna.TabIndex = 40;
            this.btnPocetna.Text = "Početna";
            this.btnPocetna.UseVisualStyleBackColor = true;
            this.btnPocetna.Click += new System.EventHandler(this.btnPocetna_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ličniPodaciToolStripMenuItem,
            this.oboljenjaToolStripMenuItem,
            this.nalaziToolStripMenuItem,
            this.periodičniPreglediToolStripMenuItem,
            this.IzdataUvjerenjaToolStripMenuItem,
            this.preventivneMjereToolStripMenuItem1,
            this.drugeUstanoveToolStripMenuItem,
            this.datumiPosjeteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 45);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(744, 24);
            this.menuStrip1.TabIndex = 42;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ličniPodaciToolStripMenuItem
            // 
            this.ličniPodaciToolStripMenuItem.Name = "ličniPodaciToolStripMenuItem";
            this.ličniPodaciToolStripMenuItem.Size = new System.Drawing.Size(83, 22);
            this.ličniPodaciToolStripMenuItem.Text = "Lični podaci";
            this.ličniPodaciToolStripMenuItem.Click += new System.EventHandler(this.ličniPodaciToolStripMenuItem_Click);
            // 
            // oboljenjaToolStripMenuItem
            // 
            this.oboljenjaToolStripMenuItem.Name = "oboljenjaToolStripMenuItem";
            this.oboljenjaToolStripMenuItem.Size = new System.Drawing.Size(70, 22);
            this.oboljenjaToolStripMenuItem.Text = "Oboljenja";
            this.oboljenjaToolStripMenuItem.Click += new System.EventHandler(this.oboljenjaToolStripMenuItem_Click);
            // 
            // nalaziToolStripMenuItem
            // 
            this.nalaziToolStripMenuItem.Name = "nalaziToolStripMenuItem";
            this.nalaziToolStripMenuItem.Size = new System.Drawing.Size(51, 22);
            this.nalaziToolStripMenuItem.Text = "Nalazi";
            this.nalaziToolStripMenuItem.Click += new System.EventHandler(this.nalaziToolStripMenuItem_Click);
            // 
            // periodičniPreglediToolStripMenuItem
            // 
            this.periodičniPreglediToolStripMenuItem.Name = "periodičniPreglediToolStripMenuItem";
            this.periodičniPreglediToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.periodičniPreglediToolStripMenuItem.Text = "Periodični pregledi";
            this.periodičniPreglediToolStripMenuItem.Click += new System.EventHandler(this.periodičniPreglediToolStripMenuItem_Click);
            // 
            // IzdataUvjerenjaToolStripMenuItem
            // 
            this.IzdataUvjerenjaToolStripMenuItem.Name = "IzdataUvjerenjaToolStripMenuItem";
            this.IzdataUvjerenjaToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.IzdataUvjerenjaToolStripMenuItem.Text = "Izdata uvjerenja";
            // 
            // preventivneMjereToolStripMenuItem1
            // 
            this.preventivneMjereToolStripMenuItem1.Name = "preventivneMjereToolStripMenuItem1";
            this.preventivneMjereToolStripMenuItem1.Size = new System.Drawing.Size(114, 22);
            this.preventivneMjereToolStripMenuItem1.Text = "Preventivne mjere";
            this.preventivneMjereToolStripMenuItem1.Click += new System.EventHandler(this.preventivneMjereToolStripMenuItem1_Click);
            // 
            // drugeUstanoveToolStripMenuItem
            // 
            this.drugeUstanoveToolStripMenuItem.Name = "drugeUstanoveToolStripMenuItem";
            this.drugeUstanoveToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.drugeUstanoveToolStripMenuItem.Text = "Druge ustanove";
            this.drugeUstanoveToolStripMenuItem.Click += new System.EventHandler(this.drugeUstanoveToolStripMenuItem_Click);
            // 
            // datumiPosjeteToolStripMenuItem
            // 
            this.datumiPosjeteToolStripMenuItem.Name = "datumiPosjeteToolStripMenuItem";
            this.datumiPosjeteToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.datumiPosjeteToolStripMenuItem.Text = "Datumi posjete";
            this.datumiPosjeteToolStripMenuItem.Click += new System.EventHandler(this.datumiPosjeteToolStripMenuItem_Click);
            // 
            // dgvRadnaSposobnost
            // 
            this.dgvRadnaSposobnost.AllowUserToAddRows = false;
            this.dgvRadnaSposobnost.AllowUserToDeleteRows = false;
            this.dgvRadnaSposobnost.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRadnaSposobnost.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRadnaSposobnost.ColumnHeadersHeight = 34;
            this.dgvRadnaSposobnost.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RadnaSposobnost,
            this.Invaliditet,
            this.DatumIzmjene});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRadnaSposobnost.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRadnaSposobnost.EnableHeadersVisualStyles = false;
            this.dgvRadnaSposobnost.Location = new System.Drawing.Point(23, 121);
            this.dgvRadnaSposobnost.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvRadnaSposobnost.Name = "dgvRadnaSposobnost";
            this.dgvRadnaSposobnost.ReadOnly = true;
            this.dgvRadnaSposobnost.RowHeadersVisible = false;
            this.dgvRadnaSposobnost.RowHeadersWidth = 62;
            this.dgvRadnaSposobnost.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvRadnaSposobnost.RowTemplate.Height = 28;
            this.dgvRadnaSposobnost.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRadnaSposobnost.Size = new System.Drawing.Size(691, 328);
            this.dgvRadnaSposobnost.TabIndex = 44;
            this.dgvRadnaSposobnost.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRadnaSposobnost_CellContentClick);
            // 
            // RadnaSposobnost
            // 
            this.RadnaSposobnost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RadnaSposobnost.DataPropertyName = "RadnaSposobnost";
            this.RadnaSposobnost.HeaderText = "Radna sposobnost";
            this.RadnaSposobnost.MinimumWidth = 8;
            this.RadnaSposobnost.Name = "RadnaSposobnost";
            this.RadnaSposobnost.ReadOnly = true;
            // 
            // Invaliditet
            // 
            this.Invaliditet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Invaliditet.DataPropertyName = "Invaliditet";
            this.Invaliditet.HeaderText = "Invaliditet (stepen)";
            this.Invaliditet.MinimumWidth = 8;
            this.Invaliditet.Name = "Invaliditet";
            this.Invaliditet.ReadOnly = true;
            // 
            // DatumIzmjene
            // 
            this.DatumIzmjene.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DatumIzmjene.DataPropertyName = "DatumIzmjene";
            this.DatumIzmjene.HeaderText = "Datum izmjene";
            this.DatumIzmjene.MinimumWidth = 8;
            this.DatumIzmjene.Name = "DatumIzmjene";
            this.DatumIzmjene.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(20, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 22);
            this.label1.TabIndex = 43;
            this.label1.Text = "Podaci o radnoj sposobnosti:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Controls.Add(this.btnPocetna);
            this.panel1.Controls.Add(this.lblImePrezime);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(742, 66);
            this.panel1.TabIndex = 45;
            // 
            // IzdataUvjerenja_Pacijent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImage = global::ISKlinike.Properties.Resources.pngtree_vector_white_background_with_abstract_geometric_pattern_or_textu_image_265390;
            this.ClientSize = new System.Drawing.Size(737, 473);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvRadnaSposobnost);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "IzdataUvjerenja_Pacijent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IzdataUvjerenja_Pacijent";
            this.Load += new System.EventHandler(this.IzdataUvjerenja_Pacijent_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRadnaSposobnost)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblImePrezime;
        private System.Windows.Forms.Button btnPocetna;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ličniPodaciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oboljenjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nalaziToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem periodičniPreglediToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem IzdataUvjerenjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preventivneMjereToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem drugeUstanoveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datumiPosjeteToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvRadnaSposobnost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn RadnaSposobnost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Invaliditet;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumIzmjene;
        private System.Windows.Forms.Panel panel1;
    }
}