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
    public partial class Frm_login : Form
    {
         private static string strconn = "SERVER=DIANNOPITASARI\\SQLEXPRETT;Initial Catalog=db_TAPBD;Integrated Security=True";
        private SqlCommand cmd;
       
        public Frm_login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_user.Text.Trim() == "" || txt_password.Text.Trim() == "")
            {
                MessageBox.Show(" User dan Pasword Harap di Isi ");
            }
            else
            {
                SqlDataReader rd = null;
                using (SqlConnection conn = new SqlConnection(strconn))
                {
                    conn.Open();
                    cmd = new SqlCommand(
                        "Select * from tbl_login where pengguna = '" + txt_user.Text + "' and kata_sandi = '" + txt_password.Text + "'", conn);
                    cmd.ExecuteNonQuery();
                    rd = cmd.ExecuteReader();
                    if (rd.Read())
                    {
                        MessageBox.Show("Berhasil Masuk");
                        Form1.mdiobj.transaksi.Enabled = true;
                        Form1.mdiobj.dataMasterToolStripMenuItem.Enabled = true;
                        Form1.mdiobj.cetak.Enabled = true;
                       
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(" user atau sandi salah ");
                        txt_user.Text="";
                        txt_password.Text="";
                        txt_user.Focus();
                    }
                }
            }
        }

        private void Frm_login_Load(object sender, EventArgs e)
        {
           
        }

        private void btn_batal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
