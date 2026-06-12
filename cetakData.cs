using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDMahasiswa
{
    public partial class cetakData : Form
    {
        static string connectionString = "Data Source=tomiskibidi\\TAMA;Initial Catalog=DBAkademikADO;Integrated Security=True";
        SqlConnection conn = new SqlConnection(connectionString);
        SqlDataAdapter da;
        DataTable dtMahasiswa;

        DataMahasiswa dataMahasiswa = new DataMahasiswa();
        string prodi { get; set; }
        DateTime tglmasuk { get; set; }

        public class cetakDataReport
        {
            // Sub-class kosong dipertahankan sesuai struktur lo
        }

        public cetakData(string Prodi, DateTime TglMasuk)
        {
            InitializeComponent();

            prodi = Prodi;
            tglmasuk = TglMasuk;

            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                SqlCommand cmd = new SqlCommand("sp_Report", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                // KOREKSI SINKRONISASI: Nama parameter disesuaikan dengan yang ada di Form Report lo (@inProdi & @inTahunMasuk)
                cmd.Parameters.Add("@inProdi", SqlDbType.VarChar, 50).Value = prodi;
                cmd.Parameters.Add("@inTglMsuk", SqlDbType.VarChar, 4).Value = tglmasuk.Year.ToString();

                da = new SqlDataAdapter(cmd);

                dtMahasiswa = new DataTable();
                da.Fill(dtMahasiswa);

                conn.Close();

                // Inject data ke dalam Crystal Report
                dataMahasiswa.SetDataSource(dtMahasiswa);
                crystalReportViewer1.ReportSource = dataMahasiswa;
                crystalReportViewer1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengambil data: " + ex.Message);
            }
        }
    }
}