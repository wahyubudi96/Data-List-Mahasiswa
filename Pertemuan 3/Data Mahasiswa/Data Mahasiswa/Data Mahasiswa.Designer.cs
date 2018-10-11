namespace Data_Mahasiswa
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mskNpm = new System.Windows.Forms.MaskedTextBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.rdoLakiLaki = new System.Windows.Forms.RadioButton();
            this.rdoPerempuan = new System.Windows.Forms.RadioButton();
            this.btnTutup = new System.Windows.Forms.Button();
            this.btnTampil = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "NPM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Jenis Kelamin";
            // 
            // mskNpm
            // 
            this.mskNpm.Location = new System.Drawing.Point(113, 6);
            this.mskNpm.Mask = "##.##.####";
            this.mskNpm.Name = "mskNpm";
            this.mskNpm.Size = new System.Drawing.Size(71, 22);
            this.mskNpm.TabIndex = 3;
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(113, 53);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(194, 22);
            this.txtNama.TabIndex = 4;
            // 
            // rdoLakiLaki
            // 
            this.rdoLakiLaki.AutoSize = true;
            this.rdoLakiLaki.Location = new System.Drawing.Point(113, 105);
            this.rdoLakiLaki.Name = "rdoLakiLaki";
            this.rdoLakiLaki.Size = new System.Drawing.Size(86, 21);
            this.rdoLakiLaki.TabIndex = 5;
            this.rdoLakiLaki.TabStop = true;
            this.rdoLakiLaki.Text = "Laki-Laki";
            this.rdoLakiLaki.UseVisualStyleBackColor = true;
            // 
            // rdoPerempuan
            // 
            this.rdoPerempuan.AutoSize = true;
            this.rdoPerempuan.Location = new System.Drawing.Point(205, 105);
            this.rdoPerempuan.Name = "rdoPerempuan";
            this.rdoPerempuan.Size = new System.Drawing.Size(102, 21);
            this.rdoPerempuan.TabIndex = 6;
            this.rdoPerempuan.TabStop = true;
            this.rdoPerempuan.Text = "Perempuan";
            this.rdoPerempuan.UseVisualStyleBackColor = true;
            // 
            // btnTutup
            // 
            this.btnTutup.Location = new System.Drawing.Point(15, 157);
            this.btnTutup.Name = "btnTutup";
            this.btnTutup.Size = new System.Drawing.Size(77, 32);
            this.btnTutup.TabIndex = 7;
            this.btnTutup.Text = "Tutup";
            this.btnTutup.UseVisualStyleBackColor = true;
            this.btnTutup.Click += new System.EventHandler(this.btnTutup_Click);
            // 
            // btnTampil
            // 
            this.btnTampil.Location = new System.Drawing.Point(230, 157);
            this.btnTampil.Name = "btnTampil";
            this.btnTampil.Size = new System.Drawing.Size(77, 32);
            this.btnTampil.TabIndex = 8;
            this.btnTampil.Text = "Tampil";
            this.btnTampil.UseVisualStyleBackColor = true;
            this.btnTampil.Click += new System.EventHandler(this.btnTampil_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(172, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Created by : WaBud";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 226);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnTampil);
            this.Controls.Add(this.btnTutup);
            this.Controls.Add(this.rdoPerempuan);
            this.Controls.Add(this.rdoLakiLaki);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.mskNpm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Mahasiswa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mskNpm;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.RadioButton rdoLakiLaki;
        private System.Windows.Forms.RadioButton rdoPerempuan;
        private System.Windows.Forms.Button btnTutup;
        private System.Windows.Forms.Button btnTampil;
        private System.Windows.Forms.Label label4;
    }
}

