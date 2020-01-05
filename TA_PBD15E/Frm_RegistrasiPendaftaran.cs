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
    public partial class Frm_RegistrasiPendaftaran : Form
    {

        private static string strconn = "SERVER=DIANNOPITASARI\\SQLEXPRETT;Initial Catalog=db_TAPBD;Integrated Security=True";
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
         private SqlDataReader rd;
        private void koneksi_registrasi()
           {
            using (SqlConnection conn = new SqlConnection(strconn))
            {
                conn.Open();
                cmd = new SqlCommand("SELECT * FROM vw_detail_pendaftaran ", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "vw_detail_pendaftaran");
                lst_registrasi.DataSource = ds;
                lst_registrasi.DataMember = "vw_detail_pendaftaran";
                lst_registrasi.Refresh();
                conn.Close();
            }
        }
        private void otomatis() {
            long hitung;
            string urut;
            using (SqlConnection conn = new SqlConnection(strconn))
            {
                conn.Open();
                cmd = new SqlCommand(
                    "select id_pendaftaran from tbl_pendaftaran where id_pendaftaran in(select max(id_pendaftaran) from tbl_pendaftaran) ORDER BY id_pendaftaran DESC", conn);
                rd = cmd.ExecuteReader();
                rd.Read();

                if (rd.HasRows)
                {
                    hitung = Convert.ToInt16(rd[0].ToString().Substring(

                        rd["id_pendaftaran"].ToString().Length - 4, 4)) + 1;
                    string jointstr = "0000" + hitung;
                    urut = "PDF" + jointstr.Substring(jointstr.Length - 4 , 4);

                }
                else {
                    urut = "PDF0001";
                }
                rd.Close();
                txt_idregistrasi.Text = urut; conn.Close();
            }
        } 
        private void bersih_seluruh()
        {
            txt_idPanitia.Text = "";
            dtm_tglregistrasi.Value = DateTime.Now;
            txt_namaPanitia.Text = "0";
            txt_NIS.Text = "";
            txt_namasiswa.Text = "";
            dtm_tglahir.Value = DateTime.Now;
            txt_jeniskelamin.Text = "";
            txt_alamat.Text = "";
            txt_aslsekolah.Text = "";
            txt_notelepon.Text = "";
            txt_kodeprodi.Text = "";
            cb_namaprodi.Text = "";
            cb_jenjangstudi.Text = "";
            txt_biaya.Text = "";
        }
        public Frm_RegistrasiPendaftaran()
        {
         
           InitializeComponent();
            koneksi_registrasi();
            otomatis();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txt_NIS.Text.Trim() == "" ||
                txt_idPanitia.Text.Trim() == "" ||
                txt_biaya.Text.Trim() == "0")
            {
                //pesan data belum lengkap
                MessageBox.Show("Data Belum Lengkap");
            }
            else
            {
                using (SqlConnection conn = new SqlConnection(strconn))
                {
                    try
                    {
                        cmd = new SqlCommand("Insert INTO tbl_pendaftaran Values ('" +
                           txt_idregistrasi.Text+"','"+
                           txt_NIS.Text+"','" +
                           txt_idPanitia.Text + "','" +
                           dtm_tglregistrasi.Value.Date.ToString("yyyy/MMM/dd")+"','"+   
                           txt_kodeprodi.Text+"')", conn);
                        
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("data tersimpan");
                        koneksi_registrasi();
                        bersih_seluruh();
                       // otomatis();
                       
                        conn.Close();
                    }
                    catch (Exception)
          
                    {
                        MessageBox.Show("Gagal disimpan");
                    }
                }
            }
        }

        private void btn_caripanitia_Click(object sender, EventArgs e)
        {
            Frm_CariPanitia call = new Frm_CariPanitia();
            call.ShowDialog();
            txt_idPanitia.Text = call.ambil_idpanitia;
            txt_namaPanitia.Text = call.ambil_namapanitia;

        }

        private void btn_carisiswa_Click(object sender, EventArgs e)
        {
            Frm_CariSiswa call = new Frm_CariSiswa();
            call.ShowDialog();
            txt_NIS.Text = call.ambil_nis;
            txt_namasiswa.Text = call.ambil_namasiswa;
            dtm_tglahir.Text = call.ambil_tgllahir;
            txt_jeniskelamin.Text = call.ambil_jeniskelamin;
            txt_alamat.Text = call.ambil_alamat;
            txt_aslsekolah.Text = call.ambil_asalsekolah;
            txt_notelepon.Text = call.ambil_notelepon;
         
        }

        private void dtm_tglregistrasi_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_CariProdi_Click(object sender, EventArgs e)
        {
            Frm_CariProdi call = new Frm_CariProdi();
            call.ShowDialog();
            txt_kodeprodi.Text = call.ambil_kodeprodi;
            cb_namaprodi.Text = call.ambil_namaprodi;
            cb_jenjangstudi.Text = call.ambil_jenjangpendidikan;
            txt_biaya.Text = call.ambil_biaya;

           
        }

        private void btn_baru_Click(object sender, EventArgs e)
        {
            bersih_seluruh();
            koneksi_registrasi();
            otomatis();
        }

        private void btn_hapus_Click(object sender, EventArgs e)
        {
            if (txt_idregistrasi.Text.Trim() == "" ||
                txt_NIS.Text.Trim() == "" ||
                txt_idPanitia.Text.Trim() == "" ||
                txt_biaya.Text.Trim() == "0")
            {
                MessageBox.Show("pilih data yang akan di hapus");
            }
            else if (MessageBox.Show("hapus data" +
              txt_idregistrasi.Text + " ? ", "info ", MessageBoxButtons.YesNo,
              MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(strconn))
                {
                    try
                    {

                        conn.Open();
                        cmd = new SqlCommand("delete tbl_pendaftaran where id_pendaftaran ='" +
                            txt_idregistrasi.Text + "'", conn);
                        cmd.ExecuteReader();
                       
                        {

                            MessageBox.Show("Data Berhasil Di Hapus");
                            conn.Close();
                            
                            koneksi_registrasi();
                            bersih_seluruh();
                            otomatis();
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Data Gagal Di Hapus");
                    }
                }
            }
        }

        private void lst_registrasi_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public string idregistrasi, idpanita,namapanitia,nis,namasiswa,tanggallahir,jeniskelamin,alamat,asalsekolah,notelpon,kodeprodi,namaprodi,jenjangpendidikan,biaya;
        
        private void lst_registrasi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow row = this.lst_registrasi.Rows[e.RowIndex];
            txt_idregistrasi.Text = row.Cells["id_pendaftaran"].Value.ToString();
            txt_idPanitia.Text = row.Cells["id_panitia"].Value.ToString();
            txt_namaPanitia.Text = row.Cells["nama_panitia"].Value.ToString();
            txt_NIS.Text = row.Cells["nis"].Value.ToString();
            txt_namasiswa.Text = row.Cells["nama_siswa"].Value.ToString();
            dtm_tglahir.Text = row.Cells["tanggal_lahir"].Value.ToString();
            txt_jeniskelamin.Text = row.Cells["jenis_kelamin"].Value.ToString();
            txt_alamat.Text = row.Cells["alamat"].Value.ToString();
            txt_aslsekolah.Text = row.Cells["asal_sekolah"].Value.ToString();
            txt_notelepon.Text = row.Cells["no_telepon"].Value.ToString();
            txt_kodeprodi.Text = row.Cells["kode_prodi"].Value.ToString();
            cb_namaprodi.Text = row.Cells["nama_prodi"].Value.ToString();
            cb_jenjangstudi.Text = row.Cells["jenjang_pendidikan"].Value.ToString();
            txt_biaya.Text = row.Cells["biaya_pendaftaran"].Value.ToString();
            btn_cetak.Enabled = true;
            idregistrasi = txt_idregistrasi.Text;
            idpanita = txt_idPanitia.Text;
            namapanitia = txt_namaPanitia.Text;
            nis = txt_NIS.Text;
            namasiswa = txt_namasiswa.Text;
            tanggallahir = dtm_tglahir.Text;
            jeniskelamin = txt_jeniskelamin.Text;
            alamat = txt_alamat.Text;
            asalsekolah = txt_aslsekolah.Text;
            notelpon = txt_notelepon.Text;
            kodeprodi = txt_kodeprodi.Text;
            namaprodi = cb_namaprodi.Text;
            jenjangpendidikan = cb_jenjangstudi.Text;
            biaya = txt_biaya.Text;
            
        }

        private void btn_cetak_Click(object sender, EventArgs e)
        {
            FormCetakFaktur call = new FormCetakFaktur();
            call.ambildata(idregistrasi, idpanita, namapanitia, nis, namasiswa, tanggallahir, jeniskelamin, alamat, asalsekolah, notelpon, kodeprodi, namaprodi, jenjangpendidikan, biaya);
            call.ShowDialog();
        }
    }
}
