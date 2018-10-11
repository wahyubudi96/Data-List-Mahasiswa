namespace DataMahasiswa2
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
            this.label6 = new System.Windows.Forms.Label();
            this.btnTampil = new System.Windows.Forms.Button();
            this.btnTutup = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpTanggalLahir = new System.Windows.Forms.DateTimePicker();
            this.txtTempatLahir = new System.Windows.Forms.TextBox();
            this.rdoPerempuan = new System.Windows.Forms.RadioButton();
            this.rdoLakiLaki = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.mskNpm = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(182, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 17);
            this.label6.TabIndex = 29;
            this.label6.Text = "Created by : WaBud";
            // 
            // btnTampil
            // 
            this.btnTampil.Location = new System.Drawing.Point(240, 233);
            this.btnTampil.Name = "btnTampil";
            this.btnTampil.Size = new System.Drawing.Size(77, 32);
            this.btnTampil.TabIndex = 28;
            this.btnTampil.Text = "Tampil";
            this.btnTampil.UseVisualStyleBackColor = true;
            this.btnTampil.Click += new System.EventHandler(this.btnTampil_Click);
            // 
            // btnTutup
            // 
            this.btnTutup.Location = new System.Drawing.Point(12, 233);
            this.btnTutup.Name = "btnTutup";
            this.btnTutup.Size = new System.Drawing.Size(77, 32);
            this.btnTutup.TabIndex = 27;
            this.btnTutup.Text = "Tutup";
            this.btnTutup.UseVisualStyleBackColor = true;
            this.btnTutup.Click += new System.EventHandler(this.btnTutup_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 17);
            this.label5.TabIndex = 26;
            this.label5.Text = "Tanggal Lahir";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Tempat Lahir";
            // 
            // dtpTanggalLahir
            // 
            this.dtpTanggalLahir.CustomFormat = "dd/MM/yyyy";
            this.dtpTanggalLahir.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTanggalLahir.Location = new System.Drawing.Point(117, 186);
            this.dtpTanggalLahir.Name = "dtpTanggalLahir";
            this.dtpTanggalLahir.Size = new System.Drawing.Size(200, 22);
            this.dtpTanggalLahir.TabIndex = 24;
            // 
            // txtTempatLahir
            // 
            this.txtTempatLahir.Location = new System.Drawing.Point(117, 146);
            this.txtTempatLahir.Name = "txtTempatLahir";
            this.txtTempatLahir.Size = new System.Drawing.Size(200, 22);
            this.txtTempatLahir.TabIndex = 23;
            // 
            // rdoPerempuan
            // 
            this.rdoPerempuan.AutoSize = true;
            this.rdoPerempuan.Location = new System.Drawing.Point(209, 109);
            this.rdoPerempuan.Name = "rdoPerempuan";
            this.rdoPerempuan.Size = new System.Drawing.Size(102, 21);
            this.rdoPerempuan.TabIndex = 22;
            this.rdoPerempuan.TabStop = true;
            this.rdoPerempuan.Text = "Perempuan";
            this.rdoPerempuan.UseVisualStyleBackColor = true;
            // 
            // rdoLakiLaki
            // 
            this.rdoLakiLaki.AutoSize = true;
            this.rdoLakiLaki.Location = new System.Drawing.Point(117, 109);
            this.rdoLakiLaki.Name = "rdoLakiLaki";
            this.rdoLakiLaki.Size = new System.Drawing.Size(86, 21);
            this.rdoLakiLaki.TabIndex = 21;
            this.rdoLakiLaki.TabStop = true;
            this.rdoLakiLaki.Text = "Laki-Laki";
            this.rdoLakiLaki.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Jenis Kelamin";
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(117, 62);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(200, 22);
            this.txtNama.TabIndex = 19;
            // 
            // mskNpm
            // 
            this.mskNpm.Location = new System.Drawing.Point(117, 20);
            this.mskNpm.Mask = "##.##.####";
            this.mskNpm.Name = "mskNpm";
            this.mskNpm.Size = new System.Drawing.Size(70, 22);
            this.mskNpm.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nama";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "NPM";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 303);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnTampil);
            this.Controls.Add(this.btnTutup);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpTanggalLahir);
            this.Controls.Add(this.txtTempatLahir);
            this.Controls.Add(this.rdoPerempuan);
            this.Controls.Add(this.rdoLakiLaki);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.mskNpm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Mahasiswa 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnTampil;
        private System.Windows.Forms.Button btnTutup;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpTanggalLahir;
        private System.Windows.Forms.TextBox txtTempatLahir;
        private System.Windows.Forms.RadioButton rdoPerempuan;
        private System.Windows.Forms.RadioButton rdoLakiLaki;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.MaskedTextBox mskNpm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

