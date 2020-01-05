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
    public partial class Frm_ProgramStudi : Form
    {
        private static string strconn = "SERVER=DIANNOPITASARI\\SQLEXPRETT;Initial Catalog=db_TAPBD;Integrated Security=True";
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        private SqlDataReader rd;
        public string kodeprodi, namaprodi, jenjangpendidikan = "";
        public void koneksi_prodi()
        {
            using (SqlConnection conn = new SqlConnection(strconn))
            {
                conn.Open();
                cmd = new SqlCommand("SELECT * FROM tbl_prodi ORDER BY kode_prodi", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "tbl_prodi");
                lst_prodi.DataSource = ds;
                lst_prodi.DataMember = "tbl_prodi";
                lst_prodi.Refresh();
                conn.Close();
            }
        }
        private void otomatis()
        {
            long hitung;
            string urut;
            using (SqlConnection conn = new SqlConnection(strconn))
            {
                conn.Open();
                cmd = new SqlCommand(
                    "select kode_prodi from tbl_prodi where kode_prodi in(select max(kode_prodi) from tbl_prodi) ORDER BY kode_prodi DESC", conn);
                rd = cmd.ExecuteReader();
                rd.Read();

                if (rd.HasRows)
                {
                    hitung = Convert.ToInt16(rd[0].ToString().Substring(

                        rd["kode_prodi"].ToString().Length - 4, 4)) + 1;
                    string jointstr = "0000" + hitung;
                    urut = "PRD" + jointstr.Substring(jointstr.Length - 4, 4);

                }
                else
                {
                    urut = "PRD0001";
                }
                rd.Close(); txt_kodeprodi.Text = urut; conn.Close();
            }
        } 
        private void bersih()
        {
            txt_kodeprodi.Text = "";
            cb_namaprodi.Text = "";
           
            cb_jenjangstudi.Text = "";
        }
        public Frm_ProgramStudi()
        {
            InitializeComponent();
            koneksi_prodi();
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            if (txt_kodeprodi.Text.Trim() == "" ||
                cb_namaprodi.Text.Trim() == "" ||
                cb_jenjangstudi.Text.Trim() == "")
                
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
                        cmd = new SqlCommand("Insert INTO tbl_prodi Values ('" +
                            txt_kodeprodi.Text + "','" + cb_namaprodi.Text +
                            "','" + cb_jenjangstudi.Text + "','" +
                            "')", conn);
                        conn.Open();
                        cmd.ExecuteNonQuery();
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
            if (txt_kodeprodi.Text.Trim() == "" ||
                cb_namaprodi.Text.Trim() == "" ||
                cb_jenjangstudi.Text.Trim() == "" )
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
                        cmd = new SqlCommand("UPDATE tbl_prodi set kode_prodi='" +
                            txt_kodeprodi.Text + "',kode prodi='" + cb_namaprodi.Text +
                            "', nama prodi='" + cb_jenjangstudi.Text +
                            "', jenjang studi ='" +  cb_jenjangstudi.Text +  "' Where kode_prodi='" + txt_kodeprodi.Text + "'", conn);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data berhasil diubah", "info",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bersih();
                        koneksi_prodi();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("data gagl diubah", "info",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        bersih();
                        koneksi_prodi();
                    }
                }
            }
        }

        private void btn_hapus_Click(object sender, EventArgs e)
        {
            if (txt_kodeprodi.Text.Trim() == "" ||
               cb_namaprodi.Text.Trim() == "" ||
               cb_jenjangstudi.Text.Trim() == "" )
               
            {
                MessageBox.Show("pilih data yang akan dihapus", "info",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (MessageBox.Show("hapus data ? " +
                txt_kodeprodi + " ? ", "info",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(strconn))
                {
                    try
                    {
                        cmd = new SqlCommand(
                            "DELETE FROM tbl_prodi where kode_prodi='" +
                            txt_kodeprodi.Text + "'", conn);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("data berhasil dihapus", "info",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bersih();
                        koneksi_prodi();
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

        private void lst_prodi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.lst_prodi.Rows[e.RowIndex];
            txt_kodeprodi.Text = row.Cells["kode_prodi"].Value.ToString();
            cb_namaprodi.Text = row.Cells["nama_prodi"].Value.ToString();
            cb_jenjangstudi.Text = row.Cells["jenis_pendidikan"].Value.ToString();
            txt_biaya.Text = row.Cells["biaya_pendaftaran"].Value.ToString();
            
        }

        private void Frm_ProgramStudi_Load(object sender, EventArgs e)
        {

        }
    }
}
 