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
    public partial class Frm_CariPanitia : Form
    {
        private static string strconn = "SERVER=DIANNOPITASARI\\SQLEXPRETT;Initial Catalog=db_TAPBD;Integrated Security=True";
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        public string idpanitia, namapanitia, jeniskelamin, alamat, notelepon = "";
        private void koneksi_caripanitia()
        {
            using (SqlConnection conn = new SqlConnection(strconn))
            {
                conn.Open();
                cmd = new SqlCommand("SELECT * FROM tbl_panitia ORDER BY id_panitia", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "tbl_panitia");
                lst_Caripanitia.DataSource = ds;
                lst_Caripanitia.DataMember = "tbl_panitia";
                lst_Caripanitia.Refresh();
                conn.Close();
            }
        }
        public Frm_CariPanitia()
        {
            InitializeComponent();
            koneksi_caripanitia();
        }

        private void txt_CariPanitia_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(strconn))
            {
                conn.Open();
                cmd = new SqlCommand(
       "select * from tbl_panitia where id_panitia like '%" +
       txt_CariPanitia.Text + "%' or nama_panitia like'%" +
       txt_CariPanitia.Text + "%' order by id_panitia", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "tbl_panitia");
                lst_Caripanitia.DataSource = ds;
                lst_Caripanitia.DataMember = "tbl_panitia";
                lst_Caripanitia.Refresh();
                conn.Close();
            }
        }

        private void btn_batal_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lst_Caripanitia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        

        private void lst_Caripanitia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Frm_RegistrasiPendaftaran call = new Frm_RegistrasiPendaftaran();
            DataGridViewRow Row = this.lst_Caripanitia.Rows[e.RowIndex];
            idpanitia = Row.Cells["id_Panitia"].Value.ToString();
            namapanitia = Row.Cells["nama_panitia"].Value.ToString();
            jeniskelamin = Row.Cells["jenis_kelamin"].Value.ToString();
            alamat = Row.Cells["alamat"].Value.ToString();
            notelepon = Row.Cells["no_telepon"].Value.ToString();
            this.Close();
        }

        private void Frm_CariPanitia_Load(object sender, EventArgs e)
        {

        }
        public string ambil_idpanitia
        {
            get
            {
                return idpanitia;
            }
        }

        public string ambil_namapanitia
        {
            get
            {
                return namapanitia;
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
        public string ambil_notelepon
        {
            get
            {
                return notelepon;
            }
        }
    }
    }

