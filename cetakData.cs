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

        string prodi { get; set; }
        DateTime tglmasuk { get; set; }

        public class cetakDataReport
        {
            
        }

        public cetakData(string Prodi, DateTime TglMasuk)
        {
            InitializeComponent();

            DataMahasiswa1 = new CR_Mahasiswa();

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
                DataMahasiswa1.SetDataSource(dtMahasiswa);
                crystalReportViewer1.ReportSource = DataMahasiswa1;
                crystalReportViewer1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengambil data: " + ex.Message);
            }
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }
    }
}