namespace TA_PBD15E
{
    partial class Frm_CariSiswa
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_batal = new System.Windows.Forms.Button();
            this.txt_CariSiswa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lst_CariSiswa = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lst_CariSiswa)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_batal);
            this.groupBox1.Controls.Add(this.txt_CariSiswa);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 56);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cari Data Siswa berdasrkan NIS / Nama Siswa";
            // 
            // btn_batal
            // 
            this.btn_batal.Location = new System.Drawing.Point(365, 18);
            this.btn_batal.Name = "btn_batal";
            this.btn_batal.Size = new System.Drawing.Size(75, 23);
            this.btn_batal.TabIndex = 2;
            this.btn_batal.Text = "Batal";
            this.btn_batal.UseVisualStyleBackColor = true;
            this.btn_batal.Click += new System.EventHandler(this.btn_batal_Click);
            // 
            // txt_CariSiswa
            // 
            this.txt_CariSiswa.Location = new System.Drawing.Point(70, 20);
            this.txt_CariSiswa.Name = "txt_CariSiswa";
            this.txt_CariSiswa.Size = new System.Drawing.Size(292, 20);
            this.txt_CariSiswa.TabIndex = 1;
            this.txt_CariSiswa.TextChanged += new System.EventHandler(this.txt_CariSiswa_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cari Siswa";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lst_CariSiswa);
            this.groupBox2.Location = new System.Drawing.Point(8, 83);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(448, 221);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data Siswa";
            // 
            // lst_CariSiswa
            // 
            this.lst_CariSiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lst_CariSiswa.Location = new System.Drawing.Point(5, 20);
            this.lst_CariSiswa.Name = "lst_CariSiswa";
            this.lst_CariSiswa.Size = new System.Drawing.Size(435, 195);
            this.lst_CariSiswa.TabIndex = 0;
            this.lst_CariSiswa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lst_CariSiswa_CellClick);
            this.lst_CariSiswa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lst_CariSiswa_CellContentClick);
            // 
            // Frm_CariSiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 316);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_CariSiswa";
            this.Text = "Frm_CariSiswa";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lst_CariSiswa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_batal;
        private System.Windows.Forms.TextBox txt_CariSiswa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView lst_CariSiswa;
    }
}