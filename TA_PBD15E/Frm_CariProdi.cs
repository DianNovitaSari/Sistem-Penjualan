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
    public partial class Frm_CariProdi : Form
    {
        private static string strconn = "SERVER=DIANNOPITASARI\\SQLEXPRETT;Initial Catalog=db_TAPBD;Integrated Security=True";
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        public string kodeprodi, namaprodi, jejangpendidikan, biaya = "";
        private void koneksi_cariprodi()
        {
            using (SqlConnection conn = new SqlConnection(strconn))
            {
                conn.Open();
                cmd = new SqlCommand("SELECT * FROM tbl_prodi ORDER BY kode_prodi", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "tbl_prodi");
                lst_CariProdi.DataSource = ds;
                lst_CariProdi.DataMember = "tbl_prodi";
                lst_CariProdi.Refresh();
                conn.Close();
            }
            }
        public Frm_CariProdi()
        {
            InitializeComponent();
            koneksi_cariprodi();
        }

        private void txt_CariProdi_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(strconn))
            {
                conn.Open();
                cmd = new SqlCommand(
       "select * from tbl_prodi where kode_prodi like '%" +
       txt_CariProdi.Text + "%' or nama_prodi like'%" +
       txt_CariProdi.Text + "%' order by kode_prodi", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "tbl_prodi");
                lst_CariProdi.DataSource = ds;
                lst_CariProdi.DataMember = "tbl_prodi";
                lst_CariProdi.Refresh();
                conn.Close();
        }
    }

        private void lst_CariProdi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Frm_RegistrasiPendaftaran call = new Frm_RegistrasiPendaftaran();
            DataGridViewRow Row = this.lst_CariProdi.Rows[e.RowIndex];
            kodeprodi = Row.Cells["kode_prodi"].Value.ToString();
            namaprodi = Row.Cells["nama_prodi"].Value.ToString();
            jejangpendidikan = Row.Cells["jenjang_pendidikan"].Value.ToString();
            biaya = Row.Cells["biaya_pendaftaran"].Value.ToString();
            this.Close();
        }
        public string ambil_kodeprodi
        {
            get
            {
                return kodeprodi;
            }
        }

        public string ambil_namaprodi
        {
            get
            {
                return namaprodi;
            }
        }
        public string ambil_jenjangpendidikan
        {
            get
            {
                return jejangpendidikan;
            }
        }

        public string ambil_biaya
        {
            get
            {
                return biaya;
            }
        }

        private void btn_batal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
