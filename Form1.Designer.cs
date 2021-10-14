
namespace WinFormsApp1
{
    partial class frmTugas1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPesan2 = new System.Windows.Forms.TextBox();
            this.txtPesan3 = new System.Windows.Forms.TextBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtPesan1 = new System.Windows.Forms.TextBox();
            this.cmbPendidikan = new System.Windows.Forms.ComboBox();
            this.lstPekerjaan = new System.Windows.Forms.ListBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pendidikan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pekerjaan";
            // 
            // txtPesan2
            // 
            this.txtPesan2.Enabled = false;
            this.txtPesan2.Location = new System.Drawing.Point(259, 301);
            this.txtPesan2.Name = "txtPesan2";
            this.txtPesan2.Size = new System.Drawing.Size(529, 23);
            this.txtPesan2.TabIndex = 4;
            // 
            // txtPesan3
            // 
            this.txtPesan3.Enabled = false;
            this.txtPesan3.Location = new System.Drawing.Point(259, 330);
            this.txtPesan3.Name = "txtPesan3";
            this.txtPesan3.Size = new System.Drawing.Size(529, 23);
            this.txtPesan3.TabIndex = 5;
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(259, 0);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(529, 23);
            this.txtNama.TabIndex = 6;
            this.txtNama.TextChanged += new System.EventHandler(this.txtNama_TextChanged);
            // 
            // txtPesan1
            // 
            this.txtPesan1.Enabled = false;
            this.txtPesan1.Location = new System.Drawing.Point(259, 272);
            this.txtPesan1.Name = "txtPesan1";
            this.txtPesan1.Size = new System.Drawing.Size(529, 23);
            this.txtPesan1.TabIndex = 7;
            // 
            // cmbPendidikan
            // 
            this.cmbPendidikan.FormattingEnabled = true;
            this.cmbPendidikan.Items.AddRange(new object[] {
            "SD",
            "SMP",
            "SMA",
            "Diploma",
            "Sarjana",
            "Pascasarjana"});
            this.cmbPendidikan.Location = new System.Drawing.Point(259, 68);
            this.cmbPendidikan.Name = "cmbPendidikan";
            this.cmbPendidikan.Size = new System.Drawing.Size(529, 23);
            this.cmbPendidikan.TabIndex = 10;
            // 
            // lstPekerjaan
            // 
            this.lstPekerjaan.FormattingEnabled = true;
            this.lstPekerjaan.ItemHeight = 15;
            this.lstPekerjaan.Items.AddRange(new object[] {
            "Pedagang",
            "PNS",
            "Dosen",
            "Swasta",
            "ABRI"});
            this.lstPekerjaan.Location = new System.Drawing.Point(259, 145);
            this.lstPekerjaan.Name = "lstPekerjaan";
            this.lstPekerjaan.Size = new System.Drawing.Size(529, 94);
            this.lstPekerjaan.TabIndex = 12;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(326, 415);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 13;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // frmTugas1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lstPekerjaan);
            this.Controls.Add(this.cmbPendidikan);
            this.Controls.Add(this.txtPesan1);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.txtPesan3);
            this.Controls.Add(this.txtPesan2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmTugas1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tugas1";
            this.Load += new System.EventHandler(this.frmTugas1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPesan2;
        private System.Windows.Forms.TextBox txtPesan3;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtPesan1;
        private System.Windows.Forms.ComboBox cmbPendidikan;
        private System.Windows.Forms.ListBox lstPekerjaan;
        private System.Windows.Forms.Button btnOK;
    }
}

