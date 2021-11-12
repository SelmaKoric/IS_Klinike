
namespace ISKlinike
{
    partial class PreventivneMjere
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
            this.rtbPreventivneMjere = new System.Windows.Forms.RichTextBox();
            this.dtpDatumPregleda = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUredi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Na preventivnom pregledu utvrđeno:";
            // 
            // rtbPreventivneMjere
            // 
            this.rtbPreventivneMjere.BackColor = System.Drawing.Color.MistyRose;
            this.rtbPreventivneMjere.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbPreventivneMjere.ForeColor = System.Drawing.Color.Black;
            this.rtbPreventivneMjere.Location = new System.Drawing.Point(12, 100);
            this.rtbPreventivneMjere.Name = "rtbPreventivneMjere";
            this.rtbPreventivneMjere.ReadOnly = true;
            this.rtbPreventivneMjere.Size = new System.Drawing.Size(813, 268);
            this.rtbPreventivneMjere.TabIndex = 1;
            this.rtbPreventivneMjere.Text = "";
            // 
            // dtpDatumPregleda
            // 
            this.dtpDatumPregleda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDatumPregleda.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatumPregleda.Location = new System.Drawing.Point(639, 51);
            this.dtpDatumPregleda.Name = "dtpDatumPregleda";
            this.dtpDatumPregleda.Size = new System.Drawing.Size(200, 29);
            this.dtpDatumPregleda.TabIndex = 2;
            this.dtpDatumPregleda.ValueChanged += new System.EventHandler(this.dtpDatumPregleda_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(622, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pretraga po datumu pregleda:";
            // 
            // btnUredi
            // 
            this.btnUredi.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.btnUredi.BackColor = System.Drawing.Color.LightGray;
            this.btnUredi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUredi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUredi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUredi.ForeColor = System.Drawing.Color.Red;
            this.btnUredi.Location = new System.Drawing.Point(701, 411);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(124, 35);
            this.btnUredi.TabIndex = 15;
            this.btnUredi.Text = "Uredi";
            this.btnUredi.UseVisualStyleBackColor = false;
            this.btnUredi.Click += new System.EventHandler(this.btnUredi_Click);
            // 
            // PreventivneMjere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ISKlinike.Properties.Resources.pngtree_vector_white_background_with_abstract_geometric_pattern_or_textu_image_265390;
            this.ClientSize = new System.Drawing.Size(851, 477);
            this.Controls.Add(this.btnUredi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpDatumPregleda);
            this.Controls.Add(this.rtbPreventivneMjere);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PreventivneMjere";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "PreventivneMjere";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbPreventivneMjere;
        private System.Windows.Forms.DateTimePicker dtpDatumPregleda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUredi;
    }
}