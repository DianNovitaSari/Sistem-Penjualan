namespace TA_PBD15E
{
    partial class Frm_Panitia
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
            this.lst_panitia = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_tuutp = new System.Windows.Forms.Button();
            this.btn_hapus = new System.Windows.Forms.Button();
            this.btn_ubah = new System.Windows.Forms.Button();
            this.btn_simpan = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_notelepon = new System.Windows.Forms.TextBox();
            this.txt_alamatpanitia = new System.Windows.Forms.TextBox();
            this.txt_jkpanitia = new System.Windows.Forms.TextBox();
            this.txt_namaPanitia = new System.Windows.Forms.TextBox();
            this.txt_IDPanitia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_caripanitia = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.lst_panitia)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lst_panitia
            // 
            this.lst_panitia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lst_panitia.Location = new System.Drawing.Point(5, 326);
            this.lst_panitia.Name = "lst_panitia";
            this.lst_panitia.Size = new System.Drawing.Size(421, 157);
            this.lst_panitia.TabIndex = 7;
            this.lst_panitia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lst_panitia_CellContentClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_tuutp);
            this.groupBox3.Controls.Add(this.btn_hapus);
            this.groupBox3.Controls.Add(this.btn_ubah);
            this.groupBox3.Controls.Add(this.btn_simpan);
            this.groupBox3.Location = new System.Drawing.Point(4, 272);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(422, 47);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Proses";
            // 
            // btn_tuutp
            // 
            this.btn_tuutp.Location = new System.Drawing.Point(319, 20);
            this.btn_tuutp.Name = "btn_tuutp";
            this.btn_tuutp.Size = new System.Drawing.Size(75, 23);
            this.btn_tuutp.TabIndex = 4;
            this.btn_tuutp.Text = "Tutup";
            this.btn_tuutp.UseVisualStyleBackColor = true;
            this.btn_tuutp.Click += new System.EventHandler(this.btn_tuutp_Click);
            // 
            // btn_hapus
            // 
            this.btn_hapus.Location = new System.Drawing.Point(219, 20);
            this.btn_hapus.Name = "btn_hapus";
            this.btn_hapus.Size = new System.Drawing.Size(75, 23);
            this.btn_hapus.TabIndex = 3;
            this.btn_hapus.Text = "Hapus";
            this.btn_hapus.UseVisualStyleBackColor = true;
            this.btn_hapus.Click += new System.EventHandler(this.btn_hapus_Click);
            // 
            // btn_ubah
            // 
            this.btn_ubah.Location = new System.Drawing.Point(119, 20);
            this.btn_ubah.Name = "btn_ubah";
            this.btn_ubah.Size = new System.Drawing.Size(75, 23);
            this.btn_ubah.TabIndex = 2;
            this.btn_ubah.Text = "Ubah";
            this.btn_ubah.UseVisualStyleBackColor = true;
            this.btn_ubah.Click += new System.EventHandler(this.btn_ubah_Click);
            // 
            // btn_simpan
            // 
            this.btn_simpan.Location = new System.Drawing.Point(23, 18);
            this.btn_simpan.Name = "btn_simpan";
            this.btn_simpan.Size = new System.Drawing.Size(75, 23);
            this.btn_simpan.TabIndex = 1;
            this.btn_simpan.Text = "Simpan";
            this.btn_simpan.UseVisualStyleBackColor = true;
            this.btn_simpan.Click += new System.EventHandler(this.btn_simpan_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_notelepon);
            this.groupBox1.Controls.Add(this.txt_alamatpanitia);
            this.groupBox1.Controls.Add(this.txt_jkpanitia);
            this.groupBox1.Controls.Add(this.txt_namaPanitia);
            this.groupBox1.Controls.Add(this.txt_IDPanitia);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 186);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Panitia";
            // 
            // txt_notelepon
            // 
            this.txt_notelepon.Location = new System.Drawing.Point(84, 142);
            this.txt_notelepon.Name = "txt_notelepon";
            this.txt_notelepon.Size = new System.Drawing.Size(326, 20);
            this.txt_notelepon.TabIndex = 9;
            // 
            // txt_alamatpanitia
            // 
            this.txt_alamatpanitia.Location = new System.Drawing.Point(84, 116);
            this.txt_alamatpanitia.Name = "txt_alamatpanitia";
            this.txt_alamatpanitia.Size = new System.Drawing.Size(326, 20);
            this.txt_alamatpanitia.TabIndex = 8;
            // 
            // txt_jkpanitia
            // 
            this.txt_jkpanitia.Location = new System.Drawing.Point(84, 85);
            this.txt_jkpanitia.Name = "txt_jkpanitia";
            this.txt_jkpanitia.Size = new System.Drawing.Size(326, 20);
            this.txt_jkpanitia.TabIndex = 7;
            // 
            // txt_namaPanitia
            // 
            this.txt_namaPanitia.Location = new System.Drawing.Point(84, 55);
            this.txt_namaPanitia.Name = "txt_namaPanitia";
            this.txt_namaPanitia.Size = new System.Drawing.Size(326, 20);
            this.txt_namaPanitia.TabIndex = 6;
            // 
            // txt_IDPanitia
            // 
            this.txt_IDPanitia.Location = new System.Drawing.Point(84, 27);
            this.txt_IDPanitia.Name = "txt_IDPanitia";
            this.txt_IDPanitia.Size = new System.Drawing.Size(326, 20);
            this.txt_IDPanitia.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "No Telepon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Alamat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Jenis Kelamin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama Panitia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Panitia";
            // 
            // txt_caripanitia
            // 
            this.txt_caripanitia.Location = new System.Drawing.Point(14, 19);
            this.txt_caripanitia.Name = "txt_caripanitia";
            this.txt_caripanitia.Size = new System.Drawing.Size(396, 20);
            this.txt_caripanitia.TabIndex = 0;
            this.txt_caripanitia.TextChanged += new System.EventHandler(this.txt_caripanitia_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_caripanitia);
            this.groupBox2.Location = new System.Drawing.Point(3, 210);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(421, 51);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pencarian berdasarkan id / nama panitia";
            // 
            // Frm_Panitia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 495);
            this.Controls.Add(this.lst_panitia);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_Panitia";
            this.Text = "Frm_Panitia";
            this.Click += new System.EventHandler(this.Frm_Panitia_Click);
            ((System.ComponentModel.ISupportInitialize)(this.lst_panitia)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView lst_panitia;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_tuutp;
        private System.Windows.Forms.Button btn_hapus;
        private System.Windows.Forms.Button btn_ubah;
        private System.Windows.Forms.Button btn_simpan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_notelepon;
        private System.Windows.Forms.TextBox txt_alamatpanitia;
        private System.Windows.Forms.TextBox txt_jkpanitia;
        private System.Windows.Forms.TextBox txt_namaPanitia;
        private System.Windows.Forms.TextBox txt_IDPanitia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_caripanitia;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}