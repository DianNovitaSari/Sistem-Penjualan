using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TA_PBD15E
{
    public partial class Form1 : Form
    {
        public static Form1 mdiobj;
        public Form1()
        {
            InitializeComponent();
        }

        private void siswaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Siswa fsiswa = new Frm_Siswa();
            fsiswa.MdiParent = this;
            fsiswa.Show();
        }

        private void panitiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Panitia fpanitia = new Frm_Panitia();
            fpanitia.MdiParent = this;
            fpanitia.Show();
        }

        private void programStudiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ProgramStudi fprodi = new Frm_ProgramStudi();
            fprodi.MdiParent = this;
            fprodi.Show();
        }

        private void pendaftaranToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_RegistrasiPendaftaran fregistrasi = new Frm_RegistrasiPendaftaran();
            fregistrasi.MdiParent = this;
            fregistrasi.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Apakah Anda Yakin Ingin Keluar ?";
            string title = "Tutup Aplikasi";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;

            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                // Do nothing
            }     
        }

        private void logInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_login call = new Frm_login();

            call.ShowDialog();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            mdiobj = this;
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {

            dataMasterToolStripMenuItem.Enabled = false;
            transaksi.Enabled = false;
            cetak.Enabled = false;
        }

        private void cetakLaporanPanitiaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            CetakPanitia call = new CetakPanitia();
            call.ShowDialog();
        }

        private void cetakLaporanProdiToolStripMenuItem_Click(object sender, EventArgs e)
        {

            CetakProdi call = new CetakProdi();
            call.ShowDialog();
        }

        private void cetakLaporanSiswaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CetakSiswa call = new CetakSiswa();
            call.ShowDialog();
        }

        private void cetakLaporanPendaftaranToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CetakPendaftar call = new CetakPendaftar();
            call.ShowDialog();
        }
    }
}
