namespace TA_PBD15E
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siswaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panitiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programStudiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cetakProdiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transaksi = new System.Windows.Forms.ToolStripMenuItem();
            this.pendaftaranToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cetak = new System.Windows.Forms.ToolStripMenuItem();
            this.cetakLaporanPanitiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cetakLaporanProdiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cetakLaporanSiswaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cetakLaporanPendaftaranToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.dataMasterToolStripMenuItem,
            this.transaksi,
            this.cetak,
            this.helpToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(420, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logInToolStripMenuItem,
            this.logOutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // logInToolStripMenuItem
            // 
            this.logInToolStripMenuItem.Name = "logInToolStripMenuItem";
            this.logInToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.logInToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.logInToolStripMenuItem.Text = "LogIn";
            this.logInToolStripMenuItem.Click += new System.EventHandler(this.logInToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.logOutToolStripMenuItem.Text = "LogOut";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // dataMasterToolStripMenuItem
            // 
            this.dataMasterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siswaToolStripMenuItem,
            this.panitiaToolStripMenuItem,
            this.programStudiToolStripMenuItem,
            this.cetakProdiToolStripMenuItem});
            this.dataMasterToolStripMenuItem.Enabled = false;
            this.dataMasterToolStripMenuItem.Name = "dataMasterToolStripMenuItem";
            this.dataMasterToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.dataMasterToolStripMenuItem.Text = "Data Master";
            // 
            // siswaToolStripMenuItem
            // 
            this.siswaToolStripMenuItem.Name = "siswaToolStripMenuItem";
            this.siswaToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.siswaToolStripMenuItem.Text = "Siswa";
            this.siswaToolStripMenuItem.Click += new System.EventHandler(this.siswaToolStripMenuItem_Click);
            // 
            // panitiaToolStripMenuItem
            // 
            this.panitiaToolStripMenuItem.Name = "panitiaToolStripMenuItem";
            this.panitiaToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.panitiaToolStripMenuItem.Text = "Panitia";
            this.panitiaToolStripMenuItem.Click += new System.EventHandler(this.panitiaToolStripMenuItem_Click);
            // 
            // programStudiToolStripMenuItem
            // 
            this.programStudiToolStripMenuItem.Name = "programStudiToolStripMenuItem";
            this.programStudiToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.programStudiToolStripMenuItem.Text = "Program Studi";
            this.programStudiToolStripMenuItem.Click += new System.EventHandler(this.programStudiToolStripMenuItem_Click);
            // 
            // cetakProdiToolStripMenuItem
            // 
            this.cetakProdiToolStripMenuItem.Name = "cetakProdiToolStripMenuItem";
            this.cetakProdiToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.cetakProdiToolStripMenuItem.Text = "Cetak Prodi";
            // 
            // transaksi
            // 
            this.transaksi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pendaftaranToolStripMenuItem});
            this.transaksi.Enabled = false;
            this.transaksi.Name = "transaksi";
            this.transaksi.Size = new System.Drawing.Size(67, 20);
            this.transaksi.Text = "Transaksi";
            // 
            // pendaftaranToolStripMenuItem
            // 
            this.pendaftaranToolStripMenuItem.Name = "pendaftaranToolStripMenuItem";
            this.pendaftaranToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.pendaftaranToolStripMenuItem.Text = "Registrasi Pendaftaran";
            this.pendaftaranToolStripMenuItem.Click += new System.EventHandler(this.pendaftaranToolStripMenuItem_Click);
            // 
            // cetak
            // 
            this.cetak.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cetakLaporanPanitiaToolStripMenuItem,
            this.cetakLaporanProdiToolStripMenuItem,
            this.cetakLaporanSiswaToolStripMenuItem,
            this.cetakLaporanPendaftaranToolStripMenuItem});
            this.cetak.Enabled = false;
            this.cetak.Name = "cetak";
            this.cetak.Size = new System.Drawing.Size(49, 20);
            this.cetak.Text = "Cetak";
            // 
            // cetakLaporanPanitiaToolStripMenuItem
            // 
            this.cetakLaporanPanitiaToolStripMenuItem.Name = "cetakLaporanPanitiaToolStripMenuItem";
            this.cetakLaporanPanitiaToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.cetakLaporanPanitiaToolStripMenuItem.Text = "Cetak Laporan Panitia ";
            this.cetakLaporanPanitiaToolStripMenuItem.Click += new System.EventHandler(this.cetakLaporanPanitiaToolStripMenuItem_Click);
            // 
            // cetakLaporanProdiToolStripMenuItem
            // 
            this.cetakLaporanProdiToolStripMenuItem.Name = "cetakLaporanProdiToolStripMenuItem";
            this.cetakLaporanProdiToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.cetakLaporanProdiToolStripMenuItem.Text = "Cetak Laporan Prodi";
            this.cetakLaporanProdiToolStripMenuItem.Click += new System.EventHandler(this.cetakLaporanProdiToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Enabled = false;
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem1.Text = "Help";
            // 
            // cetakLaporanSiswaToolStripMenuItem
            // 
            this.cetakLaporanSiswaToolStripMenuItem.Name = "cetakLaporanSiswaToolStripMenuItem";
            this.cetakLaporanSiswaToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.cetakLaporanSiswaToolStripMenuItem.Text = "Cetak Laporan Siswa";
            this.cetakLaporanSiswaToolStripMenuItem.Click += new System.EventHandler(this.cetakLaporanSiswaToolStripMenuItem_Click);
            // 
            // cetakLaporanPendaftaranToolStripMenuItem
            // 
            this.cetakLaporanPendaftaranToolStripMenuItem.Name = "cetakLaporanPendaftaranToolStripMenuItem";
            this.cetakLaporanPendaftaranToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.cetakLaporanPendaftaranToolStripMenuItem.Text = "Cetak Laporan Pendaftaran";
            this.cetakLaporanPendaftaranToolStripMenuItem.Click += new System.EventHandler(this.cetakLaporanPendaftaranToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 328);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Menu Utama";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem siswaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem panitiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programStudiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        public System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem logInToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem transaksi;
        public System.Windows.Forms.ToolStripMenuItem cetak;
        public System.Windows.Forms.ToolStripMenuItem pendaftaranToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem dataMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cetakProdiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cetakLaporanPanitiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cetakLaporanProdiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cetakLaporanSiswaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cetakLaporanPendaftaranToolStripMenuItem;
    }
}

