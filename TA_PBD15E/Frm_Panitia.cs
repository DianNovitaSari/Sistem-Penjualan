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
    public partial class Frm_Panitia : Form
    {
        private static string strconn = "SERVER=DIANNOPITASARI\\SQLEXPRETT;Initial Catalog=db_TAPBD;Integrated Security=True";
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        public string idpanitia, namapanitia, jeniskelamin, alamat, notelpon = "";
        public void koneksi_panitia()
        {
            using (SqlConnection conn = new SqlConnection(strconn))
            {
                conn.Open();
                cmd = new SqlCommand("SELECT * FROM tbl_panitia ORDER BY id_panitia", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "tbl_panitia");
                lst_panitia.DataSource = ds;
                lst_panitia.DataMember = "tbl_panitia";
                lst_panitia.Refresh();
                conn.Close();
            }
        }
        private void bersih()
        {
            txt_IDPanitia.Text = "";
            txt_namaPanitia.Text = "";
            txt_jkpanitia.Text = "";
            txt_alamatpanitia.Text = "";
            txt_notelepon.Text = "";
        }
        public Frm_Panitia()
        {
            InitializeComponent();
            koneksi_panitia();
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            if (txt_IDPanitia.Text.Trim() == "" ||
                txt_namaPanitia.Text.Trim() == "" ||
                txt_jkpanitia.Text.Trim() == "" ||
                txt_alamatpanitia.Text.Trim()=="" ||
                txt_notelepon.Text.Trim() == "")
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
                        cmd = new SqlCommand("Insert INTO tbl_panitia Values ('" +
                            txt_IDPanitia.Text + "','" + txt_namaPanitia.Text +
                            "','" + txt_jkpanitia.Text + "','" + txt_alamatpanitia.Text + "','" + txt_notelepon.Text +
                            "')", conn);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        koneksi_panitia();
                        conn.Close();
                        MessageBox.Show("data berhasil disimpan", "info",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Data tidak disimpan", "info",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }

            }
        }

        private void btn_ubah_Click(object sender, EventArgs e)
        {
            if (txt_IDPanitia.Text.Trim() == "" ||
                txt_namaPanitia.Text.Trim() == "" ||
                txt_jkpanitia.Text.Trim() == "" ||
                txt_alamatpanitia.Text.Trim() == "" ||
                txt_notelepon.Text.Trim() == "")
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
                        cmd = new SqlCommand("UPDATE tbl_panitia set id_panitia='" +
                            txt_IDPanitia.Text + "',id_panitia='" + txt_namaPanitia.Text +
                            "', nama panitia='" + txt_jkpanitia.Text +
                            "', jenis kelamin ='" + txt_alamatpanitia.Text +
                            "', alamat ='" + txt_notelepon.Text + "', no telepon ='" + txt_notelepon.Text + "' Where id_panitia='" + txt_IDPanitia.Text + "'", conn);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data berhasil diubah", "info",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bersih();
                        koneksi_panitia();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("data gagl diubah", "info",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        bersih();
                        koneksi_panitia();
                    }
                }
            }
        }

        private void btn_hapus_Click(object sender, EventArgs e)
        {
            if (txt_IDPanitia.Text.Trim() == "" ||
                txt_namaPanitia.Text.Trim() == "" ||
                txt_jkpanitia.Text.Trim() == "" ||
                txt_alamatpanitia.Text.Trim() == "" ||
                txt_notelepon.Text.Trim() == "")
            {
                MessageBox.Show("pilih data yang akan dihapus", "info",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (MessageBox.Show("hapus data ? " +
                txt_IDPanitia.Text + " ? ", "info",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(strconn))
                {
                    try
                    {
                        cmd = new SqlCommand(
                            "DELETE FROM tbl_panitia where id_panitia='" +
                            txt_IDPanitia.Text + "'", conn);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("data berhasil dihapus", "info",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bersih();
                        koneksi_panitia();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("data gagal dihapus", "info",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }

        private void btn_tuutp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lst_panitia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.lst_panitia.Rows[e.RowIndex];
            txt_IDPanitia.Text = row.Cells["id_panitia"].Value.ToString();
            txt_namaPanitia.Text = row.Cells["nama_panitia"].Value.ToString();
            txt_jkpanitia.Text = row.Cells["jenis_kelamin"].Value.ToString();
            txt_alamatpanitia.Text = row.Cells["alamat"].Value.ToString();
            txt_notelepon.Text = row.Cells["no_telepon"].Value.ToString();
        }

        private void Frm_Panitia_Click(object sender, EventArgs e)
        {

        }

        private void txt_caripanitia_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(strconn))
            {
                conn.Open();
                cmd = new SqlCommand(
       "select * from tbl_panitia where id_panitia like '%" +
       txt_caripanitia.Text + "%' or nama_panitia like'%" +
       txt_caripanitia.Text + "%' order by id_panitia", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "tbl_panitia");
                lst_panitia.DataSource = ds;
                lst_panitia.DataMember = "tbl_panitia";
                lst_panitia.Refresh();
                conn.Close();
            }
   
        }
    }
}
