namespace TA_PBD15E
{
    partial class Frm_ProgramStudi
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
            this.lst_prodi = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_tutup = new System.Windows.Forms.Button();
            this.btn_hapus = new System.Windows.Forms.Button();
            this.btn_ubah = new System.Windows.Forms.Button();
            this.btn_simpan = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_biaya = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_namaprodi = new System.Windows.Forms.ComboBox();
            this.cb_jenjangstudi = new System.Windows.Forms.ComboBox();
            this.txt_kodeprodi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lst_prodi)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lst_prodi
            // 
            this.lst_prodi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lst_prodi.Location = new System.Drawing.Point(23, 225);
            this.lst_prodi.Name = "lst_prodi";
            this.lst_prodi.Size = new System.Drawing.Size(423, 251);
            this.lst_prodi.TabIndex = 7;
            this.lst_prodi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lst_prodi_CellContentClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_tutup);
            this.groupBox3.Controls.Add(this.btn_hapus);
            this.groupBox3.Controls.Add(this.btn_ubah);
            this.groupBox3.Controls.Add(this.btn_simpan);
            this.groupBox3.Location = new System.Drawing.Point(28, 165);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(414, 54);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Proses";
            // 
            // btn_tutup
            // 
            this.btn_tutup.Location = new System.Drawing.Point(327, 19);
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
            this.btn_ubah.Location = new System.Drawing.Point(124, 19);
            this.btn_ubah.Name = "btn_ubah";
            this.btn_ubah.Size = new System.Drawing.Size(75, 23);
            this.btn_ubah.TabIndex = 2;
            this.btn_ubah.Text = "Ubah";
            this.btn_ubah.UseVisualStyleBackColor = true;
            this.btn_ubah.Click += new System.EventHandler(this.btn_ubah_Click);
            // 
            // btn_simpan
            // 
            this.btn_simpan.Location = new System.Drawing.Point(22, 19);
            this.btn_simpan.Name = "btn_simpan";
            this.btn_simpan.Size = new System.Drawing.Size(75, 23);
            this.btn_simpan.TabIndex = 1;
            this.btn_simpan.Text = "Simpan";
            this.btn_simpan.UseVisualStyleBackColor = true;
            this.btn_simpan.Click += new System.EventHandler(this.btn_simpan_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_biaya);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cb_namaprodi);
            this.groupBox1.Controls.Add(this.cb_jenjangstudi);
            this.groupBox1.Controls.Add(this.txt_kodeprodi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(23, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 123);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Program Studi";
            // 
            // txt_biaya
            // 
            this.txt_biaya.Location = new System.Drawing.Point(120, 96);
            this.txt_biaya.Name = "txt_biaya";
            this.txt_biaya.Size = new System.Drawing.Size(276, 20);
            this.txt_biaya.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Biaya Pendaftaran";
            // 
            // cb_namaprodi
            // 
            this.cb_namaprodi.FormattingEnabled = true;
            this.cb_namaprodi.Items.AddRange(new object[] {
            "Teknik Informatika",
            "Sistem Informasi",
            "Sistem Informasi Akuntansi",
            "Teknik Komputer",
            "Pendidikan Matematika",
            "Sastra Inggris",
            "Manajemen Informatika"});
            this.cb_namaprodi.Location = new System.Drawing.Point(120, 42);
            this.cb_namaprodi.Name = "cb_namaprodi";
            this.cb_namaprodi.Size = new System.Drawing.Size(277, 21);
            this.cb_namaprodi.TabIndex = 9;
            // 
            // cb_jenjangstudi
            // 
            this.cb_jenjangstudi.FormattingEnabled = true;
            this.cb_jenjangstudi.Items.AddRange(new object[] {
            "S1",
            "D3",
            "D1"});
            this.cb_jenjangstudi.Location = new System.Drawing.Point(120, 69);
            this.cb_jenjangstudi.Name = "cb_jenjangstudi";
            this.cb_jenjangstudi.Size = new System.Drawing.Size(277, 21);
            this.cb_jenjangstudi.TabIndex = 8;
            // 
            // txt_kodeprodi
            // 
            this.txt_kodeprodi.Location = new System.Drawing.Point(120, 17);
            this.txt_kodeprodi.Name = "txt_kodeprodi";
            this.txt_kodeprodi.Size = new System.Drawing.Size(277, 20);
            this.txt_kodeprodi.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Jenjang Pendidikan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama Program Studi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kode Prgram Studi";
            // 
            // Frm_ProgramStudi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 488);
            this.Controls.Add(this.lst_prodi);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_ProgramStudi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_ProgramStudi";
            this.Load += new System.EventHandler(this.Frm_ProgramStudi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lst_prodi)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView lst_prodi;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_tutup;
        private System.Windows.Forms.Button btn_hapus;
        private System.Windows.Forms.Button btn_ubah;
        private System.Windows.Forms.Button btn_simpan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_kodeprodi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_jenjangstudi;
        private System.Windows.Forms.ComboBox cb_namaprodi;
        private System.Windows.Forms.TextBox txt_biaya;
        private System.Windows.Forms.Label label4;
    }
}