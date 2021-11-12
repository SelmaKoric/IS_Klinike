
namespace ISKlinike
{
    partial class NalaziPacijenta
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnPorodicnaAnamneza = new System.Windows.Forms.Button();
            this.btnLicnaAnamneza = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbAnamneze = new System.Windows.Forms.RichTextBox();
            this.btnUredi = new System.Windows.Forms.Button();
            this.btnRadnaAnamn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pretraga po datumu posjete:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(13, 60);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged_1);
            // 
            // btnPorodicnaAnamneza
            // 
            this.btnPorodicnaAnamneza.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.btnPorodicnaAnamneza.BackColor = System.Drawing.Color.Gainsboro;
            this.btnPorodicnaAnamneza.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPorodicnaAnamneza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPorodicnaAnamneza.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPorodicnaAnamneza.ForeColor = System.Drawing.Color.Red;
            this.btnPorodicnaAnamneza.Location = new System.Drawing.Point(202, 98);
            this.btnPorodicnaAnamneza.Name = "btnPorodicnaAnamneza";
            this.btnPorodicnaAnamneza.Size = new System.Drawing.Size(183, 35);
            this.btnPorodicnaAnamneza.TabIndex = 8;
            this.btnPorodicnaAnamneza.Text = "Porodična anamneza";
            this.btnPorodicnaAnamneza.UseVisualStyleBackColor = false;
            this.btnPorodicnaAnamneza.Click += new System.EventHandler(this.btnPorodicnaAnamneza_Click);
            // 
            // btnLicnaAnamneza
            // 
            this.btnLicnaAnamneza.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.btnLicnaAnamneza.BackColor = System.Drawing.Color.Gainsboro;
            this.btnLicnaAnamneza.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLicnaAnamneza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLicnaAnamneza.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLicnaAnamneza.ForeColor = System.Drawing.Color.Red;
            this.btnLicnaAnamneza.Location = new System.Drawing.Point(13, 98);
            this.btnLicnaAnamneza.Name = "btnLicnaAnamneza";
            this.btnLicnaAnamneza.Size = new System.Drawing.Size(183, 35);
            this.btnLicnaAnamneza.TabIndex = 9;
            this.btnLicnaAnamneza.Text = "Lična anamneza";
            this.btnLicnaAnamneza.UseVisualStyleBackColor = false;
            this.btnLicnaAnamneza.Click += new System.EventHandler(this.btnLicnaAnamneza_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Podaci o anamnezama:";
            // 
            // rtbAnamneze
            // 
            this.rtbAnamneze.BackColor = System.Drawing.Color.MistyRose;
            this.rtbAnamneze.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbAnamneze.ForeColor = System.Drawing.Color.Black;
            this.rtbAnamneze.Location = new System.Drawing.Point(16, 180);
            this.rtbAnamneze.Name = "rtbAnamneze";
            this.rtbAnamneze.ReadOnly = true;
            this.rtbAnamneze.Size = new System.Drawing.Size(789, 280);
            this.rtbAnamneze.TabIndex = 11;
            this.rtbAnamneze.Text = "";
            // 
            // btnUredi
            // 
            this.btnUredi.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.btnUredi.BackColor = System.Drawing.Color.Gainsboro;
            this.btnUredi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUredi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUredi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUredi.ForeColor = System.Drawing.Color.Red;
            this.btnUredi.Location = new System.Drawing.Point(675, 481);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(130, 35);
            this.btnUredi.TabIndex = 13;
            this.btnUredi.Text = "Uredi";
            this.btnUredi.UseVisualStyleBackColor = false;
            this.btnUredi.Click += new System.EventHandler(this.btnUredi_Click);
            // 
            // btnRadnaAnamn
            // 
            this.btnRadnaAnamn.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.btnRadnaAnamn.BackColor = System.Drawing.Color.Gainsboro;
            this.btnRadnaAnamn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRadnaAnamn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRadnaAnamn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRadnaAnamn.ForeColor = System.Drawing.Color.Red;
            this.btnRadnaAnamn.Location = new System.Drawing.Point(391, 98);
            this.btnRadnaAnamn.Name = "btnRadnaAnamn";
            this.btnRadnaAnamn.Size = new System.Drawing.Size(183, 35);
            this.btnRadnaAnamn.TabIndex = 14;
            this.btnRadnaAnamn.Text = "Radna anamneza";
            this.btnRadnaAnamn.UseVisualStyleBackColor = false;
            this.btnRadnaAnamn.Click += new System.EventHandler(this.btnRadnaAnamn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(576, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "i";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // lblInfo
            // 
            this.lblInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblInfo.Location = new System.Drawing.Point(586, 50);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(239, 52);
            this.lblInfo.TabIndex = 16;
            // 
            // NalaziPacijenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ISKlinike.Properties.Resources.pngtree_vector_white_background_with_abstract_geometric_pattern_or_textu_image_265390;
            this.ClientSize = new System.Drawing.Size(837, 544);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRadnaAnamn);
            this.Controls.Add(this.btnUredi);
            this.Controls.Add(this.rtbAnamneze);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLicnaAnamneza);
            this.Controls.Add(this.btnPorodicnaAnamneza);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NalaziPacijenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "NalaziPacijenta";
            this.Load += new System.EventHandler(this.NalaziPacijenta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnPorodicnaAnamneza;
        private System.Windows.Forms.Button btnLicnaAnamneza;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtbAnamneze;
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.Button btnRadnaAnamn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblInfo;
    }
}