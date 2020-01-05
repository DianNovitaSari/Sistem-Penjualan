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
    public partial class Frm_CariSiswa : Form
    {
        private static string strconn =  "SERVER=DIANNOPITASARI\\SQLEXPRETT;Initial Catalog=db_TAPBD;Integrated Security=True";
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        public string nis, namasiswa, tglahir, jeniskelamin, alamat, asalsekolah, notelpon, biaya = "";

        private void koneksi_carisiswa()
        {
            using (SqlConnection conn = new SqlConnection(strconn))
            {
                conn.Open();
                cmd = new SqlCommand("SELECT * FROM tbl_siswapendaftar ORDER BY nis", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "tbl_siswapendaftar");
                lst_CariSiswa.DataSource = ds;
                lst_CariSiswa.DataMember = "tbl_siswapendaftar";
                lst_CariSiswa.Refresh();
                conn.Close();
            }
        }
        public Frm_CariSiswa()
        {
            InitializeComponent();
            koneksi_carisiswa();
        }

        private void txt_CariSiswa_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(strconn))
            {
                conn.Open();
                cmd = new SqlCommand(
       "select * from tbl_siswapendaftar where nis like '%" +
       txt_CariSiswa.Text + "%' or nama_siswa like'%" +
       txt_CariSiswa.Text + "%' order by nis", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "tbl_siswapendaftar");
                lst_CariSiswa.DataSource = ds;
                lst_CariSiswa.DataMember = "tbl_siswapendaftar";
                lst_CariSiswa.Refresh();
                conn.Close();
            }
        }

        private void btn_batal_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lst_CariSiswa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lst_CariSiswa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Frm_RegistrasiPendaftaran call = new Frm_RegistrasiPendaftaran();
            DataGridViewRow Row = this.lst_CariSiswa.Rows[e.RowIndex];
            nis = Row.Cells["nis"].Value.ToString();
            namasiswa = Row.Cells["nama_siswa"].Value.ToString();
            tglahir = Row.Cells["tanggal_lahir"].Value.ToString();
            jeniskelamin = Row.Cells["jenis_kelamin"].Value.ToString();
            alamat = Row.Cells["alamat"].Value.ToString();
            asalsekolah = Row.Cells["asal_sekolah"].Value.ToString();
            notelpon = Row.Cells["no_telepon"].Value.ToString();
            this.Close();
        }
        public string ambil_nis
        {
            get
            {
                return nis;
            }
        }

        public string ambil_namasiswa
        {
            get
            {
                return namasiswa;
            }
        }
        public string ambil_tgllahir
        {
            get
            {
                return tglahir;
            }
        }

        public string ambil_jeniskelamin
        {
            get
            {
                return jeniskelamin;
            }
        }
        public string ambil_alamat
        {
            get
            {
                return alamat;
            }
        }

        public string ambil_asalsekolah
        {
            get
            {
                return asalsekolah;
            }
        }
        public string ambil_notelepon
        {
            get
            {
                return notelpon;
            }
        }

        public string ambil_biayapendaftran
        {
            get
            {
                return biaya;
            }
        }
    }
}
