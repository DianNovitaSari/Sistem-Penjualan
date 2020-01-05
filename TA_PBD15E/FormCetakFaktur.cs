using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;



namespace TA_PBD15E
{
    public partial class FormCetakFaktur : Form
       {
        public string idregistrasi, idpanita,namapanitia,nis,namasiswa,tanggallahir,jeniskelamin,alamat,asalsekolah,notelpon,kodeprodi,namaprodi,jenjangpendidikan,biaya;
        public void ambildata(string idregistrasi1,
            string idpanitia1,
            string namapanitia1,
            string nis1,
            string namasiswa1,
            string tanggallahir1,
            string jeniskelamin1, 
            string alamat1,
            string asalsekolah1,
            string notelepon1,
            string kodeprodi1,
            string namaprodi1,
            string jenjangpendidikan1,
            string biaya1)
        {
            idregistrasi = idregistrasi1;
            idpanita = idpanitia1;
            namapanitia = namapanitia1;
            nis = nis1;
            namasiswa = namasiswa1;
            tanggallahir = tanggallahir1;
            jeniskelamin =jeniskelamin1;
            alamat = alamat1;
            asalsekolah = asalsekolah1;
            notelpon = notelepon1;
            kodeprodi = kodeprodi1;
            namaprodi = namaprodi1;
            jenjangpendidikan = jenjangpendidikan1;
            biaya = biaya1;
        }

        public FormCetakFaktur()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
         ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load("D:\\TA_PBD\\Ta_pbd15e-DIAN NOVITA SARI - 15312544\\TA_PBD15E\\FakturPendaftar.rpt");
            crystalReportViewer1.ReportSource = cryRpt;
            cryRpt.SetParameterValue("nis", nis);
            cryRpt.SetParameterValue("id_registras", idregistrasi);
            cryRpt.SetParameterValue("id_panitia", idpanita);
            cryRpt.SetParameterValue("nama_panitia", namapanitia);
            cryRpt.SetParameterValue("nama_siswa", namasiswa);
            cryRpt.SetParameterValue("tanggal_lahir", tanggallahir);
            cryRpt.SetParameterValue("jenis_kelamin", jeniskelamin);
            cryRpt.SetParameterValue("alamat", alamat);
            cryRpt.SetParameterValue("asal_sekolah", asalsekolah);
            cryRpt.SetParameterValue("no_telepon", notelpon);
            cryRpt.SetParameterValue("kode_prodi", kodeprodi);
            cryRpt.SetParameterValue("nama_prodi", namaprodi);
            cryRpt.SetParameterValue("jenjang_pendidikan", jenjangpendidikan);
            cryRpt.SetParameterValue("biaya_pendaftaran", biaya);
            crystalReportViewer1.Refresh();
        }
    }
}
