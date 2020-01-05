namespace TA_PBD15E
{
    partial class Frm_Siswa
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_jeniskelamin = new System.Windows.Forms.ComboBox();
            this.dtm_tgllahir = new System.Windows.Forms.DateTimePicker();
            this.txt_notelepon = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_asalsekolah = new System.Windows.Forms.TextBox();
            this.txt_alamat = new System.Windows.Forms.TextBox();
            this.txt_namasiswa = new System.Windows.Forms.TextBox();
            this.txt_nissiswa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_tutup = new System.Windows.Forms.Button();
            this.btn_hapus = new System.Windows.Forms.Button();
            this.btn_ubah = new System.Windows.Forms.Button();
            this.btn_simpan = new System.Windows.Forms.Button();
            this.lst_siswa = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lst_siswa)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NIS";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_jeniskelamin);
            this.groupBox1.Controls.Add(this.dtm_tgllahir);
            this.groupBox1.Controls.Add(this.txt_notelepon);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_asalsekolah);
            this.groupBox1.Controls.Add(this.txt_alamat);
            this.groupBox1.Controls.Add(this.txt_namasiswa);
            this.groupBox1.Controls.Add(this.txt_nissiswa);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(427, 239);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Siswa";
            // 
            // cb_jeniskelamin
            // 
            this.cb_jeniskelamin.FormattingEnabled = true;
            this.cb_jeniskelamin.Items.AddRange(new object[] {
            "Perempuan",
            "Laki-laki"});
            this.cb_jeniskelamin.Location = new System.Drawing.Point(101, 78);
            this.cb_jeniskelamin.Name = "cb_jeniskelamin";
            this.cb_jeniskelamin.Size = new System.Drawing.Size(312, 21);
            this.cb_jeniskelamin.TabIndex = 15;
            // 
            // dtm_tgllahir
            // 
            this.dtm_tgllahir.Location = new System.Drawing.Point(101, 107);
            this.dtm_tgllahir.Name = "dtm_tgllahir";
            this.dtm_tgllahir.Size = new System.Drawing.Size(312, 20);
            this.dtm_tgllahir.TabIndex = 14;
            // 
            // txt_notelepon
            // 
            this.txt_notelepon.Location = new System.Drawing.Point(101, 197);
            this.txt_notelepon.Name = "txt_notelepon";
            this.txt_notelepon.Size = new System.Drawing.Size(312, 20);
            this.txt_notelepon.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "No.Telepon";
            // 
            // txt_asalsekolah
            // 
            this.txt_asalsekolah.Location = new System.Drawing.Point(101, 164);
            this.txt_asalsekolah.Name = "txt_asalsekolah";
            this.txt_asalsekolah.Size = new System.Drawing.Size(312, 20);
            this.txt_asalsekolah.TabIndex = 11;
            // 
            // txt_alamat
            // 
            this.txt_alamat.Location = new System.Drawing.Point(101, 136);
            this.txt_alamat.Name = "txt_alamat";
            this.txt_alamat.Size = new System.Drawing.Size(312, 20);
            this.txt_alamat.TabIndex = 10;
            // 
            // txt_namasiswa
            // 
            this.txt_namasiswa.Location = new System.Drawing.Point(101, 49);
            this.txt_namasiswa.Name = "txt_namasiswa";
            this.txt_namasiswa.Size = new System.Drawing.Size(312, 20);
            this.txt_namasiswa.TabIndex = 7;
            // 
            // txt_nissiswa
            // 
            this.txt_nissiswa.Location = new System.Drawing.Point(101, 21);
            this.txt_nissiswa.Name = "txt_nissiswa";
            this.txt_nissiswa.Size = new System.Drawing.Size(312, 20);
            this.txt_nissiswa.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Asal Sekolah";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Alamat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tanggal Lahir";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Jenis Kelamin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama Siswa";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_tutup);
            this.groupBox3.Controls.Add(this.btn_hapus);
            this.groupBox3.Controls.Add(this.btn_ubah);
            this.groupBox3.Controls.Add(this.btn_simpan);
            this.groupBox3.Location = new System.Drawing.Point(6, 261);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(426, 50);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Proses";
            // 
            // btn_tutup
            // 
            this.btn_tutup.Location = new System.Drawing.Point(328, 19);
            this.btn_tutup.Name = "btn_tutup";
            this.btn_tutup.Size = new System.Drawing.Size(75, 23);
            this.btn_tutup.TabIndex = 4;
            this.btn_tutup.Text = "Tutup";
            this.btn_tutup.UseVisualStyleBackColor = true;
            this.btn_tutup.Click += new System.EventHandler(this.btn_tutup_Click);
            // 
            // btn_hapus
            // 
            this.btn_hapus.Location = new System.Drawing.Point(227, 19);
            this.btn_hapus.Name = "btn_hapus";
            this.btn_hapus.Size = new System.Drawing.Size(75, 23);
            this.btn_hapus.TabIndex = 3;
            this.btn_hapus.Text = "Hapus";
            this.btn_hapus.UseVisualStyleBackColor = true;
            this.btn_hapus.Click += new System.EventHandler(this.btn_hapus_Click);
            // 
            // btn_ubah
            // 
            this.btn_ubah.Location = new System.Drawing.Point(125, 18);
            this.btn_ubah.Name = "btn_ubah";
            this.btn_ubah.Size = new System.Drawing.Size(75, 23);
            this.btn_ubah.TabIndex = 2;
            this.btn_ubah.Text = "Ubah";
            this.btn_ubah.UseVisualStyleBackColor = true;
            this.btn_ubah.Click += new System.EventHandler(this.btn_ubah_Click);
            // 
            // btn_simpan
            // 
            this.btn_simpan.Location = new System.Drawing.Point(25, 18);
            this.btn_simpan.Name = "btn_simpan";
            this.btn_simpan.Size = new System.Drawing.Size(75, 23);
            this.btn_simpan.TabIndex = 1;
            this.btn_simpan.Text = "Simpan";
            this.btn_simpan.UseVisualStyleBackColor = true;
            this.btn_simpan.Click += new System.EventHandler(this.btn_simpan_Click);
            // 
            // lst_siswa
            // 
            this.lst_siswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lst_siswa.Location = new System.Drawing.Point(6, 317);
            this.lst_siswa.Name = "lst_siswa";
            this.lst_siswa.Size = new System.Drawing.Size(427, 203);
            this.lst_siswa.TabIndex = 4;
            this.lst_siswa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lst_siswa_CellContentClick);
            // 
            // Frm_Siswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 538);
            this.Controls.Add(this.lst_siswa);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_Siswa";
            this.Text = "Frm_Siswa";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lst_siswa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtm_tgllahir;
        private System.Windows.Forms.TextBox txt_notelepon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_asalsekolah;
        private System.Windows.Forms.TextBox txt_alamat;
        private System.Windows.Forms.TextBox txt_namasiswa;
        private System.Windows.Forms.TextBox txt_nissiswa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_tutup;
        private System.Windows.Forms.Button btn_hapus;
        private System.Windows.Forms.Button btn_ubah;
        private System.Windows.Forms.Button btn_simpan;
        private System.Windows.Forms.DataGridView lst_siswa;
        private System.Windows.Forms.ComboBox cb_jeniskelamin;
    }
}