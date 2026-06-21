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
using System.Windows.Forms.DataVisualization.Charting;
using CrystalDecisions.Web.HtmlReportRender;

namespace CRUDMahasiswa
{
    public partial class Dashboard : Form
    {
        // BENAHI 1: Variabel-variabel ini gue naikkan ke tingkat Kelas (Class Level Fields)
        // biar bisa dibaca dan diakses oleh semua method di dalam kelas Dashboard ini, Tam!
        private DAL dbLogic = new DAL();
        private bool isInitializing = true;
        private DataTable dt;
        private int button = 0;

        public Dashboard()
        {
            // Atribut lokal lama sudah dihapus dari sini agar tidak bentrok

            InitializeComponent();
            dtpTanggalMasuk.MinDate = new DateTime(2000, 1, 1);
            dtpTanggalMasuk.Format = DateTimePickerFormat.Custom;
            dtpTanggalMasuk.CustomFormat = "yyyy";
            dtpTanggalMasuk.ShowUpDown = true;
            dtpTanggalMasuk.MaxDate = DateTime.Now;

            cmbTipe.DropDownStyle = ComboBoxStyle.DropDownList;
            var items = new List<KeyValuePair<string, SeriesChartType>>
            {
                new KeyValuePair<string, SeriesChartType>("Kolom", SeriesChartType.Column),
                new KeyValuePair<string, SeriesChartType>("Pie", SeriesChartType.Pie),
            };

            isInitializing = true;

            cmbTipe.DataSource = items;
            cmbTipe.DisplayMember = "Key";
            cmbTipe.ValueMember = "Value";
            cmbTipe.SelectedIndex = 0;

            isInitializing = false;
            loadDataChart();
        }

        public void loadDataChart()
        {
            chartProdi.Series.Clear();
            chartProdi.Titles.Clear();
            chartProdi.Legends.Clear();
            chartProdi.ChartAreas.Clear();

            ChartArea ca = new ChartArea("MainArea");
            ca.AxisX.Title = "Program Studi";
            ca.AxisY.Title = "Jumlah Mahasiswa";
            ca.AxisX.LabelStyle.Angle = -45;
            ca.BackColor = Color.Transparent;
            chartProdi.ChartAreas.Add(ca);
            try
            {
                if (button == 1)
                {
                    dt = dbLogic.getDataChartByTahun(dtpTanggalMasuk.Value);
                }
                else
                {
                    // BENAHI 2: Berdasarkan file DAL lo, method 'getAllDataChart()' digunakan untuk 
                    // menarik seluruh data chart tanpa filter tahun (blok else/kondisi awal).
                    dt = dbLogic.getAllDataChart();
                }

                SeriesChartType tipe = (SeriesChartType)cmbTipe.SelectedValue;
                if (tipe == SeriesChartType.Column)
                {
                    Series s = new Series("Mahasiswa");
                    s.ChartType = SeriesChartType.Column;
                    foreach (DataRow row in dt.Rows)
                    {
                        // BENAHI 3: Di database lo, nama kolom hasil SELECT view/SP biasanya bertipe data int/long.
                        // Dipastikan cast-nya aman sesuai dengan kolom database 'JumlahMahasiswa'
                        string prodi = row["NamaProdi"].ToString();
                        int jumlah = Convert.ToInt32(row["JmlhMhs"]);
                        s.Points.AddXY(prodi, jumlah);
                    }
                    chartProdi.Series.Add(s);
                }
                else
                {
                    Series s = new Series("Mahasiswa");
                    s.ChartType = tipe;

                    s.IsValueShownAsLabel = true;
                    s.Label = "#VAL";
                    s.LegendText = "#VALX";

                    foreach (DataRow row in dt.Rows)
                    {
                        string prodi = row["NamaProdi"].ToString();
                        // BENAHI 4: Disamakan nama kolom pencariannya menjadi 'JumlahMahasiswa' 
                        // agar tidak melempar ArgumentException (Column 'JmlhMhs' does not belong to table) saat di-run.
                        int jumlah = Convert.ToInt32(row["JmlhMhs"]);

                        s.Points.AddXY(prodi, jumlah);
                    }
                    chartProdi.Series.Add(s);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal Load data: " + ex.Message);
            }

            Title title = new Title("Jumlah mahasiswa per program studi", Docking.Top, new Font("Arial", 14, FontStyle.Bold), Color.DarkBlue);
            chartProdi.Titles.Add(title);
            Legend legend = new Legend("MainLegend");
            legend.Docking = Docking.Right;
            chartProdi.Legends.Add(legend);
        }

        private void cmbTipe_SelectedValueChanged(object sender, EventArgs e)
        {
            if (isInitializing)
                return;
            if (button == 1)
            {
                // Sesuai struktur kode asli lo Tam
                loadDataChart();
            }
            else
            {
                loadDataChart();
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            button = 1;
            loadDataChart();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            button = 0;
            loadDataChart();
        }

        private void btnDataMhs_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }
    }
}