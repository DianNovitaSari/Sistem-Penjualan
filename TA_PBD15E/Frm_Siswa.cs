using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace TA_PBD15E
{
    public partial class Frm_Siswa : Form
    {
        
        private static string strconn = "SERVER=DIANNOPITASARI\\SQLEXPRETT;Initial Catalog=db_TAPBD;Integrated Security=True";
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        public string nis, jeniskelamin,namasiswa, alamat, asalsekolah, notlpn, tgllahir = "";
        public void koneksi_siswa()
        {
            using (SqlConnection conn = new SqlConnection(strconn))
            {
                conn.Open();
                cmd = new SqlCommand("SELECT * FROM tbl_siswapendaftar ORDER BY nis", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "tbl_siswapendaftar");
                lst_siswa.DataSource = ds;
                lst_siswa.DataMember = "tbl_siswapendaftar";
                lst_siswa.Refresh();
                conn.Close();
            }
        }
        private void bersih()
        {
            txt_nissiswa.Text = "";
            txt_namasiswa.Text = "";
            cb_jeniskelamin.Text = "";
            txt_alamat.Text = "";
            dtm_tgllahir.Text = "";
            txt_notelepon.Text = "";
            txt_asalsekolah.Text = "";
        }
        public Frm_Siswa()
        {
            InitializeComponent();
            koneksi_siswa();
        }

        private void btn_tambah_Click(object sender, EventArgs e)
        {

        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            if (txt_nissiswa.Text.Trim() == "" ||
                txt_namasiswa.Text.Trim() == "" ||
                cb_jeniskelamin.Text.Trim() == "" ||
                dtm_tgllahir.Text.Trim() == "" ||
                txt_notelepon.Text.Trim() == ""||
                txt_alamat.Text.Trim() == "")
            {
                //pesan data belum lengkap
                MessageBox.Show("Data Belum Lengkap", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                using (SqlConnection conn = new SqlConnection(strconn))
                {

                    try
                    {
                        cmd = new SqlCommand("Insert INTO tbl_siswapendaftar Values ('" +
                            txt_nissiswa.Text + "','" + txt_namasiswa.Text +
                            "','" + cb_jeniskelamin.Text + "','" + txt_alamat.Text + "','" + dtm_tgllahir.Value.Date.ToString("yyyy/MMM/dd") + "','" + txt_asalsekolah.Text + "','" + txt_notelepon.Text +
                            "')", conn);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        koneksi_siswa();
                        conn.Close();
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("data berhasil disimpan", "info",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }
       
        }

        private void btn_ubah_Click(object sender, EventArgs e)
        {
            if (txt_nissiswa.Text.Trim() == "" ||
                txt_namasiswa.Text.Trim() == "" ||
                cb_jeniskelamin.Text.Trim() == "" ||
                dtm_tgllahir.Text.Trim() == "" ||
                txt_notelepon.Text.Trim() == "" ||
                txt_alamat.Text.Trim() == ""||
                txt_asalsekolah.Text.Trim() == "")
            {
                MessageBox.Show("pilih data yang akan diubah", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                using (SqlConnection conn = new SqlConnection(strconn))
                {
                    try
                    {
                        cmd = new SqlCommand("UPDATE tbl_siswapendaftar set nis='" +
                            txt_nissiswa.Text + "',nis='" + txt_namasiswa.Text +
                            "', nama siswa='" + dtm_tgllahir.Text +
                            "', tanggal lahir ='" + txt_alamat.Text +
                            "', alamat ='" + txt_asalsekolah.Text + "', asal sekolah='" + cb_jeniskelamin.Text + "', jenis kelamin ='" + cb_jeniskelamin.Text + "' Where nis='" + txt_nissiswa.Text + "'", conn);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data berhasil diubah", "info",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bersih();
                        koneksi_siswa();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("data gagl diubah", "info",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        bersih();
                        koneksi_siswa();
                    }
                }
            }
        }

        private void btn_hapus_Click(object sender, EventArgs e)
        {

            if (txt_nissiswa.Text.Trim() == "" ||
                txt_namasiswa.Text.Trim() == "" ||
                cb_jeniskelamin.Text.Trim() == "" ||
                dtm_tgllahir.Text.Trim() == "" ||
                txt_notelepon.Text.Trim() == "" ||
                txt_alamat.Text.Trim() == "" ||
                txt_asalsekolah.Text.Trim() == "")
            {
                MessageBox.Show("pilih data yang akan dihapus", "info",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (MessageBox.Show("hapus data ? " +
                txt_nissiswa.Text + " ? ", "info",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(strconn))
                {
                    try
                    {
                        cmd = new SqlCommand(
                            "DELETE FROM tbl_siswapendaftar where nis='" +
                            txt_nissiswa.Text + "'", conn);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("data berhasil dihapus", "info",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bersih();
                        koneksi_siswa();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("data gagal dihapus", "info",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }

        private void btn_tutup_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lst_siswa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.lst_siswa.Rows[e.RowIndex];
            txt_nissiswa.Text = row.Cells["nis"].Value.ToString();
            txt_namasiswa.Text = row.Cells["nama_siswa"].Value.ToString();
            cb_jeniskelamin.Text = row.Cells["jenis_kelamin"].Value.ToString();
            dtm_tgllahir.Text = row.Cells["tanggal_lahir"].Value.ToString();
            txt_notelepon.Text = row.Cells["no_telepon"].Value.ToString();
            txt_alamat.Text = row.Cells["alamat"].Value.ToString();
            txt_asalsekolah.Text = row.Cells["asal_sekolah"].Value.ToString();

        }

        private void txt_carisiswa_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
